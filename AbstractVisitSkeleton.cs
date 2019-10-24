/*** BNFC-Generated Abstract Visitor Design Pattern Skeleton. ***/
/* This implements the common visitor design pattern.
   Replace the R and A parameters with the desired return
   and context types.*/

namespace OCL.VisitSkeleton
{
  #region Classes
  public abstract class AbstractOCLfileVisitor<R,A> : OCL.Absyn.OCLfile.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.OCLf oclf_, A arg);
  }
 
  public abstract class AbstractOCLPackageVisitor<R,A> : OCL.Absyn.OCLPackage.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.Pack pack_, A arg);
  }
 
  public abstract class AbstractPackageNameVisitor<R,A> : OCL.Absyn.PackageName.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.PackName packname_, A arg);
  }
 
  public abstract class AbstractOCLExpressionsVisitor<R,A> : OCL.Absyn.OCLExpressions.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.Constraints constraints_, A arg);
  }
 
  public abstract class AbstractConstrntVisitor<R,A> : OCL.Absyn.Constrnt.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.Constr constr_, A arg);
  }
 
  public abstract class AbstractConstrBodyVisitor<R,A> : OCL.Absyn.ConstrBody.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.CBDefNamed cbdefnamed_, A arg);
 
    public abstract R Visit(OCL.Absyn.CBDef cbdef_, A arg);
 
    public abstract R Visit(OCL.Absyn.CBNamed cbnamed_, A arg);
 
    public abstract R Visit(OCL.Absyn.CB cb_, A arg);
  }
 
  public abstract class AbstractContextDeclarationVisitor<R,A> : OCL.Absyn.ContextDeclaration.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.CDOper cdoper_, A arg);
 
    public abstract R Visit(OCL.Absyn.CDClassif cdclassif_, A arg);
  }
 
  public abstract class AbstractClassifierContextVisitor<R,A> : OCL.Absyn.ClassifierContext.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.CCType cctype_, A arg);
 
    public abstract R Visit(OCL.Absyn.CC cc_, A arg);
  }
 
  public abstract class AbstractOperationContextVisitor<R,A> : OCL.Absyn.OperationContext.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.OpC opc_, A arg);
 
    public abstract R Visit(OCL.Absyn.OpCRT opcrt_, A arg);
  }
 
  public abstract class AbstractStereotypeVisitor<R,A> : OCL.Absyn.Stereotype.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.Pre pre_, A arg);
 
    public abstract R Visit(OCL.Absyn.Post post_, A arg);
 
    public abstract R Visit(OCL.Absyn.Inv inv_, A arg);
  }
 
  public abstract class AbstractOperationNameVisitor<R,A> : OCL.Absyn.OperationName.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.OpName opname_, A arg);
 
    public abstract R Visit(OCL.Absyn.Eq eq_, A arg);
 
    public abstract R Visit(OCL.Absyn.Add add_, A arg);
 
    public abstract R Visit(OCL.Absyn.Sub sub_, A arg);
 
    public abstract R Visit(OCL.Absyn.LST lst_, A arg);
 
    public abstract R Visit(OCL.Absyn.LSTE lste_, A arg);
 
    public abstract R Visit(OCL.Absyn.GRT grt_, A arg);
 
    public abstract R Visit(OCL.Absyn.GRTE grte_, A arg);
 
    public abstract R Visit(OCL.Absyn.Div div_, A arg);
 
    public abstract R Visit(OCL.Absyn.Mult mult_, A arg);
 
    public abstract R Visit(OCL.Absyn.NEq neq_, A arg);
 
    public abstract R Visit(OCL.Absyn.Impl impl_, A arg);
 
    public abstract R Visit(OCL.Absyn.Not not_, A arg);
 
    public abstract R Visit(OCL.Absyn.Or or_, A arg);
 
    public abstract R Visit(OCL.Absyn.Xor xor_, A arg);
 
    public abstract R Visit(OCL.Absyn.And and_, A arg);
  }
 
  public abstract class AbstractFormalParameterVisitor<R,A> : OCL.Absyn.FormalParameter.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.FP fp_, A arg);
  }
 
  public abstract class AbstractTypeSpecifierVisitor<R,A> : OCL.Absyn.TypeSpecifier.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.TSsimple tssimple_, A arg);
 
    public abstract R Visit(OCL.Absyn.TScoll tscoll_, A arg);
  }
 
  public abstract class AbstractCollectionTypeVisitor<R,A> : OCL.Absyn.CollectionType.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.CT ct_, A arg);
  }
 
  public abstract class AbstractReturnTypeVisitor<R,A> : OCL.Absyn.ReturnType.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.RT rt_, A arg);
  }
 
  public abstract class AbstractOCLExpressionVisitor<R,A> : OCL.Absyn.OCLExpression.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.OCLExp oclexp_, A arg);
 
    public abstract R Visit(OCL.Absyn.OCLExpLet oclexplet_, A arg);
  }
 
  public abstract class AbstractLetExpressionVisitor<R,A> : OCL.Absyn.LetExpression.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.LENoParam lenoparam_, A arg);
 
    public abstract R Visit(OCL.Absyn.LENoParamType lenoparamtype_, A arg);
 
    public abstract R Visit(OCL.Absyn.LE le_, A arg);
 
    public abstract R Visit(OCL.Absyn.LEType letype_, A arg);
  }
 
  public abstract class AbstractIfExpressionVisitor<R,A> : OCL.Absyn.IfExpression.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.IfExp ifexp_, A arg);
  }
 
  public abstract class AbstractExpressionVisitor<R,A> : OCL.Absyn.Expression.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.EOpImpl eopimpl_, A arg);
 
    public abstract R Visit(OCL.Absyn.EOpLog eoplog_, A arg);
 
    public abstract R Visit(OCL.Absyn.EOpEq eopeq_, A arg);
 
    public abstract R Visit(OCL.Absyn.EOpRel eoprel_, A arg);
 
    public abstract R Visit(OCL.Absyn.EOpAdd eopadd_, A arg);
 
    public abstract R Visit(OCL.Absyn.EOpMul eopmul_, A arg);
 
    public abstract R Visit(OCL.Absyn.EOpUn eopun_, A arg);
 
    public abstract R Visit(OCL.Absyn.EExplPropCall eexplpropcall_, A arg);
 
    public abstract R Visit(OCL.Absyn.EMessage emessage_, A arg);
 
    public abstract R Visit(OCL.Absyn.EImplPropCall eimplpropcall_, A arg);
 
    public abstract R Visit(OCL.Absyn.ELitColl elitcoll_, A arg);
 
    public abstract R Visit(OCL.Absyn.ELit elit_, A arg);
 
    public abstract R Visit(OCL.Absyn.EIfExp eifexp_, A arg);
 
    public abstract R Visit(OCL.Absyn.ENull enull_, A arg);
  }
 
  public abstract class AbstractMessageArgVisitor<R,A> : OCL.Absyn.MessageArg.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.MAExpr maexpr_, A arg);
 
    public abstract R Visit(OCL.Absyn.MAUnspec maunspec_, A arg);
 
    public abstract R Visit(OCL.Absyn.MAUnspecTyped maunspectyped_, A arg);
  }
 
  public abstract class AbstractPropertyCallVisitor<R,A> : OCL.Absyn.PropertyCall.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.PCall pcall_, A arg);
  }
 
  public abstract class AbstractPathNameVisitor<R,A> : OCL.Absyn.PathName.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.PathN pathn_, A arg);
  }
 
  public abstract class AbstractPNameVisitor<R,A> : OCL.Absyn.PName.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.PN pn_, A arg);
  }
 
  public abstract class AbstractPossQualifiersVisitor<R,A> : OCL.Absyn.PossQualifiers.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.NoQual noqual_, A arg);
 
    public abstract R Visit(OCL.Absyn.Qual qual_, A arg);
  }
 
  public abstract class AbstractQualifiersVisitor<R,A> : OCL.Absyn.Qualifiers.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.Quals quals_, A arg);
  }
 
  public abstract class AbstractPossTimeExpressionVisitor<R,A> : OCL.Absyn.PossTimeExpression.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.NoTE note_, A arg);
 
    public abstract R Visit(OCL.Absyn.AtPre atpre_, A arg);
  }
 
  public abstract class AbstractPossPropCallParamVisitor<R,A> : OCL.Absyn.PossPropCallParam.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.NoPCP nopcp_, A arg);
 
    public abstract R Visit(OCL.Absyn.PCPs pcps_, A arg);
  }
 
  public abstract class AbstractDeclaratorVisitor<R,A> : OCL.Absyn.Declarator.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.Decl decl_, A arg);
 
    public abstract R Visit(OCL.Absyn.DeclAcc declacc_, A arg);
  }
 
  public abstract class AbstractDeclaratorVarListVisitor<R,A> : OCL.Absyn.DeclaratorVarList.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.DVL dvl_, A arg);
 
    public abstract R Visit(OCL.Absyn.DVLType dvltype_, A arg);
  }
 
  public abstract class AbstractPropertyCallParametersVisitor<R,A> : OCL.Absyn.PropertyCallParameters.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.PCPDecl pcpdecl_, A arg);
 
    public abstract R Visit(OCL.Absyn.PCP pcp_, A arg);
 
    public abstract R Visit(OCL.Absyn.PCPNoDeclNoParam pcpnodeclnoparam_, A arg);
 
    public abstract R Visit(OCL.Absyn.PCPConcrete pcpconcrete_, A arg);
  }
 
  public abstract class AbstractPCPHelperVisitor<R,A> : OCL.Absyn.PCPHelper.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.PCPComma pcpcomma_, A arg);
 
    public abstract R Visit(OCL.Absyn.PCPColon pcpcolon_, A arg);
 
    public abstract R Visit(OCL.Absyn.PCPIterate pcpiterate_, A arg);
 
    public abstract R Visit(OCL.Absyn.PCPBar pcpbar_, A arg);
  }
 
  public abstract class AbstractOCLLiteralVisitor<R,A> : OCL.Absyn.OCLLiteral.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.LitStr litstr_, A arg);
 
    public abstract R Visit(OCL.Absyn.LitNum litnum_, A arg);
 
    public abstract R Visit(OCL.Absyn.LitBoolTrue litbooltrue_, A arg);
 
    public abstract R Visit(OCL.Absyn.LitBoolFalse litboolfalse_, A arg);
  }
 
  public abstract class AbstractSimpleTypeSpecifierVisitor<R,A> : OCL.Absyn.SimpleTypeSpecifier.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.STSpec stspec_, A arg);
  }
 
  public abstract class AbstractLiteralCollectionVisitor<R,A> : OCL.Absyn.LiteralCollection.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.LCollection lcollection_, A arg);
 
    public abstract R Visit(OCL.Absyn.LCollectionEmpty lcollectionempty_, A arg);
  }
 
  public abstract class AbstractCollectionItemVisitor<R,A> : OCL.Absyn.CollectionItem.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.CI ci_, A arg);
 
    public abstract R Visit(OCL.Absyn.CIRange cirange_, A arg);
  }
 
  public abstract class AbstractOCLNumberVisitor<R,A> : OCL.Absyn.OCLNumber.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.NumInt numint_, A arg);
 
    public abstract R Visit(OCL.Absyn.NumDouble numdouble_, A arg);
  }
 
  public abstract class AbstractLogicalOperatorVisitor<R,A> : OCL.Absyn.LogicalOperator.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.LAnd land_, A arg);
 
    public abstract R Visit(OCL.Absyn.LOr lor_, A arg);
 
    public abstract R Visit(OCL.Absyn.LXor lxor_, A arg);
  }
 
  public abstract class AbstractCollectionKindVisitor<R,A> : OCL.Absyn.CollectionKind.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.Set set_, A arg);
 
    public abstract R Visit(OCL.Absyn.Bag bag_, A arg);
 
    public abstract R Visit(OCL.Absyn.Sequence sequence_, A arg);
 
    public abstract R Visit(OCL.Absyn.Collection collection_, A arg);
  }
 
  public abstract class AbstractEqualityOperatorVisitor<R,A> : OCL.Absyn.EqualityOperator.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.EEq eeq_, A arg);
 
    public abstract R Visit(OCL.Absyn.ENEq eneq_, A arg);
  }
 
  public abstract class AbstractRelationalOperatorVisitor<R,A> : OCL.Absyn.RelationalOperator.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.RGT rgt_, A arg);
 
    public abstract R Visit(OCL.Absyn.RGTE rgte_, A arg);
 
    public abstract R Visit(OCL.Absyn.RLT rlt_, A arg);
 
    public abstract R Visit(OCL.Absyn.RLTE rlte_, A arg);
  }
 
  public abstract class AbstractAddOperatorVisitor<R,A> : OCL.Absyn.AddOperator.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.AAdd aadd_, A arg);
 
    public abstract R Visit(OCL.Absyn.ASub asub_, A arg);
  }
 
  public abstract class AbstractMultiplyOperatorVisitor<R,A> : OCL.Absyn.MultiplyOperator.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.MMult mmult_, A arg);
 
    public abstract R Visit(OCL.Absyn.MDiv mdiv_, A arg);
  }
 
  public abstract class AbstractUnaryOperatorVisitor<R,A> : OCL.Absyn.UnaryOperator.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.UMin umin_, A arg);
 
    public abstract R Visit(OCL.Absyn.UNot unot_, A arg);
  }
 
  public abstract class AbstractPostfixOperatorVisitor<R,A> : OCL.Absyn.PostfixOperator.Visitor<R,A>
  {
    public abstract R Visit(OCL.Absyn.PDot pdot_, A arg);
 
    public abstract R Visit(OCL.Absyn.PArrow parrow_, A arg);
  }
  #endregion
  
  #region Token types

  #endregion
}
