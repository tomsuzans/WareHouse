namespace eksamens
{
    partial class Admin
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nosaukums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tips = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daudzums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosaukumsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daudzumsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.noliktavaDataSet = new eksamens.noliktavaDataSet();
            this.precesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aptiekaDataSet1 = new eksamens.noliktava1();
            this.precesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aptiekaDataSet = new eksamens.noliktava();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosaukumsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daudzumsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pardotsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pardotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.precesTableAdapter = new eksamens.aptiekaDataSetTableAdapters.PrecesTableAdapter();
            this.pardotsTableAdapter = new eksamens.aptiekaDataSetTableAdapters.PardotsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.precesTableAdapter1 = new eksamens.aptiekaDataSet1TableAdapters.PrecesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.precesTableAdapter2 = new eksamens.noliktavaDataSetTableAdapters.PrecesTableAdapter();
            this.pardotsTableAdapter1 = new eksamens.noliktavaDataSetTableAdapters.PardotsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptiekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptiekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pardotsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pardotsBindingSource)).BeginInit();
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
            this.Cena,
            this.iDDataGridViewTextBoxColumn1,
            this.nosaukumsDataGridViewTextBoxColumn1,
            this.tipsDataGridViewTextBoxColumn1,
            this.daudzumsDataGridViewTextBoxColumn1,
            this.cenaDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.precesBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(25, 47);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1356, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Nosaukums
            // 
            this.Nosaukums.DataPropertyName = "Nosaukums";
            this.Nosaukums.HeaderText = "Nosaukums";
            this.Nosaukums.MinimumWidth = 6;
            this.Nosaukums.Name = "Nosaukums";
            // 
            // Tips
            // 
            this.Tips.DataPropertyName = "Tips";
            this.Tips.HeaderText = "Tips";
            this.Tips.MinimumWidth = 6;
            this.Tips.Name = "Tips";
            // 
            // Daudzums
            // 
            this.Daudzums.DataPropertyName = "Daudzums";
            this.Daudzums.HeaderText = "Daudzums";
            this.Daudzums.MinimumWidth = 6;
            this.Daudzums.Name = "Daudzums";
            // 
            // Cena
            // 
            this.Cena.DataPropertyName = "Cena";
            this.Cena.HeaderText = "Cena";
            this.Cena.MinimumWidth = 6;
            this.Cena.Name = "Cena";
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // nosaukumsDataGridViewTextBoxColumn1
            // 
            this.nosaukumsDataGridViewTextBoxColumn1.DataPropertyName = "Nosaukums";
            this.nosaukumsDataGridViewTextBoxColumn1.HeaderText = "Nosaukums";
            this.nosaukumsDataGridViewTextBoxColumn1.Name = "nosaukumsDataGridViewTextBoxColumn1";
            // 
            // tipsDataGridViewTextBoxColumn1
            // 
            this.tipsDataGridViewTextBoxColumn1.DataPropertyName = "Tips";
            this.tipsDataGridViewTextBoxColumn1.HeaderText = "Tips";
            this.tipsDataGridViewTextBoxColumn1.Name = "tipsDataGridViewTextBoxColumn1";
            // 
            // daudzumsDataGridViewTextBoxColumn1
            // 
            this.daudzumsDataGridViewTextBoxColumn1.DataPropertyName = "Daudzums";
            this.daudzumsDataGridViewTextBoxColumn1.HeaderText = "Daudzums";
            this.daudzumsDataGridViewTextBoxColumn1.Name = "daudzumsDataGridViewTextBoxColumn1";
            // 
            // cenaDataGridViewTextBoxColumn1
            // 
            this.cenaDataGridViewTextBoxColumn1.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn1.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn1.Name = "cenaDataGridViewTextBoxColumn1";
            // 
            // precesBindingSource2
            // 
            this.precesBindingSource2.DataMember = "Preces";
            this.precesBindingSource2.DataSource = this.noliktavaDataSet;
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
            // precesBindingSource
            // 
            this.precesBindingSource.DataMember = "Preces";
            this.precesBindingSource.DataSource = this.aptiekaDataSet;
            // 
            // aptiekaDataSet
            // 
            this.aptiekaDataSet.DataSetName = "aptiekaDataSet";
            this.aptiekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nosaukumsDataGridViewTextBoxColumn,
            this.tipsDataGridViewTextBoxColumn,
            this.daudzumsDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.klientsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.pardotsBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(28, 399);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1353, 303);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nosaukumsDataGridViewTextBoxColumn
            // 
            this.nosaukumsDataGridViewTextBoxColumn.DataPropertyName = "Nosaukums";
            this.nosaukumsDataGridViewTextBoxColumn.HeaderText = "Nosaukums";
            this.nosaukumsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nosaukumsDataGridViewTextBoxColumn.Name = "nosaukumsDataGridViewTextBoxColumn";
            // 
            // tipsDataGridViewTextBoxColumn
            // 
            this.tipsDataGridViewTextBoxColumn.DataPropertyName = "Tips";
            this.tipsDataGridViewTextBoxColumn.HeaderText = "Tips";
            this.tipsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipsDataGridViewTextBoxColumn.Name = "tipsDataGridViewTextBoxColumn";
            // 
            // daudzumsDataGridViewTextBoxColumn
            // 
            this.daudzumsDataGridViewTextBoxColumn.DataPropertyName = "Daudzums";
            this.daudzumsDataGridViewTextBoxColumn.HeaderText = "Daudzums";
            this.daudzumsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daudzumsDataGridViewTextBoxColumn.Name = "daudzumsDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // klientsDataGridViewTextBoxColumn
            // 
            this.klientsDataGridViewTextBoxColumn.DataPropertyName = "Klients";
            this.klientsDataGridViewTextBoxColumn.HeaderText = "Klients";
            this.klientsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.klientsDataGridViewTextBoxColumn.Name = "klientsDataGridViewTextBoxColumn";
            // 
            // pardotsBindingSource1
            // 
            this.pardotsBindingSource1.DataMember = "Pardots";
            this.pardotsBindingSource1.DataSource = this.noliktavaDataSet;
            // 
            // pardotsBindingSource
            // 
            this.pardotsBindingSource.DataMember = "Pardots";
            this.pardotsBindingSource.DataSource = this.aptiekaDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 351);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 350);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(208, 350);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(301, 350);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1305, 350);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox6.Location = new System.Drawing.Point(526, 353);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(1, 13);
            this.textBox6.TabIndex = 7;
            // 
            // precesTableAdapter
            // 
            this.precesTableAdapter.ClearBeforeFill = true;
            // 
            // pardotsTableAdapter
            // 
            this.pardotsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(1077, 350);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pievienot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(1228, 350);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Papildināt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // precesTableAdapter1
            // 
            this.precesTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Noliktava:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 383);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pārdots:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(469, 353);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Summa:";
            // 
            // precesTableAdapter2
            // 
            this.precesTableAdapter2.ClearBeforeFill = true;
            // 
            // pardotsTableAdapter1
            // 
            this.pardotsTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nosaukums";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tips";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Daudzums";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 334);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cena";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(1152, 350);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Saglabat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 728);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noliktavaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptiekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptiekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pardotsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pardotsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private noliktava aptiekaDataSet;
        private System.Windows.Forms.BindingSource precesBindingSource;
        private aptiekaDataSetTableAdapters.PrecesTableAdapter precesTableAdapter;
        private System.Windows.Forms.BindingSource pardotsBindingSource;
        private aptiekaDataSetTableAdapters.PardotsTableAdapter pardotsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private noliktava1 aptiekaDataSet1;
        private System.Windows.Forms.BindingSource precesBindingSource1;
        private aptiekaDataSet1TableAdapters.PrecesTableAdapter precesTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private noliktavaDataSet noliktavaDataSet;
        private System.Windows.Forms.BindingSource precesBindingSource2;
        private noliktavaDataSetTableAdapters.PrecesTableAdapter precesTableAdapter2;
        private System.Windows.Forms.BindingSource pardotsBindingSource1;
        private noliktavaDataSetTableAdapters.PardotsTableAdapter pardotsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nosaukums;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tips;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daudzums;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nosaukumsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daudzumsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nosaukumsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn daudzumsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn1;
    }
}