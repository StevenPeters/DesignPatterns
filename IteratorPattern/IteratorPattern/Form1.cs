using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IteratorPattern
{
    public partial class Form1 : Form
    {
        ConcreteAggregate GuestList = new ConcreteAggregate();
        Iterator GuestListIterator;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddGuestButton_Click(object sender, EventArgs e)
        {
            GuestList.AddGuest(AddGuestTextbox.Text);
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            GuestListIterator = GuestList.CreateIterator();
            AddGuestButton.Enabled = false;
            AddGuestTextbox.Enabled = false;
            IterateButton.Enabled = true;
            StartOverButton.Enabled = true;
            DoneButton.Enabled = false;
        }

        private void IterateButton_Click(object sender, EventArgs e)
        {
            if (!GuestListIterator.isDone())
            {
                GuestNameLabel.Text = GuestListIterator.Next();
            }
            else
            {
                GuestNameLabel.Text = GuestListIterator.CurrentItem();
            }
        }

        private void StartOverButton_Click(object sender, EventArgs e)
        {
            GuestNameLabel.Text = GuestListIterator.First();
        }

        private void AddGuestTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddGuestButton_Click(this, new EventArgs());
            }
        }
    }
}
