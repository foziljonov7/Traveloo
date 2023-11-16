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

namespace WPF
{
    /// <summary>
    /// Interaction logic for TicjetUserControl.xaml
    /// </summary>
    public partial class TicjetUserControl : UserControl
    {
        public TicjetUserControl()
        {
            InitializeComponent();
        }
        private void AddUserControl(UserControl userControl)
        {
            UserPanel.Children.Clear();
            UserPanel.Children.Add(userControl);
        }

        private void CreateTicketBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateTicketUserControl userControl = new CreateTicketUserControl();
            AddUserControl(userControl);
        }
    }
}
