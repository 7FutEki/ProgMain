using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.Models;

namespace WpfApp1.Forms
{
    /// <summary>
    /// Логика взаимодействия для ChooseBookWindow.xaml
    /// </summary>
    public partial class ChooseBookWindow : Window
    {
        public ObservableCollection<AdressBook> AllBook { get; set; }
        public AdressBook AdressBook { get; set; }
        public ChooseBookWindow()
        {
            AllBook = new();
            DataContext = this;
            this.Loaded += Sqlite_Loaded;

            InitializeComponent();
        }
        private void Sqlite_Loaded(object sender, RoutedEventArgs e)
        {
            ApplicationContext db = new ApplicationContext();
            db.Database.Migrate();
            List<AdressBook> books = db.AdressBooks.ToList();
            ListBook.ItemsSource = books;
            foreach (AdressBook book in books)
            {
                AllBook.Add(new AdressBook { Name = book.Name});
            }


            ListBook.ItemsSource = AllBook;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_dlt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
