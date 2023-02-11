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
    internal class sqlConsulta
    {
            string datasource = "Datasource=localhost;Port=3306;username=root;Password=;Database=apuestas_db";
            MySqlConnection conexion;





        public void SqlInsert(string user, string pass, string fname="", string lname="",int points=500 ,string email="")
        {
            conexion = new MySqlConnection(datasource);
            conexion.Open();
            
            string carga = "INSERT INTO cliente_data(user,pass,Nombre,Apellido,points,Mail) Values(@user,@pass,@Fname,@Lname,@points,@mail)";
            MySqlCommand insertar = new MySqlCommand(carga, conexion);
            insertar.Parameters.Add(new MySqlParameter("@user", user));
            insertar.Parameters.Add(new MySqlParameter("@pass", pass));
            insertar.Parameters.Add(new MySqlParameter("@Fname", fname));
            insertar.Parameters.Add(new MySqlParameter("@Lname", lname));
            insertar.Parameters.Add(new MySqlParameter("@points", points));
            insertar.Parameters.Add(new MySqlParameter("@mail", email));

            insertar.ExecuteNonQuery();
            conexion.Close();
        }

        public void SqlDeleteByUser(string user, string pass)
        {
            conexion = new MySqlConnection(datasource);
            conexion.Open();

            string carga = "DELETE FROM cliente_data WHERE user = @user AND pass = @pass";
            MySqlCommand insertar = new MySqlCommand(carga, conexion);
            insertar.Parameters.Add(new MySqlParameter("@user", user));
            insertar.Parameters.Add(new MySqlParameter("@pass", pass));
            
         

            insertar.ExecuteNonQuery();
           
            //  TO DO // deberia servir para filtrar resultados negativos
            if (insertar.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("usuario o password incorrectos");
            }

            else if (insertar.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("usuario borrado");
            }

            else
            {
                MessageBox.Show("ocurrio algun error; dev revisar \"SqlDeleteByUser\" ");

            }
            conexion.Close();
           
        }

        public void SqlUpdate(string user, string pass, string fname = "", string lname = "", string email = "")
        {
            conexion = new MySqlConnection(datasource);
            conexion.Open();

            string carga = "UPDATE cliente_data SET(user,pass,Nombre,Apellido,Mail) Values(@user,@pass,@Fname,@Lname,@mail) WHERE user = @user AND pass = @pass";
            MySqlCommand insertar = new MySqlCommand(carga, conexion);
            insertar.Parameters.Add(new MySqlParameter("@user", user));
            insertar.Parameters.Add(new MySqlParameter("@pass", pass));
            insertar.Parameters.Add(new MySqlParameter("@Fname", fname));
            insertar.Parameters.Add(new MySqlParameter("@Lname", lname));
            insertar.Parameters.Add(new MySqlParameter("@mail", email));


            insertar.ExecuteNonQuery();
            //  TO DO // deberia servir para filtrar resultados negativos
            if (insertar.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("usuario o password incorrectos");
            }

            else if (insertar.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("usuario borrado");
            }

            else
            {
                MessageBox.Show("ocurrio algun error; dev revisar \"SqlUpdate\" ");

            }
            conexion.Close();
        
        }

        public void SqlSelectUser(string user)
        {
            conexion = new MySqlConnection(datasource);
            conexion.Open();
            
            string carga = "SELECT user FROM cliente_data WHERE user = @user";
            MySqlCommand insertar = new MySqlCommand(carga, conexion);
            insertar.Parameters.Add(new MySqlParameter("@user", user));
           

            insertar.ExecuteNonQuery();
            //  TO DO // deberia servir para filtrar resultados negativos
            if (insertar.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("usuario o password incorrectos");
            }

            else if (insertar.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("usuario borrado");
            }

            else
            {
                MessageBox.Show("ocurrio algun error; dev revisar \"SqlSelectUser\" ");

            }
            conexion.Close();


        }
   
    }
}
