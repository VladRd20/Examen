namespace Examen
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AfiseazaBTN = new System.Windows.Forms.Button();
            this.StergeBTN = new System.Windows.Forms.Button();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrComandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desert1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desert2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desert3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataComandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bioPrinzDataSet = new Examen.BioPrinzDataSet();
            this.comandaTableAdapter = new Examen.BioPrinzDataSetTableAdapters.ComandaTableAdapter();
            this.AdresaTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bioPrinzDataSet1 = new Examen.BioPrinzDataSet1();
            this.comandaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comandaTableAdapter1 = new Examen.BioPrinzDataSet1TableAdapters.ComandaTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioPrinzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioPrinzDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(302, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 124);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Felul întîi:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Supă";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 67);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Borș";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 90);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Ciorbă";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Zeamă";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.radioButton6);
            this.panel2.Controls.Add(this.radioButton7);
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Location = new System.Drawing.Point(422, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 100);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Felul Doi:";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(3, 44);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(55, 17);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Cartofi";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(3, 67);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(63, 17);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Legume";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(3, 21);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(55, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Hrișca";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(517, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(87, 107);
            this.panel3.TabIndex = 4;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(56, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Fructe";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Înghețată";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Cafea";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(16, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desert:";
            // 
            // AfiseazaBTN
            // 
            this.AfiseazaBTN.Location = new System.Drawing.Point(657, 27);
            this.AfiseazaBTN.Name = "AfiseazaBTN";
            this.AfiseazaBTN.Size = new System.Drawing.Size(89, 38);
            this.AfiseazaBTN.TabIndex = 5;
            this.AfiseazaBTN.Text = "Afiseaza Comanda";
            this.AfiseazaBTN.UseVisualStyleBackColor = true;
            this.AfiseazaBTN.Click += new System.EventHandler(this.AfiseazaBTN_Click);
            // 
            // StergeBTN
            // 
            this.StergeBTN.Location = new System.Drawing.Point(657, 73);
            this.StergeBTN.Name = "StergeBTN";
            this.StergeBTN.Size = new System.Drawing.Size(89, 38);
            this.StergeBTN.TabIndex = 6;
            this.StergeBTN.Text = "Sterge Afisarea";
            this.StergeBTN.UseVisualStyleBackColor = true;
            this.StergeBTN.Click += new System.EventHandler(this.StergeBTN_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.Location = new System.Drawing.Point(657, 138);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(89, 23);
            this.CloseBTN.TabIndex = 7;
            this.CloseBTN.Text = "Inchide";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(92, 168);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(848, 114);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ati Comandat:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrComandaDataGridViewTextBoxColumn,
            this.desert1DataGridViewTextBoxColumn,
            this.desert2DataGridViewTextBoxColumn,
            this.desert3DataGridViewTextBoxColumn,
            this.mainMenuDataGridViewTextBoxColumn,
            this.secMenuDataGridViewTextBoxColumn,
            this.dataComandaDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comandaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(92, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 112);
            this.dataGridView1.TabIndex = 10;
            // 
            // nrComandaDataGridViewTextBoxColumn
            // 
            this.nrComandaDataGridViewTextBoxColumn.DataPropertyName = "NrComanda";
            this.nrComandaDataGridViewTextBoxColumn.HeaderText = "NrComanda";
            this.nrComandaDataGridViewTextBoxColumn.Name = "nrComandaDataGridViewTextBoxColumn";
            this.nrComandaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // desert1DataGridViewTextBoxColumn
            // 
            this.desert1DataGridViewTextBoxColumn.DataPropertyName = "Desert1";
            this.desert1DataGridViewTextBoxColumn.HeaderText = "Desert1";
            this.desert1DataGridViewTextBoxColumn.Name = "desert1DataGridViewTextBoxColumn";
            // 
            // desert2DataGridViewTextBoxColumn
            // 
            this.desert2DataGridViewTextBoxColumn.DataPropertyName = "Desert2";
            this.desert2DataGridViewTextBoxColumn.HeaderText = "Desert2";
            this.desert2DataGridViewTextBoxColumn.Name = "desert2DataGridViewTextBoxColumn";
            // 
            // desert3DataGridViewTextBoxColumn
            // 
            this.desert3DataGridViewTextBoxColumn.DataPropertyName = "Desert3";
            this.desert3DataGridViewTextBoxColumn.HeaderText = "Desert3";
            this.desert3DataGridViewTextBoxColumn.Name = "desert3DataGridViewTextBoxColumn";
            // 
            // mainMenuDataGridViewTextBoxColumn
            // 
            this.mainMenuDataGridViewTextBoxColumn.DataPropertyName = "MainMenu";
            this.mainMenuDataGridViewTextBoxColumn.HeaderText = "MainMenu";
            this.mainMenuDataGridViewTextBoxColumn.Name = "mainMenuDataGridViewTextBoxColumn";
            // 
            // secMenuDataGridViewTextBoxColumn
            // 
            this.secMenuDataGridViewTextBoxColumn.DataPropertyName = "SecMenu";
            this.secMenuDataGridViewTextBoxColumn.HeaderText = "SecMenu";
            this.secMenuDataGridViewTextBoxColumn.Name = "secMenuDataGridViewTextBoxColumn";
            // 
            // dataComandaDataGridViewTextBoxColumn
            // 
            this.dataComandaDataGridViewTextBoxColumn.DataPropertyName = "DataComanda";
            this.dataComandaDataGridViewTextBoxColumn.HeaderText = "DataComanda";
            this.dataComandaDataGridViewTextBoxColumn.Name = "dataComandaDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // comandaBindingSource
            // 
            this.comandaBindingSource.DataMember = "Comanda";
            this.comandaBindingSource.DataSource = this.bioPrinzDataSet;
            // 
            // bioPrinzDataSet
            // 
            this.bioPrinzDataSet.DataSetName = "BioPrinzDataSet";
            this.bioPrinzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comandaTableAdapter
            // 
            this.comandaTableAdapter.ClearBeforeFill = true;
            // 
            // AdresaTXT
            // 
            this.AdresaTXT.Location = new System.Drawing.Point(440, 147);
            this.AdresaTXT.Name = "AdresaTXT";
            this.AdresaTXT.Size = new System.Drawing.Size(161, 20);
            this.AdresaTXT.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adresa: ";
            // 
            // bioPrinzDataSet1
            // 
            this.bioPrinzDataSet1.DataSetName = "BioPrinzDataSet1";
            this.bioPrinzDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comandaBindingSource1
            // 
            this.comandaBindingSource1.DataMember = "Comanda";
            this.comandaBindingSource1.DataSource = this.bioPrinzDataSet1;
            // 
            // comandaTableAdapter1
            // 
            this.comandaTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 413);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdresaTXT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.StergeBTN);
            this.Controls.Add(this.AfiseazaBTN);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioPrinzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bioPrinzDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button AfiseazaBTN;
        private System.Windows.Forms.Button StergeBTN;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BioPrinzDataSet bioPrinzDataSet;
        private System.Windows.Forms.BindingSource comandaBindingSource;
        private BioPrinzDataSetTableAdapters.ComandaTableAdapter comandaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrComandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desert1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desert2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desert3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataComandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox AdresaTXT;
        private System.Windows.Forms.Label label5;
        private BioPrinzDataSet1 bioPrinzDataSet1;
        private System.Windows.Forms.BindingSource comandaBindingSource1;
        private BioPrinzDataSet1TableAdapters.ComandaTableAdapter comandaTableAdapter1;
    }
}

