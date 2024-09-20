using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
    }


    public class Phone
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Title, Company);
        }

    }
    public class Phones: ObservableCollection<Phone>    
    {
        public Phones()
        {
            Add(new Phone { Title = "iPhone 6S", Company = "Apple", Price = 54990 });
            Add(new Phone { Title = "Samsung 132", Company = "Samsung", Price = 82340 });
            Add(new Phone { Title = "Nokia 800", Company = "NOKIA", Price = 77340 });
        }
        
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Coment { get; set; }
        public DateTime Data { get; set; }
        public bool IsActiv { get; set; }

    }
    public class Items : ObservableCollection<Item>
    {
        public Items()
        {
            Add(new Item { Id = 1, Name = "Одежда", Data = new DateTime(2024,6,10),IsActiv=true });
            Add(new Item { Id = 2, Name = "Продукты", Data = new DateTime(2024,5,18), IsActiv = true });
            Add(new Item { Id = 3, Name = "Мебель", Data = new DateTime(2024,2,3), IsActiv = true });
            Add(new Item { Id = 4, Name = "Авто", Data = new DateTime(2023,10,10), IsActiv = true });
            Add(new Item { Id = 5, Name = "Инструменты", Data = new DateTime(2022,9,16), IsActiv = true });
        }
    }

}