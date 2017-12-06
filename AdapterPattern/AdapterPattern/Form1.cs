using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPattern
{
    public partial class AdapterForm : Form
    {
        Target target = new Adapter();

        public AdapterForm()
        {
            InitializeComponent();
        }

        private void FConvertButton_Click(object sender, EventArgs e)
        {
            double[] FArray = new double[5];
            double[] CArray = new double[5];

            FArray[0] = int.Parse(FBox1.Text);
            FArray[1] = int.Parse(FBox2.Text);
            FArray[2] = int.Parse(FBox3.Text);
            FArray[3] = int.Parse(FBox4.Text);
            FArray[4] = int.Parse(FBox5.Text);

            CArray = target.ConvertFArray(FArray);

            CBox1.Text = CArray[0].ToString();
            CBox2.Text = CArray[1].ToString();
            CBox3.Text = CArray[2].ToString();
            CBox4.Text = CArray[3].ToString();
            CBox5.Text = CArray[4].ToString();
        }

        private void CConvertButton_Click(object sender, EventArgs e)
        {
            double[] CArray = new double[5];
            double[] FArray = new double[5];

            CArray[0] = int.Parse(CBox1.Text);
            CArray[1] = int.Parse(CBox2.Text);
            CArray[2] = int.Parse(CBox3.Text);
            CArray[3] = int.Parse(CBox4.Text);
            CArray[4] = int.Parse(CBox5.Text);

            FArray = target.ConvertCArray(CArray);

            FBox1.Text = FArray[0].ToString();
            FBox2.Text = FArray[1].ToString();
            FBox3.Text = FArray[2].ToString();
            FBox4.Text = FArray[3].ToString();
            FBox5.Text = FArray[4].ToString();
        }
    }
}
