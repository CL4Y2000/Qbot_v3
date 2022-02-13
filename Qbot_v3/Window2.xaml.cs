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
using System.Windows.Threading;

namespace Qbot_v3
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        #region mouseEnter/mouseLeave

        private void txtLogQbot_MouseEnter(object sender, MouseEventArgs e)
        {
            LoginQbot.BorderBrush = Brushes.White;
        }

        private void txtLogQbot_MouseLeave(object sender, MouseEventArgs e)
        {
            LoginQbot.BorderBrush = Brushes.Gray;
        }

        private void txtPassQbot_MouseEnter(object sender, MouseEventArgs e)
        {
            PassQbot.BorderBrush = Brushes.White;
        }

        private void txtPassQbot_MouseLeave(object sender, MouseEventArgs e)
        {
            PassQbot.BorderBrush = Brushes.Gray;
        }

        private void txtLogQuotex_MouseEnter(object sender, MouseEventArgs e)
        {
            LoginQuotex.BorderBrush = Brushes.White;
        }

        private void txtLogQuotex_MouseLeave(object sender, MouseEventArgs e)
        {
            LoginQuotex.BorderBrush = Brushes.Gray;
        }

        private void txtPassQuotex_MouseEnter(object sender, MouseEventArgs e)
        {
            PassQuotex.BorderBrush = Brushes.White;
        }

        private void txtPassQuotex_MouseLeave(object sender, MouseEventArgs e)
        {
            PassQuotex.BorderBrush = Brushes.Gray;
        }
        private void Dostup_MouseEnter(object sender, MouseEventArgs e)
        {
            Dostup.Background = Brushes.Black;
        }

        private void BtnFile_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnFile.Background = Brushes.Black;
        }

        private void BtnFile_MouseLeave(object sender, MouseEventArgs e)
        {
            BtnFile.Background = new SolidColorBrush(Color.FromRgb(68, 75, 93));
        }

        private void BtnClose_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnClose.Background = Brushes.Red;
        }

        private void BtnClose_MouseLeave(object sender, MouseEventArgs e)
        {
            BtnClose.Background = Brushes.Transparent;
        }

        private void BtnHide_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnHide.Background = new SolidColorBrush(Color.FromRgb(68, 75, 93));
        }

        private void BtnHide_MouseLeave(object sender, MouseEventArgs e)
        {
            BtnHide.Background = Brushes.Transparent;
        }

        private void LoginQbot_MouseEnter(object sender, MouseEventArgs e)
        {
            LoginQbot.BorderBrush = Brushes.White;
        }

        private void LoginQbot_MouseLeave(object sender, MouseEventArgs e)
        {
            LoginQbot.BorderBrush = Brushes.Gray;
        }

        private void PassQbot_MouseEnter(object sender, MouseEventArgs e)
        {
            PassQbot.BorderBrush = Brushes.White;
        }

        private void PassQbot_MouseLeave(object sender, MouseEventArgs e)
        {
            PassQbot.BorderBrush = Brushes.Gray;
        }

        private void LoginQuotex_MouseEnter(object sender, MouseEventArgs e)
        {
            LoginQuotex.BorderBrush = Brushes.White;
        }

        private void LoginQuotex_MouseLeave_1(object sender, MouseEventArgs e)
        {
            LoginQuotex.BorderBrush = Brushes.Gray;
        }

        private void PassQuotex_MouseEnter(object sender, MouseEventArgs e)
        {
            PassQuotex.BorderBrush = Brushes.White;
        }

        private void PassQuotex_MouseLeave(object sender, MouseEventArgs e)
        {
            PassQuotex.BorderBrush = Brushes.Gray;
        }

        #endregion

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            var timer2 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0.2) };
            timer2.Start();
            timer2.Tick += (sender, args) =>
            {
                timer2.Stop();
                Application.Current.Shutdown();
            };
        }

        private void BtnHide_Click(object sender, RoutedEventArgs e)
        {
            var timer3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0.2) };
            timer3.Start();
            timer3.Tick += (sender, args) =>
            {
                timer3.Stop();
                this.Hide();
            };
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0.5) };
            timer1.Start();
            timer1.Tick += (sender, args) =>
            {
                timer1.Stop();
                if (Convert.ToString(BtnStart.Content) == "Запустить")
                {
                    BtnStart.Background = new SolidColorBrush(Color.FromRgb(226, 110, 97));
                    BtnStart.Content = "Остановить";
                }
                else
                {
                    BtnStart.Background = new SolidColorBrush(Color.FromRgb(76, 139, 244));
                    BtnStart.Content = "Запустить";
                }
            };
        }

        private void Dostup_MouseLeave(object sender, MouseEventArgs e)
        {
            Dostup.Background = new SolidColorBrush(Color.FromRgb(68, 75, 93));
        }

        private void BtnStart_MouseEnter(object sender, MouseEventArgs e)
        {

            if (Convert.ToString(BtnStart.Content) == "Запустить")
            {
                BtnStart.Background = new SolidColorBrush(Color.FromRgb(44, 153, 255));
            }
            else
            {
                BtnStart.Background = new SolidColorBrush(Color.FromRgb(255, 65, 43));
            }
        }

        private void BtnStart_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Convert.ToString(BtnStart.Content) == "Запустить")
            {
                BtnStart.Background = new SolidColorBrush(Color.FromRgb(76, 139, 244));
            }
            else
            {
                BtnStart.Background = new SolidColorBrush(Color.FromRgb(226, 110, 97));
            }

        }
    }
}
