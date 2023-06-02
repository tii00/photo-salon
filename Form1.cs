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
    public partial class Form1 : Form
    {

        Photo_salonEntities db = new Photo_salonEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2_формы form2_Формы = new Form2_формы();
            form2_Формы.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
