using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1EF
{
    public partial class Form2_формы : Form
    {
        public Form2_формы()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2_Клиент form2_Клиент = new Form2_Клиент();
            form2_Клиент.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2_Фотограф form2_Фотограф = new Form2_Фотограф();
            form2_Фотограф.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2_Услуга form2_Услуга = new Form2_Услуга();
            form2_Услуга.Show();
        }
    }
}
