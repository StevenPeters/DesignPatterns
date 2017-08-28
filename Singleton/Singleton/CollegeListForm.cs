using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeList
{
    public partial class CollegeListForm : Form
    {
        public CollegeListForm()
        {
            InitializeComponent();
        }

        private void ItemAdd_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = null;

            if (ItemVehicle.Checked)
            {
                VehicleItem.CreateInstance(ItemName.Text);
                if (CollegeListView.Items.Count != 0)
                {
                    if (CollegeListView.FindItemWithText(VehicleItem.GetName(), true, 0) == null)
                    {
                        newItem = new ListViewItem(VehicleItem.GetName());
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    newItem = new ListViewItem(VehicleItem.GetName());
                }

            }
            else if (ItemDorm.Checked)
            {
                DormItem newDormItem = new DormItem(ItemName.Text);
                newItem = new ListViewItem(newDormItem.GetName());
            }
            else if (ItemClass.Checked)
            {
                ClassItem newClassItem = new ClassItem(ItemName.Text);
                newItem = new ListViewItem(newClassItem.GetName());
            }
            else
            {
                return;
            }

            CollegeListView.Items.Add(newItem);
        }

        private void ItemRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemRemove in CollegeListView.SelectedItems)
            {
                CollegeListView.Items.Remove(itemRemove);
            }
        }
    }
}
