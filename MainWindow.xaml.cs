using BookLib;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using WpfApp1.Views;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public List<AbstractItem> Books { get; set; }
        public ObservableCollection<AbstractItem> OcBooks { get; set; }

        ItemCollection collection = new ItemCollection();

        public MainWindow()
        {
            InitializeComponent();

            Book b = new Book("First");
            tbTitle.Text = b.Title;

            Books = new List<AbstractItem>(collection.GetItemByTitle("i"));
            OcBooks = new ObservableCollection<AbstractItem>(collection.GetItemByTitle("i"));

            List<IPriceable> priceables = new List<IPriceable>();
            foreach (var item in priceables)
            {
                item.Price += 100;
            }

        }

        private void OpenOtherWindowClick(object sender, RoutedEventArgs e)
        {
            var win = new OtherWindow();
            win.Show();
            //win.Hide();

            //spBooks.Children.Add(new UcBooks());
        }
    }
}
