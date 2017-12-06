using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy_Pattern
{
    public partial class StrategyForm : Form
    {
        private List<TextBox> numBoxes = new List<TextBox>();
        private static int SIZE = 10;

        public StrategyForm()
        {
            InitializeComponent();

            numBoxes.Add(numBox1);
            numBoxes.Add(numBox2);
            numBoxes.Add(numBox3);
            numBoxes.Add(numBox4);
            numBoxes.Add(numBox5);
            numBoxes.Add(numBox6);
            numBoxes.Add(numBox7);
            numBoxes.Add(numBox8);
            numBoxes.Add(numBox9);
            numBoxes.Add(numBox10);
        }

        private void InsertionSort_Click(object sender, EventArgs e)
        {
            int[] array = new int[SIZE];
            int i = 0;

            foreach (TextBox numBox in numBoxes)
            {
                array[i] = int.Parse(numBox.Text);
                i++;
            }

            Strategy insertion = new InsertionSort();
            array = insertion.Sort(array, SIZE);

            i = 0;

            foreach (TextBox numBox in numBoxes)
            {
                numBox.Text = array[i].ToString();
                i++;
            }
        }

        private void MergeSort_Click(object sender, EventArgs e)
        {
            int[] array = new int[SIZE];
            int i = 0;

            foreach (TextBox numBox in numBoxes)
            {
                array[i] = int.Parse(numBox.Text);
                i++;
            }

            Strategy merge = new RInsertionSort();
            array = merge.Sort(array, SIZE);

            i = 0;

            foreach (TextBox numBox in numBoxes)
            {
                numBox.Text = array[i].ToString();
                i++;
            }
        }
    }
}
