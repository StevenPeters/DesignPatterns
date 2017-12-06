using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite_Pattern
{
    public partial class CompositeForm : Form
    {
        public CompositeForm()
        {
            InitializeComponent();

            Composite root = new Composite("Inventory");
            root.Add(new Leaf("Food"));
            root.Add(new Leaf("Sword"));
            Composite bowAndArrows = new Composite("Bow and Arrows");
            bowAndArrows.Add(new Leaf("Bow"));
            bowAndArrows.Add(new Leaf("Arrows"));
            root.Add(bowAndArrows);

            foreach (string s in root.Display(0))
            {
                CompositeListBox.Items.Add(s);
            }
        }
    }
}
