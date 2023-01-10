namespace Factory_Method.Properties.Domain
{
    public interface IMemberShip
    {
        string Name { get; }
        string Description { get; }
        decimal GetPrice();

        string NewDescription(string description);
    }
}