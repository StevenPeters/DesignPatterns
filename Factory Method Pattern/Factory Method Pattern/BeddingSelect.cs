using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Method_Pattern
{
    public partial class BeddingSelect : Form
    {
        private BeddingSelector beddingNeeded;
        private List<Bedding> beddingList;

        public BeddingSelect()
        {
            InitializeComponent();
        }

        private void TwinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            beddingNeeded = new TwinBeddingSelctor();
            beddingList = beddingNeeded.GetBedding();
            BeddingListView.Items.Clear();
            foreach (Bedding beddingItem in beddingList)
            {
                BeddingListView.Items.Add(beddingItem.getName());
            }
        }

        private void XLTwinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            beddingNeeded = new XLTwinBeddingSelctor();
            beddingList = beddingNeeded.GetBedding();
            BeddingListView.Items.Clear();
            foreach (Bedding beddingItem in beddingList)
            {
                BeddingListView.Items.Add(beddingItem.getName());
            }
        }

        private void FullRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            beddingNeeded = new FullBeddingSelctor();
            beddingList = beddingNeeded.GetBedding();
            BeddingListView.Items.Clear();
            foreach (Bedding beddingItem in beddingList)
            {
                BeddingListView.Items.Add(beddingItem.getName());
            }
        }

        private void QueenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            beddingNeeded = new QueenBeddingSelctor();
            beddingList = beddingNeeded.GetBedding();
            BeddingListView.Items.Clear();
            foreach (Bedding beddingItem in beddingList)
            {
                BeddingListView.Items.Add(beddingItem.getName());
            }
        }

        private void KingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            beddingNeeded = new KingBeddingSelctor();
            beddingList = beddingNeeded.GetBedding();
            BeddingListView.Items.Clear();
            foreach (Bedding beddingItem in beddingList)
            {
                BeddingListView.Items.Add(beddingItem.getName());
            }
        }
    }
}