
namespace CS.Labs9.Task1
{ 
    using System;
    
    public class HTMLTokenVisitor : NullTokenVisitor
    {
        public override void Visit(ILineStartToken line)
        {
            Console.Write("<span class=\"line_number\">");
            Console.Write("{0,3}", line.Number());
            Console.Write("</span>");
        }

        public override void Visit(ILineEndToken t)
        {
            Console.WriteLine();
        }

        public override void Visit(IIdentifierToken token)
        {
            Console.Write(token.ToString());
        }

        public override void Visit(ICommentToken token)
        {
            Console.Write(token.ToString());
        }

        public override void Visit(IKeywordToken token)
        {
            Console.Write(token.ToString());
        }

        public override void Visit(IWhiteSpaceToken token)
        {
            Console.Write(token.ToString());
        }

        public override void Visit(IOtherToken token)
        {
            Console.Write(token.ToString());
        }
    }
}
