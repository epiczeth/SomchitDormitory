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
    public partial class Renters : Form
    {
        public Renters()
        {
            InitializeComponent();
        }

        public static string rid = "";
        private void rentersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rentersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.somchitDataSet);

        }

        private void rentersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.rentersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.somchitDataSet);

        }

        private void Renters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'somchitDataSet.Renters' table. You can move, or remove it, as needed.
            this.rentersTableAdapter.Fill(this.somchitDataSet.Renters);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private bool Validator()
        {
            if (lblrid.Text == "" || txtname.Text == "" || txtage.Text == "" || cbSex.Text == "" ||
                txtoccu.Text == "" || txttel.Text == "" || txtpid.Text == "" || txtissueplace.Text == ""
                || txthousenumber.Text == "" || txtmoo.Text == "" || txttambon.Text == "" || txtdistrict.Text == ""
            || txtprovince.Text == "" || txtpostalcode.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtpid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txthousenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtmoo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtpostalcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void selectRenter_Click(object sender, EventArgs e)
        {
            new SelectRenter().ShowDialog();
            lblrid.Text = rid;
            if (rid != "")
            {
                btnAdd.Enabled = false;
                DataTable dt = new SQL().GetDataTable("select * from Renters where renter_id=" + Convert.ToInt32(lblrid.Text) + "");
                foreach (DataRow row in dt.Rows)
                {
                    txtname.Text = row["namelast"].ToString();
                }
            }
        }
    }
}
