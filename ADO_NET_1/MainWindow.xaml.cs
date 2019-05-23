using System;
using System.Data.SqlClient;
using System.Windows;

namespace ADO_NET_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Window_Loaded();
        }

        private void Window_Loaded()
        {
            try
            {
                SqlConnection con = new SqlConnection(App.ConnectionString);
                con.Open();
                MessageBox.Show("App connected Sql Server successfully","Database Connection",
                    MessageBoxButton.OK,MessageBoxImage.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nFill the gaps with valid settings", "Database Conncetion Error",
                    MessageBoxButton.OK, MessageBoxImage.Error); 
                var SqlConnectionSettings = new ConnectionSettings(this);
                Hide();
                SqlConnectionSettings.Show();
            }
        }
    }
}
