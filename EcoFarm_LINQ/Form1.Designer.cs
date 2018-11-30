namespace EcoFarm_LINQ
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
            this.select_arr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.select_db = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ecoFarmDataSet = new EcoFarm_LINQ.EcoFarmDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new EcoFarm_LINQ.EcoFarmDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new EcoFarm_LINQ.EcoFarmDataSetTableAdapters.TableAdapterManager();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.avTB = new System.Windows.Forms.TextBox();
            this.oldTB = new System.Windows.Forms.TextBox();
            this.yongTB = new System.Windows.Forms.TextBox();
            this.select_pos_code = new System.Windows.Forms.Button();
            this.select_by_companies = new System.Windows.Forms.Button();
            this.CompaniesCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoFarmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // select_arr
            // 
            this.select_arr.Location = new System.Drawing.Point(9, 11);
            this.select_arr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.select_arr.Name = "select_arr";
            this.select_arr.Size = new System.Drawing.Size(121, 46);
            this.select_arr.TabIndex = 1;
            this.select_arr.Text = "Select from array strings";
            this.select_arr.UseVisualStyleBackColor = true;
            this.select_arr.Click += new System.EventHandler(this.select_arr_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select from array numbers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // select_db
            // 
            this.select_db.Location = new System.Drawing.Point(4, 15);
            this.select_db.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.select_db.Name = "select_db";
            this.select_db.Size = new System.Drawing.Size(118, 46);
            this.select_db.TabIndex = 3;
            this.select_db.Text = "Select Employees by date of birth";
            this.select_db.UseVisualStyleBackColor = true;
            this.select_db.Click += new System.EventHandler(this.select_db_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 195);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // ecoFarmDataSet
            // 
            this.ecoFarmDataSet.DataSetName = "EcoFarmDataSet";
            this.ecoFarmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.ecoFarmDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EcoFarm_LINQ.EcoFarmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 15);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(1990, 12, 11, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(150, 41);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.MaxDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Value = new System.DateTime(1998, 7, 9, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "По";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.select_db);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(9, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(317, 69);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 83);
            this.button2.TabIndex = 9;
            this.button2.Text = "Select youngest and oldest employees";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.avTB);
            this.groupBox2.Controls.Add(this.oldTB);
            this.groupBox2.Controls.Add(this.yongTB);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(137, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(302, 104);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "28 years olders";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 81);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Average age is";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "The oldest is";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "The youngest is";
            // 
            // avTB
            // 
            this.avTB.Location = new System.Drawing.Point(213, 58);
            this.avTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avTB.Name = "avTB";
            this.avTB.Size = new System.Drawing.Size(85, 20);
            this.avTB.TabIndex = 12;
            // 
            // oldTB
            // 
            this.oldTB.Location = new System.Drawing.Point(213, 35);
            this.oldTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oldTB.Name = "oldTB";
            this.oldTB.Size = new System.Drawing.Size(85, 20);
            this.oldTB.TabIndex = 11;
            // 
            // yongTB
            // 
            this.yongTB.Location = new System.Drawing.Point(213, 10);
            this.yongTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yongTB.Name = "yongTB";
            this.yongTB.Size = new System.Drawing.Size(85, 20);
            this.yongTB.TabIndex = 10;
            // 
            // select_pos_code
            // 
            this.select_pos_code.Location = new System.Drawing.Point(335, 120);
            this.select_pos_code.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.select_pos_code.Name = "select_pos_code";
            this.select_pos_code.Size = new System.Drawing.Size(104, 58);
            this.select_pos_code.TabIndex = 11;
            this.select_pos_code.Text = "Select employees by criteria of position";
            this.select_pos_code.UseVisualStyleBackColor = true;
            this.select_pos_code.Click += new System.EventHandler(this.select_pos_code_Click);
            // 
            // select_by_companies
            // 
            this.select_by_companies.Location = new System.Drawing.Point(454, 16);
            this.select_by_companies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.select_by_companies.Name = "select_by_companies";
            this.select_by_companies.Size = new System.Drawing.Size(93, 58);
            this.select_by_companies.TabIndex = 12;
            this.select_by_companies.Text = "Select employee by company";
            this.select_by_companies.UseVisualStyleBackColor = true;
            this.select_by_companies.Click += new System.EventHandler(this.select_by_companies_Click);
            // 
            // CompaniesCB
            // 
            this.CompaniesCB.FormattingEnabled = true;
            this.CompaniesCB.Items.AddRange(new object[] {
            "Microsoft",
            "Apple",
            "LG"});
            this.CompaniesCB.Location = new System.Drawing.Point(455, 84);
            this.CompaniesCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CompaniesCB.Name = "CompaniesCB";
            this.CompaniesCB.Size = new System.Drawing.Size(92, 21);
            this.CompaniesCB.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 436);
            this.Controls.Add(this.CompaniesCB);
            this.Controls.Add(this.select_by_companies);
            this.Controls.Add(this.select_pos_code);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.select_arr);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Eco-farm LINQ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecoFarmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button select_arr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button select_db;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EcoFarmDataSet ecoFarmDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EcoFarmDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private EcoFarmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox avTB;
        private System.Windows.Forms.TextBox oldTB;
        private System.Windows.Forms.TextBox yongTB;
        private System.Windows.Forms.Button select_pos_code;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button select_by_companies;
        private System.Windows.Forms.ComboBox CompaniesCB;
    }
}

