using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomchitDormitory
{
    public partial class SelectRenter : Form
    {
        public SelectRenter()
        {
            InitializeComponent();
        }

        private void SelectRenter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'selectSubRenters.Renters' table. You can move, or remove it, as needed.
            this.rentersTableAdapter1.Fill(this.selectSubRenters.Renters);
            // TODO: This line of code loads data into the 'somchitDataSet.Renters' table. You can move, or remove it, as needed.
            this.rentersTableAdapter.Fill(this.somchitDataSet.Renters);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Renters.rid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                this.Close();
            }
        }
    }
}
