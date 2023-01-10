using Factory_Method.Properties.Domain;

namespace Factory_Method.Factories
{
    public abstract class MembershipFactory //поэтому и метод, ибо используем абстрактный метод
    {
        public abstract IMemberShip GetMemberShip();
    }
}