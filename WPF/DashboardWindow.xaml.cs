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

namespace WPF
{
    /// <summary>
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        public DashboardWindow()
        {
            InitializeComponent();
            CategoryUserControl userControl = new CategoryUserControl();
            AddUserControl(userControl);
        }
        private void AddUserControl(UserControl userControl)
        {
            Panel1.Children.Clear();
            Panel1.Children.Add(userControl);
        }
        private void AddUserControl2(UserControl userControl)
        {
            Panel2.Children.Clear();
            Panel2.Children.Add(userControl);
        }

        private void Ticketbtn_Click(object sender, RoutedEventArgs e)
        {
            TicjetUserControl userControl = new TicjetUserControl();
            AddUserControl2(userControl);
        }

        private void Categorybtn_Click(object sender, RoutedEventArgs e)
        {
            CategoryUserControl userControl = new CategoryUserControl();
            AddUserControl(userControl);
        }

        private void Humanbtn_Click(object sender, RoutedEventArgs e)
        {
            HumanUserControl userControl = new HumanUserControl();
            AddUserControl2(userControl);
        }
    }
}
