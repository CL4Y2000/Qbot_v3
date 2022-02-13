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
using System.Windows.Threading;

namespace Qbot_v3
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
        #region mouseEnter/mouseLeave

        private void txtDomen_MouseEnter(object sender, MouseEventArgs e)
        {
            DQuotex.BorderBrush = Brushes.White;
        }

        private void txtDomen_MouseLeave(object sender, MouseEventArgs e)
        {
            DQuotex.BorderBrush = Brushes.Gray;
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

        private void DQuotex_MouseEnter(object sender, MouseEventArgs e)
        {
            DQuotex.BorderBrush = Brushes.White;
        }

        private void DQuotex_MouseLeave(object sender, MouseEventArgs e)
        {
            DQuotex.BorderBrush = Brushes.Gray;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0.2) };
            timer1.Start();
            timer1.Tick += (sender, args) =>
            {
                timer1.Stop();
                Application.Current.Shutdown();
            };
        }

        private void BtnHide_Click(object sender, RoutedEventArgs e)
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0.2) };
            timer.Start();
            timer.Tick += (sender, args) =>
            {
                timer.Stop();
                Hide();
            };

        }

        #endregion

        private void BtnDalee_Click(object sender, RoutedEventArgs e)
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0.4) };
            timer.Start();
            timer.Tick += (sender, args) =>
            {
                timer.Stop();
                Hide();
                Window2 window2 = new Window2();
                window2.Show();
            };

        }

        private void BtnDalee_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnDalee.Background = new SolidColorBrush(Color.FromRgb(44, 153, 255));
        }

        private void BtnDalee_MouseLeave(object sender, MouseEventArgs e)
        {
            BtnDalee.Background = new SolidColorBrush(Color.FromRgb(76, 139, 244));
        }
    }
}
