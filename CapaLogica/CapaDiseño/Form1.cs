using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaDiseño
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proceso ObjTraer = new Proceso();
            ObjTraer.var1 = Convert.ToDouble(txtVar1.Text);
            ObjTraer.var2 = Convert.ToDouble(txtVar2.Text);
            ObjTraer.Resta();
            txtRes.Text = Convert.ToString(ObjTraer.var3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Proceso ObjTraer = new Proceso();
            ObjTraer.var1 = Convert.ToDouble(txtVar1.Text);
            ObjTraer.var2 = Convert.ToDouble(txtVar2.Text);
            ObjTraer.Suma();
            txtRes.Text = Convert.ToString(ObjTraer.var3);

        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            Proceso ObjTraer = new Proceso();
            ObjTraer.var1 = Convert.ToDouble(txtVar1.Text);
            ObjTraer.var2 = Convert.ToDouble(txtVar2.Text);
            ObjTraer.Multi();
            txtRes.Text = Convert.ToString(ObjTraer.var3);
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            Proceso ObjTraer = new Proceso();
            ObjTraer.var1 = Convert.ToDouble(txtVar1.Text);
            ObjTraer.var2 = Convert.ToDouble(txtVar2.Text);
            if (ObjTraer.var2 == 0)
            {
                MessageBox.Show("NO SE PUEDE DIVIDIR ENTRE 0");
            }
            else
            {
                ObjTraer.Divide();
                txtRes.Text = Convert.ToString(ObjTraer.var3);
            }
        }
    }
}
