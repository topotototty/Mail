using EmailApp.MVVM.View;
using PiskaPerepiska.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using EmailApp.MVVM.Model;
using EmailApp.MVVM.ViewModel.Helpers;

namespace EmailApp.MVVM.ViewModel
{
    internal class LoginVM : BindingsHelper 
    {
        public LoggedUser User = new LoggedUser();

        #region Свойства

        private string userLogin;
        public string UserLogin
        {
            get { return userLogin; }
            set 
            {
                userLogin = value;
                OnPropertyChanged();
            }   
        }

        private string userPassword;
        public string UserPassword
        {
            get { return userPassword; }
            set 
            {
                userPassword = value;
                OnPropertyChanged();     
            }
        }

        private string userAddress;
        private MainWindow mainWindow;
        #endregion

        #region Команды
        public BindableCommand YandexSelectedCommand { get; set; }
        public BindableCommand GmailSelectedCommand { get; set; }
        public BindableCommand RamblerSelectedCommand { get; set; }

        public BindableCommand LoginCommand { get; set; }

        #endregion

        public LoginVM(MainWindow mainWindow = null)
        {
            if(mainWindow != null)
                this.mainWindow = mainWindow;
            YandexSelectedCommand = new BindableCommand(_ => { userAddress = userLogin + "@yandex.ru"; });
            GmailSelectedCommand = new BindableCommand(_ => { userAddress = userLogin + "@gmail.com"; });
            RamblerSelectedCommand = new BindableCommand(_ => { userAddress = userLogin + "@rambler.com"; });
            LoginCommand = new BindableCommand( _ =>  Login());
        }

        public void Login()
        {
            User.SmtpPort = 993;
            User.ImapPort = 465;
            User.Password = userPassword;
            User.Email = userAddress;

            try
            {
                ImapHelper.InitializeImap(userAddress, userPassword);
                mainWindow.Frame.NavigationService.Navigate(new MainPage(mainWindow));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid login or password." + ex);
            }
        }
    }
}