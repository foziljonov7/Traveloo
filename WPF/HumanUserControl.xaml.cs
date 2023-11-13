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
    /// Interaction logic for HumanUserControl.xaml
    /// </summary>
    public partial class HumanUserControl : UserControl
    {
        public HumanUserControl()
        {
            InitializeComponent();
        }
        private void AddUserControl(UserControl userControl)
        {
            ControlPanel.Children.Clear();
            ControlPanel.Children.Add(userControl);
        }
        private void CreateHumanBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateHumanControl userControl = new CreateHumanControl();
            AddUserControl(userControl);
        }

        private void EditHumanBtn_Click(object sender, RoutedEventArgs e)
        {
            EditHumanControl userControl = new EditHumanControl();
            AddUserControl(userControl);
        }

        private void RemoveHumanBtn_Click(object sender, RoutedEventArgs e)
        {
            RemoveUserControl userControl = new RemoveUserControl();
            AddUserControl(userControl);
        }
    }
}
