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
        }
        private void AddUserControl(UserControl userControl)
        {
            Panel1.Children.Clear();
            Panel1.Children.Add(userControl);
        }

        private void Ticketbtn_Click(object sender, RoutedEventArgs e)
        {
            TicketUserControl userControl = new TicketUserControl();
            AddUserControl(userControl);
        }
    }
}
