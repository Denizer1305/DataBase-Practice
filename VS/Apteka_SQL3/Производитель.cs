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
    public partial class Производитель : Form
    {
        public Производитель()
        {
            InitializeComponent();
        }

        private void Производитель_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптека_БыковDataSet.Производитель". При необходимости она может быть перемещена или удалена.
            this.производительTableAdapter.Fill(this.аптека_БыковDataSet.Производитель);
            if (Holder.Prava != 1)
            {
                dataGridView1.ReadOnly = true;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.производительTableAdapter.Update(this.аптека_БыковDataSet.Производитель);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                производительBindingSource.Filter = "[название_производителя] LIKE '" + textBox1.Text + "%'";
                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("Не найдено!");
                }
            }

            if (checkBox1.Checked)
            {
                производительBindingSource.Filter = "[юридический_адрес_страна] LIKE '" + textBox1.Text + "%'";
                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("Не найдено!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            производительBindingSource.Filter = string.Empty;
            textBox1.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;

        }
    }
}
