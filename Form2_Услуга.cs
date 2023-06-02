using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1EF
{
    public partial class Form2_Услуга : Form
    {

        Photo_salonEntities db = new Photo_salonEntities();
        
        public Form2_Услуга()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Услуга.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Услуга услуга = new Услуга();
            услуга.Наименование_услуги = textBox1.Text;
            услуга.Описание = textBox2.Text;
            услуга.Цена = Convert.ToInt32(textBox3.Text);
            db.Услуга.Add(услуга);
            db.SaveChanges();
            MessageBox.Show("Запись добавлена!");
            dataGridView1.DataSource = db.Услуга.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Услуга услуга = db.Услуга.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код_услуги"].Value));
            услуга.Наименование_услуги = textBox1.Text;
            услуга.Описание = textBox2.Text;
            услуга.Цена = Convert.ToInt32(textBox3.Text);
            db.SaveChanges();
            MessageBox.Show("Запись обновлена!");
            dataGridView1.DataSource = db.Услуга.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Photo_salonEntities db = new Photo_salonEntities();
            Услуга услуга = db.Услуга.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код_услуги"].Value));
            if (услуга != null)
            {
                db.Услуга.Remove(услуга);
            }
            db.SaveChanges();
            dataGridView1.DataSource = db.Услуга.ToList();
            MessageBox.Show("Запись удалена!");
        }
    }
}
