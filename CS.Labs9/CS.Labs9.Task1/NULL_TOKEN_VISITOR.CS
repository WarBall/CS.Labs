
namespace CS.Labs9.Task1
{
    public class NullTokenVisitor : ITokenVisitor
    {
        public void Visit (ILineStartToken t) { }

        public void Visit(ILineEndToken t) { }

        public void Visit(ICommentToken t) { }

        public void Visit(IDirectiveToken t) { }

        public void Visit(IIdentifierToken t) { }

        public void Visit(IKeywordToken t) { }

        public void Visit(IWhiteSpaceToken t) { }

        public void Visit(IOtherToken t) { }

        public void Test()
        {
            new NullTokenVisitor();
        }
    }
}
