using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
using WPF.Models;

namespace WPF
{
    /// <summary>
    /// Interaction logic for HumanDataControl.xaml
    /// </summary>
    public partial class HumanDataControl : UserControl
    {
        HttpClient client = new HttpClient();
        public HumanDataControl()
        {
            client.BaseAddress = new Uri("https://localhost:7220/api");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            InitializeComponent();
            GetHumans();
        }
        public async void GetHumans()
        {
            var responce = await client.GetStringAsync("Human/GetHumans");
            if (responce is null)
                MessageBox.Show("Invalid operation!");
            dgHuman.DataContext = JsonConvert.DeserializeObject<List<Human>>(responce);
        }
    }
}
