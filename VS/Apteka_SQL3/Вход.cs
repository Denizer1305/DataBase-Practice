using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{

    public partial class Вход : Form
    {

        public Вход()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Holder.Login = textBox1.Text;
            Holder.Password = textBox2.Text;
            Holder.Prava = 1;
            string connectstring = "Data source = DENISKA; Initial Catalog = Аптека_Быков; Integrated Security = True";
            SqlConnection myConnection = new SqlConnection(connectstring);
            myConnection.Open();
            string query = "SELECT count(*) from Пароли where логин = @login and пароль = @password";
            string query2 = "SELECT права from Пароли where логин = @login and пароль = @password";
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlCommand command1 = new SqlCommand(query2, myConnection);
            SqlParameter nameParam1 = new SqlParameter("@login", textBox1.Text);
            command.Parameters.Add(nameParam1);
            SqlParameter nameParam2 = new SqlParameter("@password", textBox2.Text);                                  
            command.Parameters.Add(nameParam2);
            command1.Parameters.Add(new SqlParameter("@login", textBox1.Text));
            command1.Parameters.Add(new SqlParameter("@password", textBox2.Text));
            command.CommandText = query;
            Holder.Prava = Convert.ToInt32(command1.ExecuteScalar());
            int k = Convert.ToInt32(command.ExecuteScalar());
            if (k != 0)
            {
                label3.Visible = false;
                Меню newForm = new Меню();
                newForm.Show();
            }
            else
            {
                label3.Visible = true;
            }
            myConnection.Close();
        }

    }
    public class Holder
    {
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static int Prava { get; set; }
    }
}
