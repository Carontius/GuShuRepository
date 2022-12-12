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

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            //User registryobject = new User(UserNameBlock.Text, UserPassBlock.Text, FName.Text, LName.Text, alias.Text, Mail.Text);
            string carga = "INSERT INTO cliente_data(user,pass,Fname,Lname,mail,alias) Values(@user,@pass,@Fname,@Lname,@mail,@alias)";
            MySqlCommand insertar = new MySqlCommand(carga, conexion);
            insertar.Parameters.Add(new MySqlParameter("@user", userbox.Text));
            insertar.Parameters.Add(new MySqlParameter("@pass", passbox.Text));
            insertar.Parameters.Add(new MySqlParameter("@Fname", fnamebox.Text));
            insertar.Parameters.Add(new MySqlParameter("@Lname", lnamebox.Text));
            insertar.Parameters.Add(new MySqlParameter("@mail", emailbox.Text));
            insertar.Parameters.Add(new MySqlParameter("@alias", alias.Text));

            insertar.ExecuteNonQuery();
            MessageBox.Show("carga realizada");



        }

        private void BckButtom_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login());
        }
    }
}
