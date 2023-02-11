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

namespace Piedra_Papel_Tijeras_00
{
    /// <summary>
    /// Interaction logic for deleteUser.xaml
    /// </summary>
    public partial class deleteUser : Window
    {
        public deleteUser()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            sqlConsulta con = new sqlConsulta();
            con.SqlDeleteByUser(DelUserBox.Text, DelPassBox.Text);
        }
    }
}
