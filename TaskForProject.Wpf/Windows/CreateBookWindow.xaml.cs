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
using System.Windows.Shapes;
using TaskForProject.Api.Services.Services;
using TaskForProject.Wpf.Services.IService;
using System.Net.NetworkInformation;
using static System.Net.WebRequestMethods;
using TaskForProject.Api.Models;
using TaskForProject.Api.Repositories.IRepository;
using TaskForProject.Api.Repositories.Repository;
using TaskForProject.Wpf.Services.Service;

namespace TaskForProject.Wpf.Windows
{
    /// <summary>
    /// Interaction logic for CreateBookWindow.xaml
    /// </summary>
    public partial class CreateBookWindow : Window
    {
        private readonly TaskForProject.Wpf.Services.Service.Book1Service book1Service;
        private readonly TaskForProject.Wpf.Services.Service.Book2Service book2Service;
        

        public CreateBookWindow()
        {
            InitializeComponent();

            this.book1Service = new TaskForProject.Wpf.Services.Service.Book1Service();
            this.book2Service = new TaskForProject.Wpf.Services.Service.Book2Service();


        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            bookname_txt.Text=author_txt.Text=describtion_txt.Text=year_txt.Text=string.Empty;
        }

        
        

        private async void Save_Click_1(object sender, RoutedEventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                if (bookname_txt.Text != string.Empty && author_txt.Text != string.Empty && describtion_txt.Text != string.Empty && year_txt.Text != string.Empty)
                {
                    var book1 = new Book1()
                    {
                        BookName = bookname_txt.Text,
                        Author = author_txt.Text,
                        Description = describtion_txt.Text,
                        Year = year_txt.Text,
                    };
                    var book2 = new Book2()
                    {
                        BookName = bookname_txt.Text,
                        Author = author_txt.Text,
                        Description = describtion_txt.Text,
                        Year = year_txt.Text,
                    };
                    await book1Service.CreateBook1(book1);
                    await book2Service.CraateBook2(book2);
                    Clear();
                    this.Close();
                }
            }
            else
            {
                if (bookname_txt.Text != string.Empty && author_txt.Text != string.Empty && describtion_txt.Text != string.Empty && year_txt.Text != string.Empty)
                {
                  
                    var book2 = new Book2()
                    {
                        BookName = bookname_txt.Text,
                        Author = author_txt.Text,
                        Description = describtion_txt.Text,
                        Year = year_txt.Text,
                    };
                   
                    await book2Service.CraateBook2(book2);
                    Clear();
                    this.Close();
                }
            }
        }
        public void Clear()
        {
            bookname_txt.Text=author_txt.Text=describtion_txt.Text=year_txt.Text=string.Empty;
        }
    }
}
