using System.Windows;

namespace ADO_NET_1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
            public static string ConnectionString = System.Configuration.ConfigurationManager.
            ConnectionStrings["SqlCon"].ConnectionString;
    }
}
