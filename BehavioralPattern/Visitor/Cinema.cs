namespace Visitor
{
    public class Cinema : IPlace
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}