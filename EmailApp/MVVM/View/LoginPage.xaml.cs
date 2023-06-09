using EmailApp.MVVM.ViewModel;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmailApp.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {

        private void LoadAnimatePage()
        {

            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = 0;
            opacityAnimation.To = 1;
            opacityAnimation.Duration = TimeSpan.FromSeconds(0.5);

            DoubleAnimation scaleAnimation = new DoubleAnimation();
            scaleAnimation.From = 0.5;
            scaleAnimation.To = 1;
            scaleAnimation.Duration = TimeSpan.FromSeconds(0.5);

            DoubleAnimation positionAnimation = new DoubleAnimation();
            positionAnimation.From = -100;
            positionAnimation.To = 0;
            positionAnimation.Duration = TimeSpan.FromSeconds(0.5);

            AnimGrid.BeginAnimation(Grid.OpacityProperty, opacityAnimation);
            AnimGrid.RenderTransform.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
            AnimGrid.RenderTransform.BeginAnimation(ScaleTransform.ScaleYProperty, scaleAnimation);
            AnimGrid.RenderTransform.BeginAnimation(TranslateTransform.XProperty, positionAnimation);
        }
        public LoginPage(MainWindow mainWindow = null)
        {
            InitializeComponent();
            LoadAnimatePage();
            DataContext = new LoginVM(mainWindow);
        }

        private void CloseAnimatePage()
        {
            Storyboard sb = (Storyboard)FindResource("CloseIconAnimation");
            sb.Begin(Icon);

            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = 1;
            opacityAnimation.To = 0;
            opacityAnimation.Duration = TimeSpan.FromSeconds(0.5);
            opacityAnimation.Completed += CloseAnimatePage_Completed;

            AnimGrid.BeginAnimation(Grid.OpacityProperty, opacityAnimation);
        }

        private void CloseAnimatePage_Completed(object sender, EventArgs e)
        {
            LoginGrid.Visibility = Visibility.Collapsed;
            ServerSelectionGrid.Visibility = Visibility.Visible;
            LoadAnimatePage();
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            CloseAnimatePage();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadAnimatePage();
            LoginGrid.Visibility = Visibility.Visible;
            ServerSelectionGrid.Visibility = Visibility.Collapsed;
        }

        private void rambler_Click(object sender, RoutedEventArgs e)
        {
            LoginBtn.IsEnabled = true;
            RamblerIcon.Visibility = Visibility.Visible;
            rambler.BorderBrush = new SolidColorBrush(Color.FromRgb(0x1a, 0x73, 0xe8));
            rambler.Background = new SolidColorBrush(Color.FromRgb(0xe8, 0xf0, 0xfe));
            rambler.BorderThickness = new Thickness(2);

            GmailIcon.Visibility = Visibility.Hidden;
            gmail.Background = new SolidColorBrush(Color.FromRgb(0xe9, 0xf1, 0xeb));
            gmail.BorderThickness = new Thickness(0);

            YandexIcon.Visibility = Visibility.Hidden;
            yandex.Background = new SolidColorBrush(Color.FromRgb(0xe9, 0xf1, 0xeb));
            yandex.BorderThickness = new Thickness(0);
        }

        private void gmail_Click(object sender, RoutedEventArgs e)
        {
            LoginBtn.IsEnabled = true;
            RamblerIcon.Visibility = Visibility.Hidden;
            rambler.Background = new SolidColorBrush(Color.FromRgb(0xe9, 0xf1, 0xeb));
            rambler.BorderThickness = new Thickness(0);

            GmailIcon.Visibility = Visibility.Visible;
            gmail.BorderBrush = new SolidColorBrush(Color.FromRgb(0x1a, 0x73, 0xe8));
            gmail.Background = new SolidColorBrush(Color.FromRgb(0xe8, 0xf0, 0xfe));
            gmail.BorderThickness = new Thickness(2);

            YandexIcon.Visibility = Visibility.Hidden;
            yandex.Background = new SolidColorBrush(Color.FromRgb(0xe9, 0xf1, 0xeb));
            yandex.BorderThickness = new Thickness(0);
        }

        private void yandex_Click(object sender, RoutedEventArgs e)
        {
            LoginBtn.IsEnabled = true;
            RamblerIcon.Visibility = Visibility.Hidden;
            rambler.Background = new SolidColorBrush(Color.FromRgb(0xe9, 0xf1, 0xeb));
            rambler.BorderThickness = new Thickness(0);

            GmailIcon.Visibility = Visibility.Hidden;
            gmail.Background = new SolidColorBrush(Color.FromRgb(0xe9, 0xf1, 0xeb));
            gmail.BorderThickness = new Thickness(0); GmailIcon.Visibility = Visibility.Hidden;

            YandexIcon.Visibility = Visibility.Visible;
            yandex.BorderBrush = new SolidColorBrush(Color.FromRgb(0x1a, 0x73, 0xe8));
            yandex.Background = new SolidColorBrush(Color.FromRgb(0xe8, 0xf0, 0xfe));
            yandex.BorderThickness = new Thickness(2);
        }
    }
}
