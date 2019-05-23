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

namespace ADO_NET_1
{
    /// <summary>
    /// Interaction logic for ConnectionSettings.xaml
    /// </summary>
    public partial class ConnectionSettings : Window
    {
        MainWindow w;
        public ConnectionSettings(MainWindow w)
        {
            InitializeComponent();
            this.w = w;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ChkBx.IsChecked == true)
            {
                App.ConnectionString = $"Data Source = {Data_Source};" +
                    $"Initial Catalog = {Initial_Catalog}; Integrated Security = True; Connect Timeout=5" ;
            }
            else
            {
                App.ConnectionString = $"Data Source = {Data_Source};" +
                    $" Initial Catalog = {Initial_Catalog}; User Id = {User_Id}; Password = {Password_}; Connect Timeout=5";
            }
            w.Window_Loaded();
            w.Show();
            Close();
        }
    }
}
