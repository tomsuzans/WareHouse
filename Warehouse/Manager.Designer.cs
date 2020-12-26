namespace eksamens
{
    partial class Manager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.precesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.noliktavaDataSet = new eksamens.noliktavaDataSet();
            this.precesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aptiekaDataSet1 = new eksamens.noliktava1();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.aptiekaDataSet = new eksamens.noliktava();
            this.precesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.precesTableAdapter = new eksamens.aptiekaDataSetTableAdapters.PrecesTableAdapter();
            this.precesTableAdapter1 = new eksamens.aptiekaDataSet1TableAdapters.PrecesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.noliktavaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.precesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.precesTableAdapter2 = new eksamens.noliktavaDataSetTableAdapters.PrecesTableAdapter();
            this.precesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nosaukums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daudzums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptiekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptiekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nosaukums,
            this.Tips,
            this.Daudzums,
            this.Cena});
            this.dataGridView1.DataSource = this.precesBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(36, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1231, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // precesBindingSource4
            // 
            this.precesBindingSource4.DataMember = "Preces";
            this.precesBindingSource4.DataSource = this.noliktavaDataSet;
            // 
            // noliktavaDataSet
            // 
            this.noliktavaDataSet.DataSetName = "noliktavaDataSet";
            this.noliktavaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // precesBindingSource1
            // 
            this.precesBindingSource1.DataMember = "Preces";
            this.precesBindingSource1.DataSource = this.aptiekaDataSet1;
            // 
            // aptiekaDataSet1
            // 
            this.aptiekaDataSet1.DataSetName = "aptiekaDataSet1";
            this.aptiekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 471);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(228, 471);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(307, 471);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pārdot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aptiekaDataSet
            // 
            this.aptiekaDataSet.DataSetName = "aptiekaDataSet";
            this.aptiekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // precesBindingSource
            // 
            this.precesBindingSource.DataMember = "Preces";
            this.precesBindingSource.DataSource = this.aptiekaDataSet;
            // 
            // precesTableAdapter
            // 
            this.precesTableAdapter.ClearBeforeFill = true;
            // 
            // precesTableAdapter1
            // 
            this.precesTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 453);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Daudzums";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 453);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Klients";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 470);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 453);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prece";
            // 
            // noliktavaDataSetBindingSource
            // 
            this.noliktavaDataSetBindingSource.DataSource = this.noliktavaDataSet;
            this.noliktavaDataSetBindingSource.Position = 0;
            // 
            // precesBindingSource2
            // 
            this.precesBindingSource2.DataMember = "Preces";
            this.precesBindingSource2.DataSource = this.noliktavaDataSetBindingSource;
            // 
            // precesTableAdapter2
            // 
            this.precesTableAdapter2.ClearBeforeFill = true;
            // 
            // precesBindingSource3
            // 
            this.precesBindingSource3.DataMember = "Preces";
            this.precesBindingSource3.DataSource = this.noliktavaDataSet;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(11, 286);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1, 13);
            this.textBox1.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 60.9137F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nosaukums
            // 
            this.Nosaukums.DataPropertyName = "Nosaukums";
            this.Nosaukums.FillWeight = 144.0534F;
            this.Nosaukums.HeaderText = "Nosaukums";
            this.Nosaukums.MinimumWidth = 6;
            this.Nosaukums.Name = "Nosaukums";
            this.Nosaukums.ReadOnly = true;
            // 
            // Tips
            // 
            this.Tips.DataPropertyName = "Tips";
            this.Tips.FillWeight = 144.0534F;
            this.Tips.HeaderText = "Tips";
            this.Tips.MinimumWidth = 6;
            this.Tips.Name = "Tips";
            this.Tips.ReadOnly = true;
            // 
            // Daudzums
            // 
            this.Daudzums.DataPropertyName = "Daudzums";
            this.Daudzums.FillWeight = 79.93713F;
            this.Daudzums.HeaderText = "Daudzums";
            this.Daudzums.MinimumWidth = 6;
            this.Daudzums.Name = "Daudzums";
            this.Daudzums.ReadOnly = true;
            // 
            // Cena
            // 
            this.Cena.DataPropertyName = "Cena";
            this.Cena.FillWeight = 71.0424F;
            this.Cena.HeaderText = "Cena";
            this.Cena.MinimumWidth = 6;
            this.Cena.Name = "Cena";
            this.Cena.ReadOnly = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 520);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parzinis";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptiekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptiekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private noliktava aptiekaDataSet;
        private System.Windows.Forms.BindingSource precesBindingSource;
        private aptiekaDataSetTableAdapters.PrecesTableAdapter precesTableAdapter;
        private noliktava1 aptiekaDataSet1;
        private System.Windows.Forms.BindingSource precesBindingSource1;
        private aptiekaDataSet1TableAdapters.PrecesTableAdapter precesTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource noliktavaDataSetBindingSource;
        private noliktavaDataSet noliktavaDataSet;
        private System.Windows.Forms.BindingSource precesBindingSource2;
        private noliktavaDataSetTableAdapters.PrecesTableAdapter precesTableAdapter2;
        private System.Windows.Forms.BindingSource precesBindingSource3;
        private System.Windows.Forms.BindingSource precesBindingSource4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nosaukums;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tips;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daudzums;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
    }
}