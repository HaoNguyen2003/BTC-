using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managercoffee
{
    public partial class Form1 : Form
    {
        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        datacoffeeDataContext db = new datacoffeeDataContext();
        public Form1()
        {

            InitializeComponent();
            coffeeBindingSource1.DataSource = db.coffees;
            coffeeBindingSource1.EndEdit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCFDataSet.coffee' table. You can move, or remove it, as needed.
            this.coffeeTableAdapter.Fill(this.QLCFDataSet.coffee);
            this.pictureBox1.Image = Image.FromFile(projectPath + "\\data\\h0.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public void displayData()
        {
            this.coffeeBindingSource1.DataSource = (from coffee in db.coffees select coffee);
        }
        private void btn_LoadSQL_Click(object sender, EventArgs e)
        {
           this.displayData();
            this.dataGridView1.DataSource = this.coffeeBindingSource1;
        }
    }
}
