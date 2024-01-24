using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace IParkingClient
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static string LoadConnectionString(string id = "ParkingDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        SQLiteConnection con = new SQLiteConnection(LoadConnectionString());
    }
}
