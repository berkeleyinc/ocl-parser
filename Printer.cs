/*** BNFC-Generated Pretty Printer and Abstract Syntax Viewer ***/
 
using System;
using System.Text; // for StringBuilder
using OCL.Absyn;
 
namespace OCL
{
  #region Pretty-printer class
  public class PrettyPrinter
  {
    #region Misc rendering functions
    // You may wish to change these:
    private const int BUFFER_INITIAL_CAPACITY = 2000;
    private const int INDENT_WIDTH = 2;
    private const string LEFT_PARENTHESIS = "(";
    private const string RIGHT_PARENTHESIS = ")";
    private static System.Globalization.NumberFormatInfo InvariantFormatInfo = System.Globalization.NumberFormatInfo.InvariantInfo;
    
    private static int _n_ = 0;
    private static StringBuilder buffer = new StringBuilder(BUFFER_INITIAL_CAPACITY);
    
    //You may wish to change render
    private static void Render(String s)
    {
      if(s == "(")
      {
        buffer.Append("\n");
        Indent();
        buffer.Append(s);
        _n_ = _n_ + INDENT_WIDTH;
        //buffer.Append("\n");
        //Indent();
      }
      else if(s == "a-(" || s == "[")
        buffer.Append(s);
      else if(s == "a-a)" || s == "]")
      {
        Backup();
        buffer.Append(s);
        buffer.Append(" ");
      }
      else if(s == ")")
      {
        int t;
        _n_ = _n_ - INDENT_WIDTH;
        for(t=0; t<INDENT_WIDTH; t++) {
          Backup();
        }
        buffer.Append(s);
        buffer.Append("\n");
        Indent();
      }
      else if(s == ",")
      {
        Backup();
        buffer.Append(s);
        buffer.Append(" ");
      }
      else if(s == ";")
      {
        Backup();
        buffer.Append(s);
        buffer.Append("\n");
        Indent();
      }
      else if(s == "") return;
      else
      {
        // Make sure escaped characters are printed properly!
        if(s.StartsWith("\"") && s.EndsWith("\""))
        {
          buffer.Append('"');
          StringBuilder sb = new StringBuilder(s);
          // Remove enclosing citation marks
          sb.Remove(0,1);
          sb.Remove(sb.Length-1,1);
          // Note: we have to replace backslashes first! (otherwise it will "double-escape" the other escapes)
          sb.Replace("\\", "\\\\");
          sb.Replace("\n", "\\n");
          sb.Replace("\t", "\\t");
          sb.Replace("\"", "\\\"");
          buffer.Append(sb.ToString());
          buffer.Append('"');
        }
        else
        {
          buffer.Append(s);
        }
        buffer.Append(" ");
      }
    }
    
    private static void PrintInternal(int n, int _i_)
    {
      buffer.Append(n.ToString(InvariantFormatInfo));
      buffer.Append(' ');
    }
    
    private static void PrintInternal(double d, int _i_)
    {
      buffer.Append(d.ToString(InvariantFormatInfo));
      buffer.Append(' ');
    }
    
    private static void PrintInternal(string s, int _i_)
    {
      Render(s);
    }
    
    private static void PrintInternal(char c, int _i_)
    {
      PrintQuoted(c);
    }
    
    
    private static void ShowInternal(int n)
    {
      Render(n.ToString(InvariantFormatInfo));
    }
    
    private static void ShowInternal(double d)
    {
      Render(d.ToString(InvariantFormatInfo));
    }
    
    private static void ShowInternal(char c)
    {
      PrintQuoted(c);
    }
    
    private static void ShowInternal(string s)
    {
      PrintQuoted(s);
    }
    
    
    private static void PrintQuoted(string s)
    {
      Render("\"" + s + "\"");
    }
    
    private static void PrintQuoted(char c)
    {
      // Makes sure the character is escaped properly before printing it.
      string str = c.ToString();
      if(c == '\n') str = "\\n";
      if(c == '\t') str = "\\t";
      Render("'" + str + "'");
    }
    
    private static void Indent()
    {
      int n = _n_;
      while (n > 0)
      {
        buffer.Append(' ');
        n--;
      }
    }
    
    private static void Backup()
    {
      if(buffer[buffer.Length - 1] == ' ')
      {
        buffer.Length = buffer.Length - 1;
      }
    }
    
    private static void Trim()
    {
      while(buffer.Length > 0 && buffer[0] == ' ')
        buffer.Remove(0, 1); 
      while(buffer.Length > 0 && buffer[buffer.Length-1] == ' ')
        buffer.Remove(buffer.Length-1, 1);
    }
    
    private static string GetAndReset()
    {
      Trim();
      string strReturn = buffer.ToString();
      Reset();
      return strReturn;
    }
    
    private static void Reset()
    {
      buffer.Remove(0, buffer.Length);
    }
    #endregion
    
    #region Print Entry Points
    public static string Print(OCL.Absyn.OCLfile cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ListOCLPackage cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.OCLPackage cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.PackageName cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.OCLExpressions cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ListConstrnt cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.Constrnt cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ListConstrBody cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ConstrBody cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ContextDeclaration cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ClassifierContext cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.OperationContext cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.Stereotype cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.OperationName cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ListFormalParameter cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.FormalParameter cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.TypeSpecifier cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.CollectionType cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ReturnType cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.OCLExpression cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.LetExpression cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ListLetExpression cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.IfExpression cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.Expression cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.MessageArg cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ListMessageArg cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.PropertyCall cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.PathName cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.PName cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ListPName cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.PossQualifiers cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.Qualifiers cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.PossTimeExpression cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.PossPropCallParam cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.Declarator cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.DeclaratorVarList cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ListIdent cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.PropertyCallParameters cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ListExpression cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.PCPHelper cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ListPCPHelper cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.OCLLiteral cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.SimpleTypeSpecifier cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.LiteralCollection cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.ListCollectionItem cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.CollectionItem cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.OCLNumber cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.LogicalOperator cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.CollectionKind cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.EqualityOperator cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.RelationalOperator cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.AddOperator cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.MultiplyOperator cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.UnaryOperator cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
 
    public static string Print(OCL.Absyn.PostfixOperator cat)
    {
      PrintInternal(cat, 0);
      return GetAndReset();
    }
    #endregion
    
    #region Show Entry Points
    public static String Show(OCL.Absyn.OCLfile cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ListOCLPackage cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.OCLPackage cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.PackageName cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.OCLExpressions cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ListConstrnt cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.Constrnt cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ListConstrBody cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ConstrBody cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ContextDeclaration cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ClassifierContext cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.OperationContext cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.Stereotype cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.OperationName cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ListFormalParameter cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.FormalParameter cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.TypeSpecifier cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.CollectionType cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ReturnType cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.OCLExpression cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.LetExpression cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ListLetExpression cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.IfExpression cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.Expression cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.MessageArg cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ListMessageArg cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.PropertyCall cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.PathName cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.PName cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ListPName cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.PossQualifiers cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.Qualifiers cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.PossTimeExpression cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.PossPropCallParam cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.Declarator cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.DeclaratorVarList cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ListIdent cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.PropertyCallParameters cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ListExpression cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.PCPHelper cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ListPCPHelper cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.OCLLiteral cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.SimpleTypeSpecifier cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.LiteralCollection cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.ListCollectionItem cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.CollectionItem cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.OCLNumber cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.LogicalOperator cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.CollectionKind cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.EqualityOperator cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.RelationalOperator cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.AddOperator cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.MultiplyOperator cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.UnaryOperator cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
 
    public static String Show(OCL.Absyn.PostfixOperator cat)
    {
      ShowInternal(cat);
      return GetAndReset();
    }
    #endregion
    
    #region (Internal) Print Methods
    private static void PrintInternal(OCL.Absyn.OCLfile p, int _i_)
    {
      if(p is OCL.Absyn.OCLf)
      {
        OCL.Absyn.OCLf _oclf = (OCL.Absyn.OCLf)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_oclf.ListOCLPackage_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ListOCLPackage p, int _i_)
    {
      for(int i=0; i < p.Count; i++)
      {
        PrintInternal(p[i], 0);
        if(i < p.Count - 1)
        {
          Render("");
        }
        else
        {
          Render("");
        }
      }
    }
 
    private static void PrintInternal(OCL.Absyn.OCLPackage p, int _i_)
    {
      if(p is OCL.Absyn.Pack)
      {
        OCL.Absyn.Pack _pack = (OCL.Absyn.Pack)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("package");
        PrintInternal(_pack.PackageName_, 0);
        PrintInternal(_pack.OCLExpressions_, 0);
        Render("endpackage");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.PackageName p, int _i_)
    {
      if(p is OCL.Absyn.PackName)
      {
        OCL.Absyn.PackName _packname = (OCL.Absyn.PackName)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_packname.PathName_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.OCLExpressions p, int _i_)
    {
      if(p is OCL.Absyn.Constraints)
      {
        OCL.Absyn.Constraints _constraints = (OCL.Absyn.Constraints)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_constraints.ListConstrnt_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ListConstrnt p, int _i_)
    {
      for(int i=0; i < p.Count; i++)
      {
        PrintInternal(p[i], 0);
        if(i < p.Count - 1)
        {
          Render("");
        }
        else
        {
          Render("");
        }
      }
    }
 
    private static void PrintInternal(OCL.Absyn.Constrnt p, int _i_)
    {
      if(p is OCL.Absyn.Constr)
      {
        OCL.Absyn.Constr _constr = (OCL.Absyn.Constr)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_constr.ContextDeclaration_, 0);
        PrintInternal(_constr.ListConstrBody_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ListConstrBody p, int _i_)
    {
      for(int i=0; i < p.Count; i++)
      {
        PrintInternal(p[i], 0);
        if(i < p.Count - 1)
        {
          Render("");
        }
        else
        {
          Render("");
        }
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ConstrBody p, int _i_)
    {
      if(p is OCL.Absyn.CBDefNamed)
      {
        OCL.Absyn.CBDefNamed _cbdefnamed = (OCL.Absyn.CBDefNamed)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("def");
        PrintInternal(_cbdefnamed.Ident_, 0);
        Render(":");
        PrintInternal(_cbdefnamed.ListLetExpression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.CBDef)
      {
        OCL.Absyn.CBDef _cbdef = (OCL.Absyn.CBDef)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("def");
        Render(":");
        PrintInternal(_cbdef.ListLetExpression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.CBNamed)
      {
        OCL.Absyn.CBNamed _cbnamed = (OCL.Absyn.CBNamed)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_cbnamed.Stereotype_, 0);
        PrintInternal(_cbnamed.Ident_, 0);
        Render(":");
        PrintInternal(_cbnamed.OCLExpression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.CB)
      {
        OCL.Absyn.CB _cb = (OCL.Absyn.CB)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_cb.Stereotype_, 0);
        Render(":");
        PrintInternal(_cb.OCLExpression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ContextDeclaration p, int _i_)
    {
      if(p is OCL.Absyn.CDOper)
      {
        OCL.Absyn.CDOper _cdoper = (OCL.Absyn.CDOper)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("context");
        PrintInternal(_cdoper.OperationContext_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.CDClassif)
      {
        OCL.Absyn.CDClassif _cdclassif = (OCL.Absyn.CDClassif)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("context");
        PrintInternal(_cdclassif.ClassifierContext_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ClassifierContext p, int _i_)
    {
      if(p is OCL.Absyn.CCType)
      {
        OCL.Absyn.CCType _cctype = (OCL.Absyn.CCType)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_cctype.Ident_1, 0);
        Render(":");
        PrintInternal(_cctype.Ident_2, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.CC)
      {
        OCL.Absyn.CC _cc = (OCL.Absyn.CC)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_cc.Ident_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.OperationContext p, int _i_)
    {
      if(p is OCL.Absyn.OpC)
      {
        OCL.Absyn.OpC _opc = (OCL.Absyn.OpC)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_opc.Ident_, 0);
        Render("::");
        PrintInternal(_opc.OperationName_, 0);
        Render("(");
        PrintInternal(_opc.ListFormalParameter_, 0);
        Render(")");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.OpCRT)
      {
        OCL.Absyn.OpCRT _opcrt = (OCL.Absyn.OpCRT)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_opcrt.Ident_, 0);
        Render("::");
        PrintInternal(_opcrt.OperationName_, 0);
        Render("(");
        PrintInternal(_opcrt.ListFormalParameter_, 0);
        Render(")");
        Render(":");
        PrintInternal(_opcrt.ReturnType_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.Stereotype p, int _i_)
    {
      if(p is OCL.Absyn.Pre)
      {
        OCL.Absyn.Pre _pre = (OCL.Absyn.Pre)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("pre");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Post)
      {
        OCL.Absyn.Post _post = (OCL.Absyn.Post)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("post");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Inv)
      {
        OCL.Absyn.Inv _inv = (OCL.Absyn.Inv)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("inv");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.OperationName p, int _i_)
    {
      if(p is OCL.Absyn.OpName)
      {
        OCL.Absyn.OpName _opname = (OCL.Absyn.OpName)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_opname.Ident_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Eq)
      {
        OCL.Absyn.Eq _eq = (OCL.Absyn.Eq)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("=");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Add)
      {
        OCL.Absyn.Add _add = (OCL.Absyn.Add)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("+");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Sub)
      {
        OCL.Absyn.Sub _sub = (OCL.Absyn.Sub)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("-");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.LST)
      {
        OCL.Absyn.LST _lst = (OCL.Absyn.LST)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("<");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.LSTE)
      {
        OCL.Absyn.LSTE _lste = (OCL.Absyn.LSTE)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("<=");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.GRT)
      {
        OCL.Absyn.GRT _grt = (OCL.Absyn.GRT)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render(">");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.GRTE)
      {
        OCL.Absyn.GRTE _grte = (OCL.Absyn.GRTE)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render(">=");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Div)
      {
        OCL.Absyn.Div _div = (OCL.Absyn.Div)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("/");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Mult)
      {
        OCL.Absyn.Mult _mult = (OCL.Absyn.Mult)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("*");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.NEq)
      {
        OCL.Absyn.NEq _neq = (OCL.Absyn.NEq)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("<>");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Impl)
      {
        OCL.Absyn.Impl _impl = (OCL.Absyn.Impl)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("implies");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Not)
      {
        OCL.Absyn.Not _not = (OCL.Absyn.Not)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("not");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Or)
      {
        OCL.Absyn.Or _or = (OCL.Absyn.Or)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("or");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Xor)
      {
        OCL.Absyn.Xor _xor = (OCL.Absyn.Xor)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("xor");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.And)
      {
        OCL.Absyn.And _and = (OCL.Absyn.And)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("and");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ListFormalParameter p, int _i_)
    {
      for(int i=0; i < p.Count; i++)
      {
        PrintInternal(p[i], 0);
        if(i < p.Count - 1)
        {
          Render(",");
        }
        else
        {
          Render("");
        }
      }
    }
 
    private static void PrintInternal(OCL.Absyn.FormalParameter p, int _i_)
    {
      if(p is OCL.Absyn.FP)
      {
        OCL.Absyn.FP _fp = (OCL.Absyn.FP)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_fp.Ident_, 0);
        Render(":");
        PrintInternal(_fp.TypeSpecifier_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.TypeSpecifier p, int _i_)
    {
      if(p is OCL.Absyn.TSsimple)
      {
        OCL.Absyn.TSsimple _tssimple = (OCL.Absyn.TSsimple)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_tssimple.SimpleTypeSpecifier_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.TScoll)
      {
        OCL.Absyn.TScoll _tscoll = (OCL.Absyn.TScoll)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_tscoll.CollectionType_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.CollectionType p, int _i_)
    {
      if(p is OCL.Absyn.CT)
      {
        OCL.Absyn.CT _ct = (OCL.Absyn.CT)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_ct.CollectionKind_, 0);
        Render("(");
        PrintInternal(_ct.SimpleTypeSpecifier_, 0);
        Render(")");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ReturnType p, int _i_)
    {
      if(p is OCL.Absyn.RT)
      {
        OCL.Absyn.RT _rt = (OCL.Absyn.RT)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_rt.TypeSpecifier_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.OCLExpression p, int _i_)
    {
      if(p is OCL.Absyn.OCLExp)
      {
        OCL.Absyn.OCLExp _oclexp = (OCL.Absyn.OCLExp)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_oclexp.Expression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.OCLExpLet)
      {
        OCL.Absyn.OCLExpLet _oclexplet = (OCL.Absyn.OCLExpLet)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_oclexplet.ListLetExpression_, 0);
        Render("in");
        PrintInternal(_oclexplet.Expression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.LetExpression p, int _i_)
    {
      if(p is OCL.Absyn.LENoParam)
      {
        OCL.Absyn.LENoParam _lenoparam = (OCL.Absyn.LENoParam)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("let");
        PrintInternal(_lenoparam.Ident_, 0);
        Render("=");
        PrintInternal(_lenoparam.Expression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.LENoParamType)
      {
        OCL.Absyn.LENoParamType _lenoparamtype = (OCL.Absyn.LENoParamType)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("let");
        PrintInternal(_lenoparamtype.Ident_, 0);
        Render(":");
        PrintInternal(_lenoparamtype.TypeSpecifier_, 0);
        Render("=");
        PrintInternal(_lenoparamtype.Expression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.LE)
      {
        OCL.Absyn.LE _le = (OCL.Absyn.LE)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("let");
        PrintInternal(_le.Ident_, 0);
        Render("(");
        PrintInternal(_le.ListFormalParameter_, 0);
        Render(")");
        Render("=");
        PrintInternal(_le.Expression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.LEType)
      {
        OCL.Absyn.LEType _letype = (OCL.Absyn.LEType)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("let");
        PrintInternal(_letype.Ident_, 0);
        Render("(");
        PrintInternal(_letype.ListFormalParameter_, 0);
        Render(")");
        Render(":");
        PrintInternal(_letype.TypeSpecifier_, 0);
        Render("=");
        PrintInternal(_letype.Expression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ListLetExpression p, int _i_)
    {
      for(int i=0; i < p.Count; i++)
      {
        PrintInternal(p[i], 0);
        if(i < p.Count - 1)
        {
          Render("");
        }
        else
        {
          Render("");
        }
      }
    }
 
    private static void PrintInternal(OCL.Absyn.IfExpression p, int _i_)
    {
      if(p is OCL.Absyn.IfExp)
      {
        OCL.Absyn.IfExp _ifexp = (OCL.Absyn.IfExp)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("if");
        PrintInternal(_ifexp.Expression_1, 0);
        Render("then");
        PrintInternal(_ifexp.Expression_2, 0);
        Render("else");
        PrintInternal(_ifexp.Expression_3, 0);
        Render("endif");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.Expression p, int _i_)
    {
      if(p is OCL.Absyn.EOpImpl)
      {
        OCL.Absyn.EOpImpl _eopimpl = (OCL.Absyn.EOpImpl)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_eopimpl.Expression_1, 0);
        Render("implies");
        PrintInternal(_eopimpl.Expression_2, 1);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.EOpLog)
      {
        OCL.Absyn.EOpLog _eoplog = (OCL.Absyn.EOpLog)p;
        if(_i_ > 1) Render(LEFT_PARENTHESIS);
        PrintInternal(_eoplog.Expression_1, 1);
        PrintInternal(_eoplog.LogicalOperator_, 0);
        PrintInternal(_eoplog.Expression_2, 2);
        if(_i_ > 1) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.EOpEq)
      {
        OCL.Absyn.EOpEq _eopeq = (OCL.Absyn.EOpEq)p;
        if(_i_ > 2) Render(LEFT_PARENTHESIS);
        PrintInternal(_eopeq.Expression_1, 2);
        PrintInternal(_eopeq.EqualityOperator_, 0);
        PrintInternal(_eopeq.Expression_2, 3);
        if(_i_ > 2) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.EOpRel)
      {
        OCL.Absyn.EOpRel _eoprel = (OCL.Absyn.EOpRel)p;
        if(_i_ > 3) Render(LEFT_PARENTHESIS);
        PrintInternal(_eoprel.Expression_1, 3);
        PrintInternal(_eoprel.RelationalOperator_, 0);
        PrintInternal(_eoprel.Expression_2, 4);
        if(_i_ > 3) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.EOpAdd)
      {
        OCL.Absyn.EOpAdd _eopadd = (OCL.Absyn.EOpAdd)p;
        if(_i_ > 4) Render(LEFT_PARENTHESIS);
        PrintInternal(_eopadd.Expression_1, 4);
        PrintInternal(_eopadd.AddOperator_, 0);
        PrintInternal(_eopadd.Expression_2, 5);
        if(_i_ > 4) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.EOpMul)
      {
        OCL.Absyn.EOpMul _eopmul = (OCL.Absyn.EOpMul)p;
        if(_i_ > 5) Render(LEFT_PARENTHESIS);
        PrintInternal(_eopmul.Expression_1, 5);
        PrintInternal(_eopmul.MultiplyOperator_, 0);
        PrintInternal(_eopmul.Expression_2, 6);
        if(_i_ > 5) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.EOpUn)
      {
        OCL.Absyn.EOpUn _eopun = (OCL.Absyn.EOpUn)p;
        if(_i_ > 6) Render(LEFT_PARENTHESIS);
        PrintInternal(_eopun.UnaryOperator_, 0);
        PrintInternal(_eopun.Expression_, 7);
        if(_i_ > 6) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.EExplPropCall)
      {
        OCL.Absyn.EExplPropCall _eexplpropcall = (OCL.Absyn.EExplPropCall)p;
        if(_i_ > 7) Render(LEFT_PARENTHESIS);
        PrintInternal(_eexplpropcall.Expression_, 7);
        PrintInternal(_eexplpropcall.PostfixOperator_, 0);
        PrintInternal(_eexplpropcall.PropertyCall_, 0);
        if(_i_ > 7) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.EMessage)
      {
        OCL.Absyn.EMessage _emessage = (OCL.Absyn.EMessage)p;
        if(_i_ > 7) Render(LEFT_PARENTHESIS);
        PrintInternal(_emessage.Expression_, 7);
        Render("^");
        PrintInternal(_emessage.PathName_, 0);
        Render("(");
        PrintInternal(_emessage.ListMessageArg_, 0);
        Render(")");
        if(_i_ > 7) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.EImplPropCall)
      {
        OCL.Absyn.EImplPropCall _eimplpropcall = (OCL.Absyn.EImplPropCall)p;
        if(_i_ > 8) Render(LEFT_PARENTHESIS);
        PrintInternal(_eimplpropcall.PropertyCall_, 0);
        if(_i_ > 8) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.ELitColl)
      {
        OCL.Absyn.ELitColl _elitcoll = (OCL.Absyn.ELitColl)p;
        if(_i_ > 8) Render(LEFT_PARENTHESIS);
        PrintInternal(_elitcoll.LiteralCollection_, 0);
        if(_i_ > 8) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.ELit)
      {
        OCL.Absyn.ELit _elit = (OCL.Absyn.ELit)p;
        if(_i_ > 8) Render(LEFT_PARENTHESIS);
        PrintInternal(_elit.OCLLiteral_, 0);
        if(_i_ > 8) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.EIfExp)
      {
        OCL.Absyn.EIfExp _eifexp = (OCL.Absyn.EIfExp)p;
        if(_i_ > 8) Render(LEFT_PARENTHESIS);
        PrintInternal(_eifexp.IfExpression_, 0);
        if(_i_ > 8) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.ENull)
      {
        OCL.Absyn.ENull _enull = (OCL.Absyn.ENull)p;
        if(_i_ > 8) Render(LEFT_PARENTHESIS);
        Render("null");
        if(_i_ > 8) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.MessageArg p, int _i_)
    {
      if(p is OCL.Absyn.MAExpr)
      {
        OCL.Absyn.MAExpr _maexpr = (OCL.Absyn.MAExpr)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_maexpr.Expression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.MAUnspec)
      {
        OCL.Absyn.MAUnspec _maunspec = (OCL.Absyn.MAUnspec)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("?");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.MAUnspecTyped)
      {
        OCL.Absyn.MAUnspecTyped _maunspectyped = (OCL.Absyn.MAUnspecTyped)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("?");
        Render(":");
        PrintInternal(_maunspectyped.TypeSpecifier_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ListMessageArg p, int _i_)
    {
      for(int i=0; i < p.Count; i++)
      {
        PrintInternal(p[i], 0);
        if(i < p.Count - 1)
        {
          Render(",");
        }
        else
        {
          Render("");
        }
      }
    }
 
    private static void PrintInternal(OCL.Absyn.PropertyCall p, int _i_)
    {
      if(p is OCL.Absyn.PCall)
      {
        OCL.Absyn.PCall _pcall = (OCL.Absyn.PCall)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_pcall.PathName_, 0);
        PrintInternal(_pcall.PossTimeExpression_, 0);
        PrintInternal(_pcall.PossQualifiers_, 0);
        PrintInternal(_pcall.PossPropCallParam_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.PathName p, int _i_)
    {
      if(p is OCL.Absyn.PathN)
      {
        OCL.Absyn.PathN _pathn = (OCL.Absyn.PathN)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_pathn.ListPName_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.PName p, int _i_)
    {
      if(p is OCL.Absyn.PN)
      {
        OCL.Absyn.PN _pn = (OCL.Absyn.PN)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_pn.Ident_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ListPName p, int _i_)
    {
      for(int i=0; i < p.Count; i++)
      {
        PrintInternal(p[i], 0);
        if(i < p.Count - 1)
        {
          Render("::");
        }
        else
        {
          Render("");
        }
      }
    }
 
    private static void PrintInternal(OCL.Absyn.PossQualifiers p, int _i_)
    {
      if(p is OCL.Absyn.NoQual)
      {
        OCL.Absyn.NoQual _noqual = (OCL.Absyn.NoQual)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Qual)
      {
        OCL.Absyn.Qual _qual = (OCL.Absyn.Qual)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_qual.Qualifiers_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.Qualifiers p, int _i_)
    {
      if(p is OCL.Absyn.Quals)
      {
        OCL.Absyn.Quals _quals = (OCL.Absyn.Quals)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("[");
        PrintInternal(_quals.ListExpression_, 0);
        Render("]");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.PossTimeExpression p, int _i_)
    {
      if(p is OCL.Absyn.NoTE)
      {
        OCL.Absyn.NoTE _note = (OCL.Absyn.NoTE)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.AtPre)
      {
        OCL.Absyn.AtPre _atpre = (OCL.Absyn.AtPre)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("@");
        Render("pre");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.PossPropCallParam p, int _i_)
    {
      if(p is OCL.Absyn.NoPCP)
      {
        OCL.Absyn.NoPCP _nopcp = (OCL.Absyn.NoPCP)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.PCPs)
      {
        OCL.Absyn.PCPs _pcps = (OCL.Absyn.PCPs)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_pcps.PropertyCallParameters_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.Declarator p, int _i_)
    {
      if(p is OCL.Absyn.Decl)
      {
        OCL.Absyn.Decl _decl = (OCL.Absyn.Decl)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_decl.DeclaratorVarList_, 0);
        Render("|");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.DeclAcc)
      {
        OCL.Absyn.DeclAcc _declacc = (OCL.Absyn.DeclAcc)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_declacc.DeclaratorVarList_, 0);
        Render(";");
        PrintInternal(_declacc.Ident_, 0);
        Render(":");
        PrintInternal(_declacc.TypeSpecifier_, 0);
        Render("=");
        PrintInternal(_declacc.Expression_, 0);
        Render("|");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.DeclaratorVarList p, int _i_)
    {
      if(p is OCL.Absyn.DVL)
      {
        OCL.Absyn.DVL _dvl = (OCL.Absyn.DVL)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_dvl.ListIdent_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.DVLType)
      {
        OCL.Absyn.DVLType _dvltype = (OCL.Absyn.DVLType)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_dvltype.ListIdent_, 0);
        Render(":");
        PrintInternal(_dvltype.SimpleTypeSpecifier_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ListIdent p, int _i_)
    {
      for(int i=0; i < p.Count; i++)
      {
        PrintInternal(p[i], 0);
        if(i < p.Count - 1)
        {
          Render(",");
        }
        else
        {
          Render("");
        }
      }
    }
 
    private static void PrintInternal(OCL.Absyn.PropertyCallParameters p, int _i_)
    {
      if(p is OCL.Absyn.PCPDecl)
      {
        OCL.Absyn.PCPDecl _pcpdecl = (OCL.Absyn.PCPDecl)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("(");
        PrintInternal(_pcpdecl.Declarator_, 0);
        PrintInternal(_pcpdecl.ListExpression_, 0);
        Render(")");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.PCP)
      {
        OCL.Absyn.PCP _pcp = (OCL.Absyn.PCP)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("(");
        PrintInternal(_pcp.ListExpression_, 0);
        Render(")");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.PCPNoDeclNoParam)
      {
        OCL.Absyn.PCPNoDeclNoParam _pcpnodeclnoparam = (OCL.Absyn.PCPNoDeclNoParam)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("(");
        Render(")");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.PCPConcrete)
      {
        OCL.Absyn.PCPConcrete _pcpconcrete = (OCL.Absyn.PCPConcrete)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("(");
        PrintInternal(_pcpconcrete.Expression_, 0);
        PrintInternal(_pcpconcrete.ListPCPHelper_, 0);
        Render(")");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ListExpression p, int _i_)
    {
      for(int i=0; i < p.Count; i++)
      {
        PrintInternal(p[i], 0);
        if(i < p.Count - 1)
        {
          Render(",");
        }
        else
        {
          Render("");
        }
      }
    }
 
    private static void PrintInternal(OCL.Absyn.PCPHelper p, int _i_)
    {
      if(p is OCL.Absyn.PCPComma)
      {
        OCL.Absyn.PCPComma _pcpcomma = (OCL.Absyn.PCPComma)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render(",");
        PrintInternal(_pcpcomma.Expression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.PCPColon)
      {
        OCL.Absyn.PCPColon _pcpcolon = (OCL.Absyn.PCPColon)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render(":");
        PrintInternal(_pcpcolon.SimpleTypeSpecifier_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.PCPIterate)
      {
        OCL.Absyn.PCPIterate _pcpiterate = (OCL.Absyn.PCPIterate)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render(";");
        PrintInternal(_pcpiterate.Ident_, 0);
        Render(":");
        PrintInternal(_pcpiterate.TypeSpecifier_, 0);
        Render("=");
        PrintInternal(_pcpiterate.Expression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.PCPBar)
      {
        OCL.Absyn.PCPBar _pcpbar = (OCL.Absyn.PCPBar)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("|");
        PrintInternal(_pcpbar.Expression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ListPCPHelper p, int _i_)
    {
      for(int i=0; i < p.Count; i++)
      {
        PrintInternal(p[i], 0);
        if(i < p.Count - 1)
        {
          Render("");
        }
        else
        {
          Render("");
        }
      }
    }
 
    private static void PrintInternal(OCL.Absyn.OCLLiteral p, int _i_)
    {
      if(p is OCL.Absyn.LitStr)
      {
        OCL.Absyn.LitStr _litstr = (OCL.Absyn.LitStr)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_litstr.String_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.LitNum)
      {
        OCL.Absyn.LitNum _litnum = (OCL.Absyn.LitNum)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_litnum.OCLNumber_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.LitBoolTrue)
      {
        OCL.Absyn.LitBoolTrue _litbooltrue = (OCL.Absyn.LitBoolTrue)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("true");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.LitBoolFalse)
      {
        OCL.Absyn.LitBoolFalse _litboolfalse = (OCL.Absyn.LitBoolFalse)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("false");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.SimpleTypeSpecifier p, int _i_)
    {
      if(p is OCL.Absyn.STSpec)
      {
        OCL.Absyn.STSpec _stspec = (OCL.Absyn.STSpec)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_stspec.PathName_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.LiteralCollection p, int _i_)
    {
      if(p is OCL.Absyn.LCollection)
      {
        OCL.Absyn.LCollection _lcollection = (OCL.Absyn.LCollection)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_lcollection.CollectionKind_, 0);
        Render("{");
        PrintInternal(_lcollection.ListCollectionItem_, 0);
        Render("}");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.LCollectionEmpty)
      {
        OCL.Absyn.LCollectionEmpty _lcollectionempty = (OCL.Absyn.LCollectionEmpty)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_lcollectionempty.CollectionKind_, 0);
        Render("{");
        Render("}");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.ListCollectionItem p, int _i_)
    {
      for(int i=0; i < p.Count; i++)
      {
        PrintInternal(p[i], 0);
        if(i < p.Count - 1)
        {
          Render(",");
        }
        else
        {
          Render("");
        }
      }
    }
 
    private static void PrintInternal(OCL.Absyn.CollectionItem p, int _i_)
    {
      if(p is OCL.Absyn.CI)
      {
        OCL.Absyn.CI _ci = (OCL.Absyn.CI)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_ci.Expression_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.CIRange)
      {
        OCL.Absyn.CIRange _cirange = (OCL.Absyn.CIRange)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_cirange.Expression_1, 0);
        Render("..");
        PrintInternal(_cirange.Expression_2, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.OCLNumber p, int _i_)
    {
      if(p is OCL.Absyn.NumInt)
      {
        OCL.Absyn.NumInt _numint = (OCL.Absyn.NumInt)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_numint.Integer_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.NumDouble)
      {
        OCL.Absyn.NumDouble _numdouble = (OCL.Absyn.NumDouble)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        PrintInternal(_numdouble.Double_, 0);
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.LogicalOperator p, int _i_)
    {
      if(p is OCL.Absyn.LAnd)
      {
        OCL.Absyn.LAnd _land = (OCL.Absyn.LAnd)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("and");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.LOr)
      {
        OCL.Absyn.LOr _lor = (OCL.Absyn.LOr)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("or");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.LXor)
      {
        OCL.Absyn.LXor _lxor = (OCL.Absyn.LXor)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("xor");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.CollectionKind p, int _i_)
    {
      if(p is OCL.Absyn.Set)
      {
        OCL.Absyn.Set _set = (OCL.Absyn.Set)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("Set");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Bag)
      {
        OCL.Absyn.Bag _bag = (OCL.Absyn.Bag)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("Bag");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Sequence)
      {
        OCL.Absyn.Sequence _sequence = (OCL.Absyn.Sequence)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("Sequence");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.Collection)
      {
        OCL.Absyn.Collection _collection = (OCL.Absyn.Collection)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("Collection");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.EqualityOperator p, int _i_)
    {
      if(p is OCL.Absyn.EEq)
      {
        OCL.Absyn.EEq _eeq = (OCL.Absyn.EEq)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("=");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.ENEq)
      {
        OCL.Absyn.ENEq _eneq = (OCL.Absyn.ENEq)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("<>");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.RelationalOperator p, int _i_)
    {
      if(p is OCL.Absyn.RGT)
      {
        OCL.Absyn.RGT _rgt = (OCL.Absyn.RGT)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render(">");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.RGTE)
      {
        OCL.Absyn.RGTE _rgte = (OCL.Absyn.RGTE)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render(">=");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.RLT)
      {
        OCL.Absyn.RLT _rlt = (OCL.Absyn.RLT)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("<");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.RLTE)
      {
        OCL.Absyn.RLTE _rlte = (OCL.Absyn.RLTE)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("<=");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.AddOperator p, int _i_)
    {
      if(p is OCL.Absyn.AAdd)
      {
        OCL.Absyn.AAdd _aadd = (OCL.Absyn.AAdd)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("+");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.ASub)
      {
        OCL.Absyn.ASub _asub = (OCL.Absyn.ASub)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("-");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.MultiplyOperator p, int _i_)
    {
      if(p is OCL.Absyn.MMult)
      {
        OCL.Absyn.MMult _mmult = (OCL.Absyn.MMult)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("*");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.MDiv)
      {
        OCL.Absyn.MDiv _mdiv = (OCL.Absyn.MDiv)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("/");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.UnaryOperator p, int _i_)
    {
      if(p is OCL.Absyn.UMin)
      {
        OCL.Absyn.UMin _umin = (OCL.Absyn.UMin)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("-");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.UNot)
      {
        OCL.Absyn.UNot _unot = (OCL.Absyn.UNot)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("not");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
 
    private static void PrintInternal(OCL.Absyn.PostfixOperator p, int _i_)
    {
      if(p is OCL.Absyn.PDot)
      {
        OCL.Absyn.PDot _pdot = (OCL.Absyn.PDot)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render(".");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
      else if(p is OCL.Absyn.PArrow)
      {
        OCL.Absyn.PArrow _parrow = (OCL.Absyn.PArrow)p;
        if(_i_ > 0) Render(LEFT_PARENTHESIS);
        Render("->");
        if(_i_ > 0) Render(RIGHT_PARENTHESIS);
      }
    }
    #endregion
    
    #region (Internal) Show Methods
    private static void ShowInternal(OCL.Absyn.OCLfile p)
    {
      if(p is OCL.Absyn.OCLf)
      {
        OCL.Absyn.OCLf _oclf = (OCL.Absyn.OCLf)p;
        Render("(");
        Render("OCLf");
        ShowInternal(_oclf.ListOCLPackage_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ListOCLPackage p)
    {
      for(int i=0; i < p.Count; i++)
      {
        ShowInternal(p[i]);
        if(i < p.Count - 1)
          Render(",");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.OCLPackage p)
    {
      if(p is OCL.Absyn.Pack)
      {
        OCL.Absyn.Pack _pack = (OCL.Absyn.Pack)p;
        Render("(");
        Render("Pack");
        ShowInternal(_pack.PackageName_);
        ShowInternal(_pack.OCLExpressions_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.PackageName p)
    {
      if(p is OCL.Absyn.PackName)
      {
        OCL.Absyn.PackName _packname = (OCL.Absyn.PackName)p;
        Render("(");
        Render("PackName");
        ShowInternal(_packname.PathName_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.OCLExpressions p)
    {
      if(p is OCL.Absyn.Constraints)
      {
        OCL.Absyn.Constraints _constraints = (OCL.Absyn.Constraints)p;
        Render("(");
        Render("Constraints");
        ShowInternal(_constraints.ListConstrnt_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ListConstrnt p)
    {
      for(int i=0; i < p.Count; i++)
      {
        ShowInternal(p[i]);
        if(i < p.Count - 1)
          Render(",");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.Constrnt p)
    {
      if(p is OCL.Absyn.Constr)
      {
        OCL.Absyn.Constr _constr = (OCL.Absyn.Constr)p;
        Render("(");
        Render("Constr");
        ShowInternal(_constr.ContextDeclaration_);
        ShowInternal(_constr.ListConstrBody_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ListConstrBody p)
    {
      for(int i=0; i < p.Count; i++)
      {
        ShowInternal(p[i]);
        if(i < p.Count - 1)
          Render(",");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ConstrBody p)
    {
      if(p is OCL.Absyn.CBDefNamed)
      {
        OCL.Absyn.CBDefNamed _cbdefnamed = (OCL.Absyn.CBDefNamed)p;
        Render("(");
        Render("CBDefNamed");
        ShowInternal(_cbdefnamed.Ident_);
        ShowInternal(_cbdefnamed.ListLetExpression_);
        Render(")");
      }
      if(p is OCL.Absyn.CBDef)
      {
        OCL.Absyn.CBDef _cbdef = (OCL.Absyn.CBDef)p;
        Render("(");
        Render("CBDef");
        ShowInternal(_cbdef.ListLetExpression_);
        Render(")");
      }
      if(p is OCL.Absyn.CBNamed)
      {
        OCL.Absyn.CBNamed _cbnamed = (OCL.Absyn.CBNamed)p;
        Render("(");
        Render("CBNamed");
        ShowInternal(_cbnamed.Stereotype_);
        ShowInternal(_cbnamed.Ident_);
        ShowInternal(_cbnamed.OCLExpression_);
        Render(")");
      }
      if(p is OCL.Absyn.CB)
      {
        OCL.Absyn.CB _cb = (OCL.Absyn.CB)p;
        Render("(");
        Render("CB");
        ShowInternal(_cb.Stereotype_);
        ShowInternal(_cb.OCLExpression_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ContextDeclaration p)
    {
      if(p is OCL.Absyn.CDOper)
      {
        OCL.Absyn.CDOper _cdoper = (OCL.Absyn.CDOper)p;
        Render("(");
        Render("CDOper");
        ShowInternal(_cdoper.OperationContext_);
        Render(")");
      }
      if(p is OCL.Absyn.CDClassif)
      {
        OCL.Absyn.CDClassif _cdclassif = (OCL.Absyn.CDClassif)p;
        Render("(");
        Render("CDClassif");
        ShowInternal(_cdclassif.ClassifierContext_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ClassifierContext p)
    {
      if(p is OCL.Absyn.CCType)
      {
        OCL.Absyn.CCType _cctype = (OCL.Absyn.CCType)p;
        Render("(");
        Render("CCType");
        ShowInternal(_cctype.Ident_1);
        ShowInternal(_cctype.Ident_2);
        Render(")");
      }
      if(p is OCL.Absyn.CC)
      {
        OCL.Absyn.CC _cc = (OCL.Absyn.CC)p;
        Render("(");
        Render("CC");
        ShowInternal(_cc.Ident_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.OperationContext p)
    {
      if(p is OCL.Absyn.OpC)
      {
        OCL.Absyn.OpC _opc = (OCL.Absyn.OpC)p;
        Render("(");
        Render("OpC");
        ShowInternal(_opc.Ident_);
        ShowInternal(_opc.OperationName_);
        ShowInternal(_opc.ListFormalParameter_);
        Render(")");
      }
      if(p is OCL.Absyn.OpCRT)
      {
        OCL.Absyn.OpCRT _opcrt = (OCL.Absyn.OpCRT)p;
        Render("(");
        Render("OpCRT");
        ShowInternal(_opcrt.Ident_);
        ShowInternal(_opcrt.OperationName_);
        ShowInternal(_opcrt.ListFormalParameter_);
        ShowInternal(_opcrt.ReturnType_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.Stereotype p)
    {
      if(p is OCL.Absyn.Pre)
      {
        OCL.Absyn.Pre _pre = (OCL.Absyn.Pre)p;
        Render("Pre");
      }
      if(p is OCL.Absyn.Post)
      {
        OCL.Absyn.Post _post = (OCL.Absyn.Post)p;
        Render("Post");
      }
      if(p is OCL.Absyn.Inv)
      {
        OCL.Absyn.Inv _inv = (OCL.Absyn.Inv)p;
        Render("Inv");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.OperationName p)
    {
      if(p is OCL.Absyn.OpName)
      {
        OCL.Absyn.OpName _opname = (OCL.Absyn.OpName)p;
        Render("(");
        Render("OpName");
        ShowInternal(_opname.Ident_);
        Render(")");
      }
      if(p is OCL.Absyn.Eq)
      {
        OCL.Absyn.Eq _eq = (OCL.Absyn.Eq)p;
        Render("Eq");
      }
      if(p is OCL.Absyn.Add)
      {
        OCL.Absyn.Add _add = (OCL.Absyn.Add)p;
        Render("Add");
      }
      if(p is OCL.Absyn.Sub)
      {
        OCL.Absyn.Sub _sub = (OCL.Absyn.Sub)p;
        Render("Sub");
      }
      if(p is OCL.Absyn.LST)
      {
        OCL.Absyn.LST _lst = (OCL.Absyn.LST)p;
        Render("LST");
      }
      if(p is OCL.Absyn.LSTE)
      {
        OCL.Absyn.LSTE _lste = (OCL.Absyn.LSTE)p;
        Render("LSTE");
      }
      if(p is OCL.Absyn.GRT)
      {
        OCL.Absyn.GRT _grt = (OCL.Absyn.GRT)p;
        Render("GRT");
      }
      if(p is OCL.Absyn.GRTE)
      {
        OCL.Absyn.GRTE _grte = (OCL.Absyn.GRTE)p;
        Render("GRTE");
      }
      if(p is OCL.Absyn.Div)
      {
        OCL.Absyn.Div _div = (OCL.Absyn.Div)p;
        Render("Div");
      }
      if(p is OCL.Absyn.Mult)
      {
        OCL.Absyn.Mult _mult = (OCL.Absyn.Mult)p;
        Render("Mult");
      }
      if(p is OCL.Absyn.NEq)
      {
        OCL.Absyn.NEq _neq = (OCL.Absyn.NEq)p;
        Render("NEq");
      }
      if(p is OCL.Absyn.Impl)
      {
        OCL.Absyn.Impl _impl = (OCL.Absyn.Impl)p;
        Render("Impl");
      }
      if(p is OCL.Absyn.Not)
      {
        OCL.Absyn.Not _not = (OCL.Absyn.Not)p;
        Render("Not");
      }
      if(p is OCL.Absyn.Or)
      {
        OCL.Absyn.Or _or = (OCL.Absyn.Or)p;
        Render("Or");
      }
      if(p is OCL.Absyn.Xor)
      {
        OCL.Absyn.Xor _xor = (OCL.Absyn.Xor)p;
        Render("Xor");
      }
      if(p is OCL.Absyn.And)
      {
        OCL.Absyn.And _and = (OCL.Absyn.And)p;
        Render("And");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ListFormalParameter p)
    {
      for(int i=0; i < p.Count; i++)
      {
        ShowInternal(p[i]);
        if(i < p.Count - 1)
          Render(",");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.FormalParameter p)
    {
      if(p is OCL.Absyn.FP)
      {
        OCL.Absyn.FP _fp = (OCL.Absyn.FP)p;
        Render("(");
        Render("FP");
        ShowInternal(_fp.Ident_);
        ShowInternal(_fp.TypeSpecifier_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.TypeSpecifier p)
    {
      if(p is OCL.Absyn.TSsimple)
      {
        OCL.Absyn.TSsimple _tssimple = (OCL.Absyn.TSsimple)p;
        Render("(");
        Render("TSsimple");
        ShowInternal(_tssimple.SimpleTypeSpecifier_);
        Render(")");
      }
      if(p is OCL.Absyn.TScoll)
      {
        OCL.Absyn.TScoll _tscoll = (OCL.Absyn.TScoll)p;
        Render("(");
        Render("TScoll");
        ShowInternal(_tscoll.CollectionType_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.CollectionType p)
    {
      if(p is OCL.Absyn.CT)
      {
        OCL.Absyn.CT _ct = (OCL.Absyn.CT)p;
        Render("(");
        Render("CT");
        ShowInternal(_ct.CollectionKind_);
        ShowInternal(_ct.SimpleTypeSpecifier_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ReturnType p)
    {
      if(p is OCL.Absyn.RT)
      {
        OCL.Absyn.RT _rt = (OCL.Absyn.RT)p;
        Render("(");
        Render("RT");
        ShowInternal(_rt.TypeSpecifier_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.OCLExpression p)
    {
      if(p is OCL.Absyn.OCLExp)
      {
        OCL.Absyn.OCLExp _oclexp = (OCL.Absyn.OCLExp)p;
        Render("(");
        Render("OCLExp");
        ShowInternal(_oclexp.Expression_);
        Render(")");
      }
      if(p is OCL.Absyn.OCLExpLet)
      {
        OCL.Absyn.OCLExpLet _oclexplet = (OCL.Absyn.OCLExpLet)p;
        Render("(");
        Render("OCLExpLet");
        ShowInternal(_oclexplet.ListLetExpression_);
        ShowInternal(_oclexplet.Expression_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.LetExpression p)
    {
      if(p is OCL.Absyn.LENoParam)
      {
        OCL.Absyn.LENoParam _lenoparam = (OCL.Absyn.LENoParam)p;
        Render("(");
        Render("LENoParam");
        ShowInternal(_lenoparam.Ident_);
        ShowInternal(_lenoparam.Expression_);
        Render(")");
      }
      if(p is OCL.Absyn.LENoParamType)
      {
        OCL.Absyn.LENoParamType _lenoparamtype = (OCL.Absyn.LENoParamType)p;
        Render("(");
        Render("LENoParamType");
        ShowInternal(_lenoparamtype.Ident_);
        ShowInternal(_lenoparamtype.TypeSpecifier_);
        ShowInternal(_lenoparamtype.Expression_);
        Render(")");
      }
      if(p is OCL.Absyn.LE)
      {
        OCL.Absyn.LE _le = (OCL.Absyn.LE)p;
        Render("(");
        Render("LE");
        ShowInternal(_le.Ident_);
        ShowInternal(_le.ListFormalParameter_);
        ShowInternal(_le.Expression_);
        Render(")");
      }
      if(p is OCL.Absyn.LEType)
      {
        OCL.Absyn.LEType _letype = (OCL.Absyn.LEType)p;
        Render("(");
        Render("LEType");
        ShowInternal(_letype.Ident_);
        ShowInternal(_letype.ListFormalParameter_);
        ShowInternal(_letype.TypeSpecifier_);
        ShowInternal(_letype.Expression_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ListLetExpression p)
    {
      for(int i=0; i < p.Count; i++)
      {
        ShowInternal(p[i]);
        if(i < p.Count - 1)
          Render(",");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.IfExpression p)
    {
      if(p is OCL.Absyn.IfExp)
      {
        OCL.Absyn.IfExp _ifexp = (OCL.Absyn.IfExp)p;
        Render("(");
        Render("IfExp");
        ShowInternal(_ifexp.Expression_1);
        ShowInternal(_ifexp.Expression_2);
        ShowInternal(_ifexp.Expression_3);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.Expression p)
    {
      if(p is OCL.Absyn.EOpImpl)
      {
        OCL.Absyn.EOpImpl _eopimpl = (OCL.Absyn.EOpImpl)p;
        Render("(");
        Render("EOpImpl");
        ShowInternal(_eopimpl.Expression_1);
        ShowInternal(_eopimpl.Expression_2);
        Render(")");
      }
      if(p is OCL.Absyn.EOpLog)
      {
        OCL.Absyn.EOpLog _eoplog = (OCL.Absyn.EOpLog)p;
        Render("(");
        Render("EOpLog");
        ShowInternal(_eoplog.Expression_1);
        ShowInternal(_eoplog.LogicalOperator_);
        ShowInternal(_eoplog.Expression_2);
        Render(")");
      }
      if(p is OCL.Absyn.EOpEq)
      {
        OCL.Absyn.EOpEq _eopeq = (OCL.Absyn.EOpEq)p;
        Render("(");
        Render("EOpEq");
        ShowInternal(_eopeq.Expression_1);
        ShowInternal(_eopeq.EqualityOperator_);
        ShowInternal(_eopeq.Expression_2);
        Render(")");
      }
      if(p is OCL.Absyn.EOpRel)
      {
        OCL.Absyn.EOpRel _eoprel = (OCL.Absyn.EOpRel)p;
        Render("(");
        Render("EOpRel");
        ShowInternal(_eoprel.Expression_1);
        ShowInternal(_eoprel.RelationalOperator_);
        ShowInternal(_eoprel.Expression_2);
        Render(")");
      }
      if(p is OCL.Absyn.EOpAdd)
      {
        OCL.Absyn.EOpAdd _eopadd = (OCL.Absyn.EOpAdd)p;
        Render("(");
        Render("EOpAdd");
        ShowInternal(_eopadd.Expression_1);
        ShowInternal(_eopadd.AddOperator_);
        ShowInternal(_eopadd.Expression_2);
        Render(")");
      }
      if(p is OCL.Absyn.EOpMul)
      {
        OCL.Absyn.EOpMul _eopmul = (OCL.Absyn.EOpMul)p;
        Render("(");
        Render("EOpMul");
        ShowInternal(_eopmul.Expression_1);
        ShowInternal(_eopmul.MultiplyOperator_);
        ShowInternal(_eopmul.Expression_2);
        Render(")");
      }
      if(p is OCL.Absyn.EOpUn)
      {
        OCL.Absyn.EOpUn _eopun = (OCL.Absyn.EOpUn)p;
        Render("(");
        Render("EOpUn");
        ShowInternal(_eopun.UnaryOperator_);
        ShowInternal(_eopun.Expression_);
        Render(")");
      }
      if(p is OCL.Absyn.EExplPropCall)
      {
        OCL.Absyn.EExplPropCall _eexplpropcall = (OCL.Absyn.EExplPropCall)p;
        Render("(");
        Render("EExplPropCall");
        ShowInternal(_eexplpropcall.Expression_);
        ShowInternal(_eexplpropcall.PostfixOperator_);
        ShowInternal(_eexplpropcall.PropertyCall_);
        Render(")");
      }
      if(p is OCL.Absyn.EMessage)
      {
        OCL.Absyn.EMessage _emessage = (OCL.Absyn.EMessage)p;
        Render("(");
        Render("EMessage");
        ShowInternal(_emessage.Expression_);
        ShowInternal(_emessage.PathName_);
        ShowInternal(_emessage.ListMessageArg_);
        Render(")");
      }
      if(p is OCL.Absyn.EImplPropCall)
      {
        OCL.Absyn.EImplPropCall _eimplpropcall = (OCL.Absyn.EImplPropCall)p;
        Render("(");
        Render("EImplPropCall");
        ShowInternal(_eimplpropcall.PropertyCall_);
        Render(")");
      }
      if(p is OCL.Absyn.ELitColl)
      {
        OCL.Absyn.ELitColl _elitcoll = (OCL.Absyn.ELitColl)p;
        Render("(");
        Render("ELitColl");
        ShowInternal(_elitcoll.LiteralCollection_);
        Render(")");
      }
      if(p is OCL.Absyn.ELit)
      {
        OCL.Absyn.ELit _elit = (OCL.Absyn.ELit)p;
        Render("(");
        Render("ELit");
        ShowInternal(_elit.OCLLiteral_);
        Render(")");
      }
      if(p is OCL.Absyn.EIfExp)
      {
        OCL.Absyn.EIfExp _eifexp = (OCL.Absyn.EIfExp)p;
        Render("(");
        Render("EIfExp");
        ShowInternal(_eifexp.IfExpression_);
        Render(")");
      }
      if(p is OCL.Absyn.ENull)
      {
        OCL.Absyn.ENull _enull = (OCL.Absyn.ENull)p;
        Render("ENull");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.MessageArg p)
    {
      if(p is OCL.Absyn.MAExpr)
      {
        OCL.Absyn.MAExpr _maexpr = (OCL.Absyn.MAExpr)p;
        Render("(");
        Render("MAExpr");
        ShowInternal(_maexpr.Expression_);
        Render(")");
      }
      if(p is OCL.Absyn.MAUnspec)
      {
        OCL.Absyn.MAUnspec _maunspec = (OCL.Absyn.MAUnspec)p;
        Render("MAUnspec");
      }
      if(p is OCL.Absyn.MAUnspecTyped)
      {
        OCL.Absyn.MAUnspecTyped _maunspectyped = (OCL.Absyn.MAUnspecTyped)p;
        Render("(");
        Render("MAUnspecTyped");
        ShowInternal(_maunspectyped.TypeSpecifier_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ListMessageArg p)
    {
      for(int i=0; i < p.Count; i++)
      {
        ShowInternal(p[i]);
        if(i < p.Count - 1)
          Render(",");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.PropertyCall p)
    {
      if(p is OCL.Absyn.PCall)
      {
        OCL.Absyn.PCall _pcall = (OCL.Absyn.PCall)p;
        Render("(");
        Render("PCall");
        ShowInternal(_pcall.PathName_);
        ShowInternal(_pcall.PossTimeExpression_);
        ShowInternal(_pcall.PossQualifiers_);
        ShowInternal(_pcall.PossPropCallParam_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.PathName p)
    {
      if(p is OCL.Absyn.PathN)
      {
        OCL.Absyn.PathN _pathn = (OCL.Absyn.PathN)p;
        Render("(");
        Render("PathN");
        ShowInternal(_pathn.ListPName_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.PName p)
    {
      if(p is OCL.Absyn.PN)
      {
        OCL.Absyn.PN _pn = (OCL.Absyn.PN)p;
        Render("(");
        Render("PN");
        ShowInternal(_pn.Ident_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ListPName p)
    {
      for(int i=0; i < p.Count; i++)
      {
        ShowInternal(p[i]);
        if(i < p.Count - 1)
          Render(",");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.PossQualifiers p)
    {
      if(p is OCL.Absyn.NoQual)
      {
        OCL.Absyn.NoQual _noqual = (OCL.Absyn.NoQual)p;
        Render("NoQual");
      }
      if(p is OCL.Absyn.Qual)
      {
        OCL.Absyn.Qual _qual = (OCL.Absyn.Qual)p;
        Render("(");
        Render("Qual");
        ShowInternal(_qual.Qualifiers_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.Qualifiers p)
    {
      if(p is OCL.Absyn.Quals)
      {
        OCL.Absyn.Quals _quals = (OCL.Absyn.Quals)p;
        Render("(");
        Render("Quals");
        ShowInternal(_quals.ListExpression_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.PossTimeExpression p)
    {
      if(p is OCL.Absyn.NoTE)
      {
        OCL.Absyn.NoTE _note = (OCL.Absyn.NoTE)p;
        Render("NoTE");
      }
      if(p is OCL.Absyn.AtPre)
      {
        OCL.Absyn.AtPre _atpre = (OCL.Absyn.AtPre)p;
        Render("AtPre");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.PossPropCallParam p)
    {
      if(p is OCL.Absyn.NoPCP)
      {
        OCL.Absyn.NoPCP _nopcp = (OCL.Absyn.NoPCP)p;
        Render("NoPCP");
      }
      if(p is OCL.Absyn.PCPs)
      {
        OCL.Absyn.PCPs _pcps = (OCL.Absyn.PCPs)p;
        Render("(");
        Render("PCPs");
        ShowInternal(_pcps.PropertyCallParameters_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.Declarator p)
    {
      if(p is OCL.Absyn.Decl)
      {
        OCL.Absyn.Decl _decl = (OCL.Absyn.Decl)p;
        Render("(");
        Render("Decl");
        ShowInternal(_decl.DeclaratorVarList_);
        Render(")");
      }
      if(p is OCL.Absyn.DeclAcc)
      {
        OCL.Absyn.DeclAcc _declacc = (OCL.Absyn.DeclAcc)p;
        Render("(");
        Render("DeclAcc");
        ShowInternal(_declacc.DeclaratorVarList_);
        ShowInternal(_declacc.Ident_);
        ShowInternal(_declacc.TypeSpecifier_);
        ShowInternal(_declacc.Expression_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.DeclaratorVarList p)
    {
      if(p is OCL.Absyn.DVL)
      {
        OCL.Absyn.DVL _dvl = (OCL.Absyn.DVL)p;
        Render("(");
        Render("DVL");
        ShowInternal(_dvl.ListIdent_);
        Render(")");
      }
      if(p is OCL.Absyn.DVLType)
      {
        OCL.Absyn.DVLType _dvltype = (OCL.Absyn.DVLType)p;
        Render("(");
        Render("DVLType");
        ShowInternal(_dvltype.ListIdent_);
        ShowInternal(_dvltype.SimpleTypeSpecifier_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ListIdent p)
    {
      for(int i=0; i < p.Count; i++)
      {
        ShowInternal(p[i]);
        if(i < p.Count - 1)
          Render(",");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.PropertyCallParameters p)
    {
      if(p is OCL.Absyn.PCPDecl)
      {
        OCL.Absyn.PCPDecl _pcpdecl = (OCL.Absyn.PCPDecl)p;
        Render("(");
        Render("PCPDecl");
        ShowInternal(_pcpdecl.Declarator_);
        ShowInternal(_pcpdecl.ListExpression_);
        Render(")");
      }
      if(p is OCL.Absyn.PCP)
      {
        OCL.Absyn.PCP _pcp = (OCL.Absyn.PCP)p;
        Render("(");
        Render("PCP");
        ShowInternal(_pcp.ListExpression_);
        Render(")");
      }
      if(p is OCL.Absyn.PCPNoDeclNoParam)
      {
        OCL.Absyn.PCPNoDeclNoParam _pcpnodeclnoparam = (OCL.Absyn.PCPNoDeclNoParam)p;
        Render("PCPNoDeclNoParam");
      }
      if(p is OCL.Absyn.PCPConcrete)
      {
        OCL.Absyn.PCPConcrete _pcpconcrete = (OCL.Absyn.PCPConcrete)p;
        Render("(");
        Render("PCPConcrete");
        ShowInternal(_pcpconcrete.Expression_);
        ShowInternal(_pcpconcrete.ListPCPHelper_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ListExpression p)
    {
      for(int i=0; i < p.Count; i++)
      {
        ShowInternal(p[i]);
        if(i < p.Count - 1)
          Render(",");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.PCPHelper p)
    {
      if(p is OCL.Absyn.PCPComma)
      {
        OCL.Absyn.PCPComma _pcpcomma = (OCL.Absyn.PCPComma)p;
        Render("(");
        Render("PCPComma");
        ShowInternal(_pcpcomma.Expression_);
        Render(")");
      }
      if(p is OCL.Absyn.PCPColon)
      {
        OCL.Absyn.PCPColon _pcpcolon = (OCL.Absyn.PCPColon)p;
        Render("(");
        Render("PCPColon");
        ShowInternal(_pcpcolon.SimpleTypeSpecifier_);
        Render(")");
      }
      if(p is OCL.Absyn.PCPIterate)
      {
        OCL.Absyn.PCPIterate _pcpiterate = (OCL.Absyn.PCPIterate)p;
        Render("(");
        Render("PCPIterate");
        ShowInternal(_pcpiterate.Ident_);
        ShowInternal(_pcpiterate.TypeSpecifier_);
        ShowInternal(_pcpiterate.Expression_);
        Render(")");
      }
      if(p is OCL.Absyn.PCPBar)
      {
        OCL.Absyn.PCPBar _pcpbar = (OCL.Absyn.PCPBar)p;
        Render("(");
        Render("PCPBar");
        ShowInternal(_pcpbar.Expression_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ListPCPHelper p)
    {
      for(int i=0; i < p.Count; i++)
      {
        ShowInternal(p[i]);
        if(i < p.Count - 1)
          Render(",");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.OCLLiteral p)
    {
      if(p is OCL.Absyn.LitStr)
      {
        OCL.Absyn.LitStr _litstr = (OCL.Absyn.LitStr)p;
        Render("(");
        Render("LitStr");
        ShowInternal(_litstr.String_);
        Render(")");
      }
      if(p is OCL.Absyn.LitNum)
      {
        OCL.Absyn.LitNum _litnum = (OCL.Absyn.LitNum)p;
        Render("(");
        Render("LitNum");
        ShowInternal(_litnum.OCLNumber_);
        Render(")");
      }
      if(p is OCL.Absyn.LitBoolTrue)
      {
        OCL.Absyn.LitBoolTrue _litbooltrue = (OCL.Absyn.LitBoolTrue)p;
        Render("LitBoolTrue");
      }
      if(p is OCL.Absyn.LitBoolFalse)
      {
        OCL.Absyn.LitBoolFalse _litboolfalse = (OCL.Absyn.LitBoolFalse)p;
        Render("LitBoolFalse");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.SimpleTypeSpecifier p)
    {
      if(p is OCL.Absyn.STSpec)
      {
        OCL.Absyn.STSpec _stspec = (OCL.Absyn.STSpec)p;
        Render("(");
        Render("STSpec");
        ShowInternal(_stspec.PathName_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.LiteralCollection p)
    {
      if(p is OCL.Absyn.LCollection)
      {
        OCL.Absyn.LCollection _lcollection = (OCL.Absyn.LCollection)p;
        Render("(");
        Render("LCollection");
        ShowInternal(_lcollection.CollectionKind_);
        ShowInternal(_lcollection.ListCollectionItem_);
        Render(")");
      }
      if(p is OCL.Absyn.LCollectionEmpty)
      {
        OCL.Absyn.LCollectionEmpty _lcollectionempty = (OCL.Absyn.LCollectionEmpty)p;
        Render("(");
        Render("LCollectionEmpty");
        ShowInternal(_lcollectionempty.CollectionKind_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.ListCollectionItem p)
    {
      for(int i=0; i < p.Count; i++)
      {
        ShowInternal(p[i]);
        if(i < p.Count - 1)
          Render(",");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.CollectionItem p)
    {
      if(p is OCL.Absyn.CI)
      {
        OCL.Absyn.CI _ci = (OCL.Absyn.CI)p;
        Render("(");
        Render("CI");
        ShowInternal(_ci.Expression_);
        Render(")");
      }
      if(p is OCL.Absyn.CIRange)
      {
        OCL.Absyn.CIRange _cirange = (OCL.Absyn.CIRange)p;
        Render("(");
        Render("CIRange");
        ShowInternal(_cirange.Expression_1);
        ShowInternal(_cirange.Expression_2);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.OCLNumber p)
    {
      if(p is OCL.Absyn.NumInt)
      {
        OCL.Absyn.NumInt _numint = (OCL.Absyn.NumInt)p;
        Render("(");
        Render("NumInt");
        ShowInternal(_numint.Integer_);
        Render(")");
      }
      if(p is OCL.Absyn.NumDouble)
      {
        OCL.Absyn.NumDouble _numdouble = (OCL.Absyn.NumDouble)p;
        Render("(");
        Render("NumDouble");
        ShowInternal(_numdouble.Double_);
        Render(")");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.LogicalOperator p)
    {
      if(p is OCL.Absyn.LAnd)
      {
        OCL.Absyn.LAnd _land = (OCL.Absyn.LAnd)p;
        Render("LAnd");
      }
      if(p is OCL.Absyn.LOr)
      {
        OCL.Absyn.LOr _lor = (OCL.Absyn.LOr)p;
        Render("LOr");
      }
      if(p is OCL.Absyn.LXor)
      {
        OCL.Absyn.LXor _lxor = (OCL.Absyn.LXor)p;
        Render("LXor");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.CollectionKind p)
    {
      if(p is OCL.Absyn.Set)
      {
        OCL.Absyn.Set _set = (OCL.Absyn.Set)p;
        Render("Set");
      }
      if(p is OCL.Absyn.Bag)
      {
        OCL.Absyn.Bag _bag = (OCL.Absyn.Bag)p;
        Render("Bag");
      }
      if(p is OCL.Absyn.Sequence)
      {
        OCL.Absyn.Sequence _sequence = (OCL.Absyn.Sequence)p;
        Render("Sequence");
      }
      if(p is OCL.Absyn.Collection)
      {
        OCL.Absyn.Collection _collection = (OCL.Absyn.Collection)p;
        Render("Collection");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.EqualityOperator p)
    {
      if(p is OCL.Absyn.EEq)
      {
        OCL.Absyn.EEq _eeq = (OCL.Absyn.EEq)p;
        Render("EEq");
      }
      if(p is OCL.Absyn.ENEq)
      {
        OCL.Absyn.ENEq _eneq = (OCL.Absyn.ENEq)p;
        Render("ENEq");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.RelationalOperator p)
    {
      if(p is OCL.Absyn.RGT)
      {
        OCL.Absyn.RGT _rgt = (OCL.Absyn.RGT)p;
        Render("RGT");
      }
      if(p is OCL.Absyn.RGTE)
      {
        OCL.Absyn.RGTE _rgte = (OCL.Absyn.RGTE)p;
        Render("RGTE");
      }
      if(p is OCL.Absyn.RLT)
      {
        OCL.Absyn.RLT _rlt = (OCL.Absyn.RLT)p;
        Render("RLT");
      }
      if(p is OCL.Absyn.RLTE)
      {
        OCL.Absyn.RLTE _rlte = (OCL.Absyn.RLTE)p;
        Render("RLTE");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.AddOperator p)
    {
      if(p is OCL.Absyn.AAdd)
      {
        OCL.Absyn.AAdd _aadd = (OCL.Absyn.AAdd)p;
        Render("AAdd");
      }
      if(p is OCL.Absyn.ASub)
      {
        OCL.Absyn.ASub _asub = (OCL.Absyn.ASub)p;
        Render("ASub");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.MultiplyOperator p)
    {
      if(p is OCL.Absyn.MMult)
      {
        OCL.Absyn.MMult _mmult = (OCL.Absyn.MMult)p;
        Render("MMult");
      }
      if(p is OCL.Absyn.MDiv)
      {
        OCL.Absyn.MDiv _mdiv = (OCL.Absyn.MDiv)p;
        Render("MDiv");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.UnaryOperator p)
    {
      if(p is OCL.Absyn.UMin)
      {
        OCL.Absyn.UMin _umin = (OCL.Absyn.UMin)p;
        Render("UMin");
      }
      if(p is OCL.Absyn.UNot)
      {
        OCL.Absyn.UNot _unot = (OCL.Absyn.UNot)p;
        Render("UNot");
      }
    }
 
    private static void ShowInternal(OCL.Absyn.PostfixOperator p)
    {
      if(p is OCL.Absyn.PDot)
      {
        OCL.Absyn.PDot _pdot = (OCL.Absyn.PDot)p;
        Render("PDot");
      }
      if(p is OCL.Absyn.PArrow)
      {
        OCL.Absyn.PArrow _parrow = (OCL.Absyn.PArrow)p;
        Render("PArrow");
      }
    }
    #endregion
  }
  #endregion
}
