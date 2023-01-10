namespace Visitor
{
    public interface IVisitor
    {
        void Visit(Zoo zoo);

        void Visit(Cinema cimena);

        void Visit(Circus circus);
    }
}