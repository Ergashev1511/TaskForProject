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
using TaskForProject.Api.Models;
using TaskForProject.Wpf.Models;
using TaskForProject.Wpf.Services.IService;
using TaskForProject.Wpf.Services.Service;
using TaskForProject.Wpf.Windows;

namespace TaskForProject.Wpf.Pages
{
    /// <summary>
    /// Interaction logic for Book_ListPage.xaml
    /// </summary>
    public partial class Book_ListPage : Page
    { 

       
        public Book_ListPage()
        {
            InitializeComponent();
         
        }

      
        private void Create_rb_Click(object sender, RoutedEventArgs e)
        {
            CreateBookWindow createBookWindow = new CreateBookWindow();
            createBookWindow.ShowDialog();
        }



    }
}
