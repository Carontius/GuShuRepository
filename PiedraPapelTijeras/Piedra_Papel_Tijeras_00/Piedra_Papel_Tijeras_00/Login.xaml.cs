using MySql.Data.MySqlClient;
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



namespace Piedra_Papel_Tijeras_00
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public  partial class Login : Page
    {
        
        string datasource = "Datasource=localhost;Port=3306;username=root;Password=;Database=apuestas_db";
        MySqlConnection conexion;

        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((userboxlog.Text != String.Empty) || (passboxlog.Text != String.Empty))
            {
                conexion = new MySqlConnection(datasource);
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand("select * from cliente_data where user='" + userboxlog.Text + "' and pass='"+ passboxlog.Text+"'", conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Welcome user \""+ userboxlog.Text.ToUpper() + "\". ");
                    string name = userboxlog.Text.ToUpper();
                    NavigationService.Navigate(new Play(name));
                    
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ");
                }
            }
        }
                void RegisBtn_Click(object sender, RoutedEventArgs e)
                {
                    NavigationService.Navigate(new Registro());
                }

                void DeleteBtn_Click(object sender, RoutedEventArgs e)
                {
                    deleteUser dlt=new deleteUser();
                    dlt.ShowDialog();
                }
            }
        }
    

