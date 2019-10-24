MONO = mono
MONOC = mcs
MONOCFLAGS = -define:EXPORT_GPPG #-optimize #-reference:${PARSERREF}
GPLEX = ${MONO} lib/gplex.exe
GPPG = ${MONO} lib/gppg.exe
PARSERREF = lib/QUT.ShiftReduceParser.dll
CSFILES = Absyn.cs Parser.cs ShiftReduceParserCode.cs Printer.cs Scanner.cs Test.cs VisitSkeleton.cs AbstractVisitSkeleton.cs
all: test

clean:
	rm -f OCL.pdf test

distclean: clean
	rm -f ${CSFILES}
	rm -f OCL.l OCL.y OCL.tex
	rm -f Makefile

test: Parser.cs Scanner.cs
	@echo "Compiling test..."
	${MONOC} ${MONOCFLAGS} -out:bin/test.exe ${CSFILES}

Scanner.cs: OCL.l
	${GPLEX} /out:$@ OCL.l

Parser.cs: OCL.y
	${GPPG} /gplex OCL.y > $@
