using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
            if (Holder.Prava != 1)
            {
                button4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Аптека newForm = new Аптека();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Лекарство newForm = new Лекарство();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Производитель newForm = new Производитель();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Пароли newForm = new Пароли();
            newForm.Show();
        }
    }
}
