namespace Composite
{
    public abstract class Item
    {
        protected string itemname;
        protected string ownername;

        public Item(string name)
        {
            itemname = name;
        }
        
        public void SetOwner(string owner)
        {
            ownername = owner;
        }
        
        public virtual void Add(Item subItem){ }
        public virtual void Remove(Item subItem){ }
        public abstract void Display();

    }
}