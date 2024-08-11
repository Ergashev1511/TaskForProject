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
using TaskForProject.Api.Models;
using TaskForProject.Api.Services.Services;
using TaskForProject.Wpf.Models;
using TaskForProject.Wpf.Pages;
using TaskForProject.Wpf.Services.IService;
using TaskForProject.Wpf.Services.Service;

namespace TaskForProject.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IBook1Service _book1service;
        private IBook2Servce _book2Servce;
        List<Book1> book1s = new List<Book1>();
        List<Book2> books2 = new List<Book2>();
        public MainWindow()
        {
            InitializeComponent();
            this._book1service=new TaskForProject.Wpf.Services.Service.Book1Service();
            this._book2Servce = new TaskForProject.Wpf.Services.Service.Book2Service();
        }

        private void maxmize_btn_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState==WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minus_btn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void dg_mous_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private async void book1_btn_Click(object sender, RoutedEventArgs e)
        {
            Book_ListPage listPage = new Book_ListPage();
            PageNavigator.Content = listPage;
            List<Book> books = new List<Book>();
            books = await GetAllBook1();
            if(books!=null && books.Any())
            {
                listPage.booklist_datagrod.ItemsSource = books;
                listPage.booklist_datagrod.Items.Refresh();
            }

            
        }

        private async void book2_btn_Click(object sender, RoutedEventArgs e)
        {
             Book_ListPage listPage = new Book_ListPage();
               PageNavigator.Content= listPage;
            List<Book> books=new List<Book>();
            books=await GetAllBook2();
            if(books!=null && books.Any())
            {
                listPage.booklist_datagrod.ItemsSource = books;
                listPage.booklist_datagrod.Items.Refresh();
            }
        }

        public async Task<List<Book>> GetAllBook1()
        {
            book1s = await _book1service.GetAllBook1();
            List<Book> books = new List<Book>();
            books = book1s.Select(a => new Book()
            {
                Id = a.Id,
                Name = a.BookName,
                Description = a.Description,
                Year = a.Year,
                Author = a.Author,
            }).ToList();
            return books;          
        }

        public async Task<List<Book>> GetAllBook2()
        {
            books2=await _book2Servce.GetAllBook2();
            List<Book> books=new List<Book>();
            books=books2.Select(a => new Book()
            {
                Id = a.Id,
                Name = a.BookName,
                Description = a.Description,
                Year = a.Year,
                Author = a.Author,
            }).ToList();
            return books;
        }

    }
}