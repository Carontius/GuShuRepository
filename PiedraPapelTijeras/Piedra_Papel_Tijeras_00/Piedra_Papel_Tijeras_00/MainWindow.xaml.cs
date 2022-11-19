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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //DB management
        string datasource = "Datasource=localhost;Port=3306;username=root;Password=;Database=apuestas_db";

        MySqlConnection conexion;

        

        public MainWindow()
        {
            InitializeComponent();
            conexion = new MySqlConnection(datasource);
            conexion.Open();
            Loaded += MyWindow_Loaded;
        }

        private void MyWindow_Loaded (object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Login());

        }


    }


    class User
    {
        string loginUser;
        string loginPassword;
        string nombre;
        string apellido;
        string alias;
        string mail;
        int puntos;

        public User(string loginUser, string loginPassword, string nombre="", string apellido = "", string alias = "", string mail = "", int puntos=0)
        {
            this.loginUser = loginUser;
            this.loginPassword = loginPassword;
            this.nombre = nombre;
            this.apellido = apellido;
            this.alias = alias;
            this.mail = mail;
            this.puntos = puntos;
        }

        public string LoginUser { get => loginUser; set => loginUser = value; }
        public string LoginPassword { get => loginPassword; set => loginPassword = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Alias { get => alias; set => alias = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Puntos { get => puntos; set => puntos = value; }
    }




}
