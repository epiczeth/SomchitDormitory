namespace SomchitDormitory
{
    partial class SelectRenter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.somchitDataSet = new SomchitDormitory.somchitDataSet();
            this.rentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentersTableAdapter = new SomchitDormitory.somchitDataSetTableAdapters.RentersTableAdapter();
            this.selectSubRenters = new SomchitDormitory.selectSubRenters();
            this.rentersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentersTableAdapter1 = new SomchitDormitory.selectSubRentersTableAdapters.RentersTableAdapter();
            this.renteridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namelastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.somchitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSubRenters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.renteridDataGridViewTextBoxColumn,
            this.namelastDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn1,
            this.sexDataGridViewTextBoxColumn1,
            this.occupationDataGridViewTextBoxColumn1,
            this.telDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.rentersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(533, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // somchitDataSet
            // 
            this.somchitDataSet.DataSetName = "somchitDataSet";
            this.somchitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentersBindingSource
            // 
            this.rentersBindingSource.DataMember = "Renters";
            this.rentersBindingSource.DataSource = this.somchitDataSet;
            // 
            // rentersTableAdapter
            // 
            this.rentersTableAdapter.ClearBeforeFill = true;
            // 
            // selectSubRenters
            // 
            this.selectSubRenters.DataSetName = "selectSubRenters";
            this.selectSubRenters.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentersBindingSource1
            // 
            this.rentersBindingSource1.DataMember = "Renters";
            this.rentersBindingSource1.DataSource = this.selectSubRenters;
            // 
            // rentersTableAdapter1
            // 
            this.rentersTableAdapter1.ClearBeforeFill = true;
            // 
            // renteridDataGridViewTextBoxColumn
            // 
            this.renteridDataGridViewTextBoxColumn.DataPropertyName = "renter_id";
            this.renteridDataGridViewTextBoxColumn.HeaderText = "รหัส";
            this.renteridDataGridViewTextBoxColumn.Name = "renteridDataGridViewTextBoxColumn";
            this.renteridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namelastDataGridViewTextBoxColumn
            // 
            this.namelastDataGridViewTextBoxColumn.DataPropertyName = "namelast";
            this.namelastDataGridViewTextBoxColumn.HeaderText = "ชื่อ - สกุล";
            this.namelastDataGridViewTextBoxColumn.Name = "namelastDataGridViewTextBoxColumn";
            this.namelastDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn1
            // 
            this.ageDataGridViewTextBoxColumn1.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn1.HeaderText = "อายุ";
            this.ageDataGridViewTextBoxColumn1.Name = "ageDataGridViewTextBoxColumn1";
            this.ageDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn1
            // 
            this.sexDataGridViewTextBoxColumn1.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn1.HeaderText = "เพศ";
            this.sexDataGridViewTextBoxColumn1.Name = "sexDataGridViewTextBoxColumn1";
            this.sexDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // occupationDataGridViewTextBoxColumn1
            // 
            this.occupationDataGridViewTextBoxColumn1.DataPropertyName = "occupation";
            this.occupationDataGridViewTextBoxColumn1.HeaderText = "อาชีพ";
            this.occupationDataGridViewTextBoxColumn1.Name = "occupationDataGridViewTextBoxColumn1";
            this.occupationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn1
            // 
            this.telDataGridViewTextBoxColumn1.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn1.HeaderText = "เบอร์โทร";
            this.telDataGridViewTextBoxColumn1.Name = "telDataGridViewTextBoxColumn1";
            this.telDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // SelectRenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 233);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectRenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ดับเบิ้ลคลิกเพื่อเลือก";
            this.Load += new System.EventHandler(this.SelectRenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.somchitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSubRenters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private somchitDataSet somchitDataSet;
        private System.Windows.Forms.BindingSource rentersBindingSource;
        private somchitDataSetTableAdapters.RentersTableAdapter rentersTableAdapter;
        private selectSubRenters selectSubRenters;
        private System.Windows.Forms.BindingSource rentersBindingSource1;
        private selectSubRentersTableAdapters.RentersTableAdapter rentersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn renteridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namelastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn1;
    }
}