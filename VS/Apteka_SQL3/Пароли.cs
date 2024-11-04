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
    public partial class Пароли : Form
    {
        public Пароли()
        {
            InitializeComponent();
        }

        private void Пароли_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптека_БыковDataSet1.Пароли". При необходимости она может быть перемещена или удалена.
            this.паролиTableAdapter.Fill(this.аптека_БыковDataSet1.Пароли);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.паролиTableAdapter.Update(this.аптека_БыковDataSet1.Пароли);
        }
    }
}
