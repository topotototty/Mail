using EmailApp.MVVM.Model;
using EmailApp.MVVM.ViewModel;
using EmailApp.MVVM.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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

namespace EmailApp.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage(MainWindow mainWindow)
        {
            InitializeComponent();
            MainPageVM mainPageVM = new MainPageVM
            {
                richTextBox = richTextBox
            };
            DataContext = mainPageVM;
        }

        private void CloseNewMassageBtn_Click(object sender, RoutedEventArgs e)
        {
            NewMessageGrid.Visibility = Visibility.Collapsed;
        }

        private void NewMessageBtn_Click(object sender, RoutedEventArgs e)
        {
            NewMessageGrid.Visibility = Visibility.Visible;
        }



        private void EmailList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            WebBrowser.Visibility = Visibility.Visible;
            WebBrowser.NavigateToString(ImapHelper.ReadEmail((Email)EmailList.SelectedValue));
        }

        private void CloseWebBtn_Click(object sender, RoutedEventArgs e)
        {
            WebBrowser.Visibility = Visibility.Hidden;
        }

        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            ImapHelper.SendEmail(textRange.Text, SubjectTextBox.Text, AddressTextBox.Text);
        }
    }
}
