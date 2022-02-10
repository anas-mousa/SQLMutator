using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlMutatorCore
{
    class UnionToUnionAll : CSharpSyntaxRewriter
    {
        public UnionToUnionAll() : base() { }

        public override SyntaxNode VisitInvocationExpression(InvocationExpressionSyntax node)
        {
            //string oldNodeString = node.ToString();

            //if (oldNodeString.Contains(".Select("))
            //{
            //    string newNodeString = string.Empty;

            //    if (!oldNodeString.Contains(".Distinct()"))
            //    {
            //        newNodeString = oldNodeString.Replace(".Select(", ".Distinct().Select(");

            //        string newNodeClassString = @"class C {public void MyMethod(){" + newNodeString + ";}}";
            //        var newNode = CSharpSyntaxTree.ParseText(newNodeClassString).GetRoot().DescendantNodes().OfType<InvocationExpressionSyntax>().First();

            //        return newNode;
            //    }
            //}

            return base.VisitInvocationExpression(node);
        }

    }
}
