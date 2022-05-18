namespace BookLib
{
    public abstract class AbstractItem : IPriceable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public AbstractItem(string title) => Title = title;

        public virtual double GetPrice() => Price;
    }

    public interface IPriceable
    {
        double Price { get; set; }
    }
}
