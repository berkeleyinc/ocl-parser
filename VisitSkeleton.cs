/*** BNFC-Generated Visitor Design Pattern Skeleton. ***/
/* This implements the common visitor design pattern. To make sure that
   compile errors occur when code in the Visitor don't match the abstract
   syntaxt, the "abstract visit skeleton" is used.
   
   Replace the R and A parameters with the desired return
   and context types.*/

namespace OCL.VisitSkeleton
{
  #region Classes
  public class OCLfileVisitor<R,A> : AbstractOCLfileVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.OCLf oclf_, A arg)
    {
      /* Code For OCLf Goes Here */
      foreach(OCL.Absyn.OCLPackage x in oclf_.ListOCLPackage_)
      {
        x.Accept(new OCLPackageVisitor<R,A>(), arg);
      }
      return default(R);
    }
  }
 
  public class OCLPackageVisitor<R,A> : AbstractOCLPackageVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.Pack pack_, A arg)
    {
      /* Code For Pack Goes Here */
      pack_.PackageName_.Accept(new PackageNameVisitor<R,A>(), arg);
      pack_.OCLExpressions_.Accept(new OCLExpressionsVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class PackageNameVisitor<R,A> : AbstractPackageNameVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.PackName packname_, A arg)
    {
      /* Code For PackName Goes Here */
      packname_.PathName_.Accept(new PathNameVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class OCLExpressionsVisitor<R,A> : AbstractOCLExpressionsVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.Constraints constraints_, A arg)
    {
      /* Code For Constraints Goes Here */
      foreach(OCL.Absyn.Constrnt x in constraints_.ListConstrnt_)
      {
        x.Accept(new ConstrntVisitor<R,A>(), arg);
      }
      return default(R);
    }
  }
 
  public class ConstrntVisitor<R,A> : AbstractConstrntVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.Constr constr_, A arg)
    {
      /* Code For Constr Goes Here */
      constr_.ContextDeclaration_.Accept(new ContextDeclarationVisitor<R,A>(), arg);
      foreach(OCL.Absyn.ConstrBody x in constr_.ListConstrBody_)
      {
        x.Accept(new ConstrBodyVisitor<R,A>(), arg);
      }
      return default(R);
    }
  }
 
  public class ConstrBodyVisitor<R,A> : AbstractConstrBodyVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.CBDefNamed cbdefnamed_, A arg)
    {
      /* Code For CBDefNamed Goes Here */
      // cbdefnamed_.Ident_
      foreach(OCL.Absyn.LetExpression x in cbdefnamed_.ListLetExpression_)
      {
        x.Accept(new LetExpressionVisitor<R,A>(), arg);
      }
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.CBDef cbdef_, A arg)
    {
      /* Code For CBDef Goes Here */
      foreach(OCL.Absyn.LetExpression x in cbdef_.ListLetExpression_)
      {
        x.Accept(new LetExpressionVisitor<R,A>(), arg);
      }
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.CBNamed cbnamed_, A arg)
    {
      /* Code For CBNamed Goes Here */
      cbnamed_.Stereotype_.Accept(new StereotypeVisitor<R,A>(), arg);
      // cbnamed_.Ident_
      cbnamed_.OCLExpression_.Accept(new OCLExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.CB cb_, A arg)
    {
      /* Code For CB Goes Here */
      cb_.Stereotype_.Accept(new StereotypeVisitor<R,A>(), arg);
      cb_.OCLExpression_.Accept(new OCLExpressionVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class ContextDeclarationVisitor<R,A> : AbstractContextDeclarationVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.CDOper cdoper_, A arg)
    {
      /* Code For CDOper Goes Here */
      cdoper_.OperationContext_.Accept(new OperationContextVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.CDClassif cdclassif_, A arg)
    {
      /* Code For CDClassif Goes Here */
      cdclassif_.ClassifierContext_.Accept(new ClassifierContextVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class ClassifierContextVisitor<R,A> : AbstractClassifierContextVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.CCType cctype_, A arg)
    {
      /* Code For CCType Goes Here */
      // cctype_.Ident_1
      // cctype_.Ident_2
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.CC cc_, A arg)
    {
      /* Code For CC Goes Here */
      // cc_.Ident_
      return default(R);
    }
  }
 
  public class OperationContextVisitor<R,A> : AbstractOperationContextVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.OpC opc_, A arg)
    {
      /* Code For OpC Goes Here */
      // opc_.Ident_
      opc_.OperationName_.Accept(new OperationNameVisitor<R,A>(), arg);
      foreach(OCL.Absyn.FormalParameter x in opc_.ListFormalParameter_)
      {
        x.Accept(new FormalParameterVisitor<R,A>(), arg);
      }
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.OpCRT opcrt_, A arg)
    {
      /* Code For OpCRT Goes Here */
      // opcrt_.Ident_
      opcrt_.OperationName_.Accept(new OperationNameVisitor<R,A>(), arg);
      foreach(OCL.Absyn.FormalParameter x in opcrt_.ListFormalParameter_)
      {
        x.Accept(new FormalParameterVisitor<R,A>(), arg);
      }
      opcrt_.ReturnType_.Accept(new ReturnTypeVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class StereotypeVisitor<R,A> : AbstractStereotypeVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.Pre pre_, A arg)
    {
      /* Code For Pre Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Post post_, A arg)
    {
      /* Code For Post Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Inv inv_, A arg)
    {
      /* Code For Inv Goes Here */
      return default(R);
    }
  }
 
  public class OperationNameVisitor<R,A> : AbstractOperationNameVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.OpName opname_, A arg)
    {
      /* Code For OpName Goes Here */
      // opname_.Ident_
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Eq eq_, A arg)
    {
      /* Code For Eq Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Add add_, A arg)
    {
      /* Code For Add Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Sub sub_, A arg)
    {
      /* Code For Sub Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.LST lst_, A arg)
    {
      /* Code For LST Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.LSTE lste_, A arg)
    {
      /* Code For LSTE Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.GRT grt_, A arg)
    {
      /* Code For GRT Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.GRTE grte_, A arg)
    {
      /* Code For GRTE Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Div div_, A arg)
    {
      /* Code For Div Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Mult mult_, A arg)
    {
      /* Code For Mult Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.NEq neq_, A arg)
    {
      /* Code For NEq Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Impl impl_, A arg)
    {
      /* Code For Impl Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Not not_, A arg)
    {
      /* Code For Not Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Or or_, A arg)
    {
      /* Code For Or Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Xor xor_, A arg)
    {
      /* Code For Xor Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.And and_, A arg)
    {
      /* Code For And Goes Here */
      return default(R);
    }
  }
 
  public class FormalParameterVisitor<R,A> : AbstractFormalParameterVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.FP fp_, A arg)
    {
      /* Code For FP Goes Here */
      // fp_.Ident_
      fp_.TypeSpecifier_.Accept(new TypeSpecifierVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class TypeSpecifierVisitor<R,A> : AbstractTypeSpecifierVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.TSsimple tssimple_, A arg)
    {
      /* Code For TSsimple Goes Here */
      tssimple_.SimpleTypeSpecifier_.Accept(new SimpleTypeSpecifierVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.TScoll tscoll_, A arg)
    {
      /* Code For TScoll Goes Here */
      tscoll_.CollectionType_.Accept(new CollectionTypeVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class CollectionTypeVisitor<R,A> : AbstractCollectionTypeVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.CT ct_, A arg)
    {
      /* Code For CT Goes Here */
      ct_.CollectionKind_.Accept(new CollectionKindVisitor<R,A>(), arg);
      ct_.SimpleTypeSpecifier_.Accept(new SimpleTypeSpecifierVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class ReturnTypeVisitor<R,A> : AbstractReturnTypeVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.RT rt_, A arg)
    {
      /* Code For RT Goes Here */
      rt_.TypeSpecifier_.Accept(new TypeSpecifierVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class OCLExpressionVisitor<R,A> : AbstractOCLExpressionVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.OCLExp oclexp_, A arg)
    {
      /* Code For OCLExp Goes Here */
      oclexp_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.OCLExpLet oclexplet_, A arg)
    {
      /* Code For OCLExpLet Goes Here */
      foreach(OCL.Absyn.LetExpression x in oclexplet_.ListLetExpression_)
      {
        x.Accept(new LetExpressionVisitor<R,A>(), arg);
      }
      oclexplet_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class LetExpressionVisitor<R,A> : AbstractLetExpressionVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.LENoParam lenoparam_, A arg)
    {
      /* Code For LENoParam Goes Here */
      // lenoparam_.Ident_
      lenoparam_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.LENoParamType lenoparamtype_, A arg)
    {
      /* Code For LENoParamType Goes Here */
      // lenoparamtype_.Ident_
      lenoparamtype_.TypeSpecifier_.Accept(new TypeSpecifierVisitor<R,A>(), arg);
      lenoparamtype_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.LE le_, A arg)
    {
      /* Code For LE Goes Here */
      // le_.Ident_
      foreach(OCL.Absyn.FormalParameter x in le_.ListFormalParameter_)
      {
        x.Accept(new FormalParameterVisitor<R,A>(), arg);
      }
      le_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.LEType letype_, A arg)
    {
      /* Code For LEType Goes Here */
      // letype_.Ident_
      foreach(OCL.Absyn.FormalParameter x in letype_.ListFormalParameter_)
      {
        x.Accept(new FormalParameterVisitor<R,A>(), arg);
      }
      letype_.TypeSpecifier_.Accept(new TypeSpecifierVisitor<R,A>(), arg);
      letype_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class IfExpressionVisitor<R,A> : AbstractIfExpressionVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.IfExp ifexp_, A arg)
    {
      /* Code For IfExp Goes Here */
      ifexp_.Expression_1.Accept(new ExpressionVisitor<R,A>(), arg);
      ifexp_.Expression_2.Accept(new ExpressionVisitor<R,A>(), arg);
      ifexp_.Expression_3.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class ExpressionVisitor<R,A> : AbstractExpressionVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.EOpImpl eopimpl_, A arg)
    {
      /* Code For EOpImpl Goes Here */
      eopimpl_.Expression_1.Accept(new ExpressionVisitor<R,A>(), arg);
      eopimpl_.Expression_2.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.EOpLog eoplog_, A arg)
    {
      /* Code For EOpLog Goes Here */
      eoplog_.Expression_1.Accept(new ExpressionVisitor<R,A>(), arg);
      eoplog_.LogicalOperator_.Accept(new LogicalOperatorVisitor<R,A>(), arg);
      eoplog_.Expression_2.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.EOpEq eopeq_, A arg)
    {
      /* Code For EOpEq Goes Here */
      eopeq_.Expression_1.Accept(new ExpressionVisitor<R,A>(), arg);
      eopeq_.EqualityOperator_.Accept(new EqualityOperatorVisitor<R,A>(), arg);
      eopeq_.Expression_2.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.EOpRel eoprel_, A arg)
    {
      /* Code For EOpRel Goes Here */
      eoprel_.Expression_1.Accept(new ExpressionVisitor<R,A>(), arg);
      eoprel_.RelationalOperator_.Accept(new RelationalOperatorVisitor<R,A>(), arg);
      eoprel_.Expression_2.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.EOpAdd eopadd_, A arg)
    {
      /* Code For EOpAdd Goes Here */
      eopadd_.Expression_1.Accept(new ExpressionVisitor<R,A>(), arg);
      eopadd_.AddOperator_.Accept(new AddOperatorVisitor<R,A>(), arg);
      eopadd_.Expression_2.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.EOpMul eopmul_, A arg)
    {
      /* Code For EOpMul Goes Here */
      eopmul_.Expression_1.Accept(new ExpressionVisitor<R,A>(), arg);
      eopmul_.MultiplyOperator_.Accept(new MultiplyOperatorVisitor<R,A>(), arg);
      eopmul_.Expression_2.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.EOpUn eopun_, A arg)
    {
      /* Code For EOpUn Goes Here */
      eopun_.UnaryOperator_.Accept(new UnaryOperatorVisitor<R,A>(), arg);
      eopun_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.EExplPropCall eexplpropcall_, A arg)
    {
      /* Code For EExplPropCall Goes Here */
      eexplpropcall_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      eexplpropcall_.PostfixOperator_.Accept(new PostfixOperatorVisitor<R,A>(), arg);
      eexplpropcall_.PropertyCall_.Accept(new PropertyCallVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.EMessage emessage_, A arg)
    {
      /* Code For EMessage Goes Here */
      emessage_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      emessage_.PathName_.Accept(new PathNameVisitor<R,A>(), arg);
      foreach(OCL.Absyn.MessageArg x in emessage_.ListMessageArg_)
      {
        x.Accept(new MessageArgVisitor<R,A>(), arg);
      }
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.EImplPropCall eimplpropcall_, A arg)
    {
      /* Code For EImplPropCall Goes Here */
      eimplpropcall_.PropertyCall_.Accept(new PropertyCallVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.ELitColl elitcoll_, A arg)
    {
      /* Code For ELitColl Goes Here */
      elitcoll_.LiteralCollection_.Accept(new LiteralCollectionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.ELit elit_, A arg)
    {
      /* Code For ELit Goes Here */
      elit_.OCLLiteral_.Accept(new OCLLiteralVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.EIfExp eifexp_, A arg)
    {
      /* Code For EIfExp Goes Here */
      eifexp_.IfExpression_.Accept(new IfExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.ENull enull_, A arg)
    {
      /* Code For ENull Goes Here */
      return default(R);
    }
  }
 
  public class MessageArgVisitor<R,A> : AbstractMessageArgVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.MAExpr maexpr_, A arg)
    {
      /* Code For MAExpr Goes Here */
      maexpr_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.MAUnspec maunspec_, A arg)
    {
      /* Code For MAUnspec Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.MAUnspecTyped maunspectyped_, A arg)
    {
      /* Code For MAUnspecTyped Goes Here */
      maunspectyped_.TypeSpecifier_.Accept(new TypeSpecifierVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class PropertyCallVisitor<R,A> : AbstractPropertyCallVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.PCall pcall_, A arg)
    {
      /* Code For PCall Goes Here */
      pcall_.PathName_.Accept(new PathNameVisitor<R,A>(), arg);
      pcall_.PossTimeExpression_.Accept(new PossTimeExpressionVisitor<R,A>(), arg);
      pcall_.PossQualifiers_.Accept(new PossQualifiersVisitor<R,A>(), arg);
      pcall_.PossPropCallParam_.Accept(new PossPropCallParamVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class PathNameVisitor<R,A> : AbstractPathNameVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.PathN pathn_, A arg)
    {
      /* Code For PathN Goes Here */
      foreach(OCL.Absyn.PName x in pathn_.ListPName_)
      {
        x.Accept(new PNameVisitor<R,A>(), arg);
      }
      return default(R);
    }
  }
 
  public class PNameVisitor<R,A> : AbstractPNameVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.PN pn_, A arg)
    {
      /* Code For PN Goes Here */
      // pn_.Ident_
      return default(R);
    }
  }
 
  public class PossQualifiersVisitor<R,A> : AbstractPossQualifiersVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.NoQual noqual_, A arg)
    {
      /* Code For NoQual Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Qual qual_, A arg)
    {
      /* Code For Qual Goes Here */
      qual_.Qualifiers_.Accept(new QualifiersVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class QualifiersVisitor<R,A> : AbstractQualifiersVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.Quals quals_, A arg)
    {
      /* Code For Quals Goes Here */
      foreach(OCL.Absyn.Expression x in quals_.ListExpression_)
      {
        x.Accept(new ExpressionVisitor<R,A>(), arg);
      }
      return default(R);
    }
  }
 
  public class PossTimeExpressionVisitor<R,A> : AbstractPossTimeExpressionVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.NoTE note_, A arg)
    {
      /* Code For NoTE Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.AtPre atpre_, A arg)
    {
      /* Code For AtPre Goes Here */
      return default(R);
    }
  }
 
  public class PossPropCallParamVisitor<R,A> : AbstractPossPropCallParamVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.NoPCP nopcp_, A arg)
    {
      /* Code For NoPCP Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.PCPs pcps_, A arg)
    {
      /* Code For PCPs Goes Here */
      pcps_.PropertyCallParameters_.Accept(new PropertyCallParametersVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class DeclaratorVisitor<R,A> : AbstractDeclaratorVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.Decl decl_, A arg)
    {
      /* Code For Decl Goes Here */
      decl_.DeclaratorVarList_.Accept(new DeclaratorVarListVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.DeclAcc declacc_, A arg)
    {
      /* Code For DeclAcc Goes Here */
      declacc_.DeclaratorVarList_.Accept(new DeclaratorVarListVisitor<R,A>(), arg);
      // declacc_.Ident_
      declacc_.TypeSpecifier_.Accept(new TypeSpecifierVisitor<R,A>(), arg);
      declacc_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class DeclaratorVarListVisitor<R,A> : AbstractDeclaratorVarListVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.DVL dvl_, A arg)
    {
      /* Code For DVL Goes Here */
      foreach(string x in dvl_.ListIdent_)
      {
        // x
      }
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.DVLType dvltype_, A arg)
    {
      /* Code For DVLType Goes Here */
      foreach(string x in dvltype_.ListIdent_)
      {
        // x
      }
      dvltype_.SimpleTypeSpecifier_.Accept(new SimpleTypeSpecifierVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class PropertyCallParametersVisitor<R,A> : AbstractPropertyCallParametersVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.PCPDecl pcpdecl_, A arg)
    {
      /* Code For PCPDecl Goes Here */
      pcpdecl_.Declarator_.Accept(new DeclaratorVisitor<R,A>(), arg);
      foreach(OCL.Absyn.Expression x in pcpdecl_.ListExpression_)
      {
        x.Accept(new ExpressionVisitor<R,A>(), arg);
      }
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.PCP pcp_, A arg)
    {
      /* Code For PCP Goes Here */
      foreach(OCL.Absyn.Expression x in pcp_.ListExpression_)
      {
        x.Accept(new ExpressionVisitor<R,A>(), arg);
      }
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.PCPNoDeclNoParam pcpnodeclnoparam_, A arg)
    {
      /* Code For PCPNoDeclNoParam Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.PCPConcrete pcpconcrete_, A arg)
    {
      /* Code For PCPConcrete Goes Here */
      pcpconcrete_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      foreach(OCL.Absyn.PCPHelper x in pcpconcrete_.ListPCPHelper_)
      {
        x.Accept(new PCPHelperVisitor<R,A>(), arg);
      }
      return default(R);
    }
  }
 
  public class PCPHelperVisitor<R,A> : AbstractPCPHelperVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.PCPComma pcpcomma_, A arg)
    {
      /* Code For PCPComma Goes Here */
      pcpcomma_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.PCPColon pcpcolon_, A arg)
    {
      /* Code For PCPColon Goes Here */
      pcpcolon_.SimpleTypeSpecifier_.Accept(new SimpleTypeSpecifierVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.PCPIterate pcpiterate_, A arg)
    {
      /* Code For PCPIterate Goes Here */
      // pcpiterate_.Ident_
      pcpiterate_.TypeSpecifier_.Accept(new TypeSpecifierVisitor<R,A>(), arg);
      pcpiterate_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.PCPBar pcpbar_, A arg)
    {
      /* Code For PCPBar Goes Here */
      pcpbar_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class OCLLiteralVisitor<R,A> : AbstractOCLLiteralVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.LitStr litstr_, A arg)
    {
      /* Code For LitStr Goes Here */
      // litstr_.String_
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.LitNum litnum_, A arg)
    {
      /* Code For LitNum Goes Here */
      litnum_.OCLNumber_.Accept(new OCLNumberVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.LitBoolTrue litbooltrue_, A arg)
    {
      /* Code For LitBoolTrue Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.LitBoolFalse litboolfalse_, A arg)
    {
      /* Code For LitBoolFalse Goes Here */
      return default(R);
    }
  }
 
  public class SimpleTypeSpecifierVisitor<R,A> : AbstractSimpleTypeSpecifierVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.STSpec stspec_, A arg)
    {
      /* Code For STSpec Goes Here */
      stspec_.PathName_.Accept(new PathNameVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class LiteralCollectionVisitor<R,A> : AbstractLiteralCollectionVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.LCollection lcollection_, A arg)
    {
      /* Code For LCollection Goes Here */
      lcollection_.CollectionKind_.Accept(new CollectionKindVisitor<R,A>(), arg);
      foreach(OCL.Absyn.CollectionItem x in lcollection_.ListCollectionItem_)
      {
        x.Accept(new CollectionItemVisitor<R,A>(), arg);
      }
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.LCollectionEmpty lcollectionempty_, A arg)
    {
      /* Code For LCollectionEmpty Goes Here */
      lcollectionempty_.CollectionKind_.Accept(new CollectionKindVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class CollectionItemVisitor<R,A> : AbstractCollectionItemVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.CI ci_, A arg)
    {
      /* Code For CI Goes Here */
      ci_.Expression_.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.CIRange cirange_, A arg)
    {
      /* Code For CIRange Goes Here */
      cirange_.Expression_1.Accept(new ExpressionVisitor<R,A>(), arg);
      cirange_.Expression_2.Accept(new ExpressionVisitor<R,A>(), arg);
      return default(R);
    }
  }
 
  public class OCLNumberVisitor<R,A> : AbstractOCLNumberVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.NumInt numint_, A arg)
    {
      /* Code For NumInt Goes Here */
      // numint_.Integer_
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.NumDouble numdouble_, A arg)
    {
      /* Code For NumDouble Goes Here */
      // numdouble_.Double_
      return default(R);
    }
  }
 
  public class LogicalOperatorVisitor<R,A> : AbstractLogicalOperatorVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.LAnd land_, A arg)
    {
      /* Code For LAnd Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.LOr lor_, A arg)
    {
      /* Code For LOr Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.LXor lxor_, A arg)
    {
      /* Code For LXor Goes Here */
      return default(R);
    }
  }
 
  public class CollectionKindVisitor<R,A> : AbstractCollectionKindVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.Set set_, A arg)
    {
      /* Code For Set Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Bag bag_, A arg)
    {
      /* Code For Bag Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Sequence sequence_, A arg)
    {
      /* Code For Sequence Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.Collection collection_, A arg)
    {
      /* Code For Collection Goes Here */
      return default(R);
    }
  }
 
  public class EqualityOperatorVisitor<R,A> : AbstractEqualityOperatorVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.EEq eeq_, A arg)
    {
      /* Code For EEq Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.ENEq eneq_, A arg)
    {
      /* Code For ENEq Goes Here */
      return default(R);
    }
  }
 
  public class RelationalOperatorVisitor<R,A> : AbstractRelationalOperatorVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.RGT rgt_, A arg)
    {
      /* Code For RGT Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.RGTE rgte_, A arg)
    {
      /* Code For RGTE Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.RLT rlt_, A arg)
    {
      /* Code For RLT Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.RLTE rlte_, A arg)
    {
      /* Code For RLTE Goes Here */
      return default(R);
    }
  }
 
  public class AddOperatorVisitor<R,A> : AbstractAddOperatorVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.AAdd aadd_, A arg)
    {
      /* Code For AAdd Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.ASub asub_, A arg)
    {
      /* Code For ASub Goes Here */
      return default(R);
    }
  }
 
  public class MultiplyOperatorVisitor<R,A> : AbstractMultiplyOperatorVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.MMult mmult_, A arg)
    {
      /* Code For MMult Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.MDiv mdiv_, A arg)
    {
      /* Code For MDiv Goes Here */
      return default(R);
    }
  }
 
  public class UnaryOperatorVisitor<R,A> : AbstractUnaryOperatorVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.UMin umin_, A arg)
    {
      /* Code For UMin Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.UNot unot_, A arg)
    {
      /* Code For UNot Goes Here */
      return default(R);
    }
  }
 
  public class PostfixOperatorVisitor<R,A> : AbstractPostfixOperatorVisitor<R,A>
  {
    public override R Visit(OCL.Absyn.PDot pdot_, A arg)
    {
      /* Code For PDot Goes Here */
      return default(R);
    }
 
    public override R Visit(OCL.Absyn.PArrow parrow_, A arg)
    {
      /* Code For PArrow Goes Here */
      return default(R);
    }
  }
  #endregion
  
  #region Token types

  #endregion
}
