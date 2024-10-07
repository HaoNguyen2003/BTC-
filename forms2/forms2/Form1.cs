using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms2
{
    public partial class fcmm : Form
    {
        public fcmm()
        {
            InitializeComponent();
        }

        private void vaoform(object sender, EventArgs e)
        {
            label1.Text = "da vao form";
        }

        private void vaoLable(object sender, EventArgs e)
        {
            label1.Text = "da vao lable";
        }

        private void rakhoichuongtrinh(object sender, EventArgs e)
        {
            label1.Text = "ra khoi chuong trinh";
        }

        private void clickonbutton1(object sender, EventArgs e)
        {
          Label labeladd=new Label();
          labeladd.Size = new Size(30, 30);
          this.Controls.Add(labeladd);
        }
    }
}
