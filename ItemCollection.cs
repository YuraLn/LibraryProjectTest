using System.Collections.Generic;
using System.Linq;

namespace BookLib
{
    public class ItemCollection
    {
        public List<AbstractItem> Items { get; set; }

        public ItemCollection() => SetData();

        public void AddItem(AbstractItem item) => Items.Add(item);

        /// <summary>
        /// This for insert start data
        /// </summary>
        public void SetData()
        {
            string s = "HHH";
            string ss = s.ToLower();
            Items = new List<AbstractItem>();
            Items.Add(new Book { Price = 43 });
            Items.Add(new Journal("Stam") { Price = 43 });
            Items.Add(new Book("HP - 4") { Price = 5 });
        }

        public IEnumerable<AbstractItem> GetItemByTitle(string title) => Items.Where(i => i.Title.Contains(title));
    }
}