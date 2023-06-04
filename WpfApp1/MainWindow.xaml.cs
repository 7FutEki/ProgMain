
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Models;
using WpfApp1.Forms;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AdressBook AdressBook;
        public MainWindow()
        {
            
            InitializeComponent();
            AdressBook = new AdressBook();
            DataContext = AdressBook;
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_rollup_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_create_Click(object sender, RoutedEventArgs e)
        {
            Metods.AddBook(AdressBook.Name);
            ChooseBookWindow chooseBookWindow = new ChooseBookWindow();
            Close();
            chooseBookWindow.ShowDialog();
        }
    }
}
