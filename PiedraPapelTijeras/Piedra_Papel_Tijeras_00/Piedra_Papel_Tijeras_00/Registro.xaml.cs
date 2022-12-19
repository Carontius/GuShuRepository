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
using MySql.Data.MySqlClient;

namespace Piedra_Papel_Tijeras_00
{
    /// <summary>
    /// Interaction logic for Registro.xaml
    /// </summary>
    public partial class Registro : Page
    {
        string datasource = "Datasource=localhost;Port=3306;username=root;Password=;Database=apuestas_db";

        MySqlConnection conexion;
        public Registro()
        {
            InitializeComponent();
            conexion = new MySqlConnection(datasource);
            conexion.Open();
        }

       
        private void BckButtom_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login());
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((userbox.Text != String.Empty) || (passbox.Text != String.Empty))
            {
                
                MySqlCommand cmd = new MySqlCommand("select * from cliente_data where user='" + userbox.Text + "'", conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("El usuario ya existe intente con un nuevo alias ");
                }
                else
                {
                    dr.Close();
                    int bonuspoints = 500;
                    sqlConsulta sqlConsulta = new sqlConsulta();
                    sqlConsulta.SqlInsert(userbox.Text, passbox.Text, fnamebox.Text, lnamebox.Text, bonuspoints, emailbox.Text);

                }


            }

            

        }
        

        
    }
}
