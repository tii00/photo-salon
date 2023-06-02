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
    public partial class Form2_Фотограф : Form
    {
        Photo_salonEntities db = new Photo_salonEntities();

        public Form2_Фотограф()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Фотограф.ToList();
        }



        // Добавить
        private void button1_Click(object sender, EventArgs e)
        {
            Photo_salonEntities db = new Photo_salonEntities();
            Фотограф фотограф = new Фотограф();
            фотограф.Фамилия = textBox1.Text;
            фотограф.Имя = textBox2.Text;
            фотограф.Отчество = textBox3.Text;
            фотограф.Стаж = textBox4.Text;
            фотограф.Опыт_работы = textBox5.Text;
            фотограф.Телефон = textBox6.Text;
            db.Фотограф.Add(фотограф);
            db.SaveChanges();
            MessageBox.Show("Запись добавлена!");
            dataGridView1.DataSource = db.Фотограф.ToList();
        }

        //Изменить
        private void button2_Click(object sender, EventArgs e)
        {
            Photo_salonEntities db = new Photo_salonEntities();
            Фотограф фотограф = db.Фотограф.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код_фотографа"].Value));
            фотограф.Фамилия = textBox1.Text;
            фотограф.Имя = textBox2.Text;
            фотограф.Отчество = textBox3.Text;
            фотограф.Стаж = textBox4.Text;
            фотограф.Опыт_работы = textBox5.Text;
            фотограф.Телефон = textBox6.Text;
            db.SaveChanges();
            MessageBox.Show("Запись обновлена!");
            dataGridView1.DataSource = db.Фотограф.ToList();
        }


        //Удалить
        private void button3_Click(object sender, EventArgs e)
        {
            Photo_salonEntities db = new Photo_salonEntities();
            Фотограф фотограф = db.Фотограф.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Код_фотографа"].Value));
            if (фотограф != null)
            {
                db.Фотограф.Remove(фотограф);
            }
            db.SaveChanges();
            dataGridView1.DataSource = db.Фотограф.ToList();
            MessageBox.Show("Запись удалена!");
        }
    }
}
