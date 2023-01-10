namespace Visitor
{
    public interface IPlace
    {
        void Accept(IVisitor visitor);
    }
}