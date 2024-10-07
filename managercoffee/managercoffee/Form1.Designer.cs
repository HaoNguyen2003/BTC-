namespace managercoffee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_LoadSQL = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxtatse = new System.Windows.Forms.TextBox();
            this.textBoxDateExpire = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxImg = new System.Windows.Forms.TextBox();
            this.textBoxSmell = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeTableAdapter = new managercoffee.QLCFDataSetTableAdapters.coffeeTableAdapter();
            this.coffeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionplaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.tasteDataGridViewTextBoxColumn,
            this.expiredateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.smellDataGridViewTextBoxColumn,
            this.productionplaceDataGridViewTextBoxColumn,
            this.imgDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coffeeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(32, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(741, 486);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_LoadSQL
            // 
            this.btn_LoadSQL.Location = new System.Drawing.Point(32, 5);
            this.btn_LoadSQL.Name = "btn_LoadSQL";
            this.btn_LoadSQL.Size = new System.Drawing.Size(272, 33);
            this.btn_LoadSQL.TabIndex = 1;
            this.btn_LoadSQL.Text = "Load Data from SQL";
            this.btn_LoadSQL.UseVisualStyleBackColor = true;
            this.btn_LoadSQL.Click += new System.EventHandler(this.btn_LoadSQL_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(419, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(272, 33);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close Application";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(32, 636);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(157, 33);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(237, 636);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(157, 33);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(432, 636);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(157, 33);
            this.btn_insert.TabIndex = 5;
            this.btn_insert.Text = "insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(167, 66);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(195, 26);
            this.textBoxID.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(167, 103);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(195, 26);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxtatse
            // 
            this.textBoxtatse.Location = new System.Drawing.Point(562, 66);
            this.textBoxtatse.Name = "textBoxtatse";
            this.textBoxtatse.Size = new System.Drawing.Size(211, 26);
            this.textBoxtatse.TabIndex = 8;
            // 
            // textBoxDateExpire
            // 
            this.textBoxDateExpire.Location = new System.Drawing.Point(562, 103);
            this.textBoxDateExpire.Name = "textBoxDateExpire";
            this.textBoxDateExpire.Size = new System.Drawing.Size(211, 26);
            this.textBoxDateExpire.TabIndex = 9;
            this.textBoxDateExpire.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(952, 12);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(246, 26);
            this.textBoxPrice.TabIndex = 10;
            // 
            // textBoxImg
            // 
            this.textBoxImg.Location = new System.Drawing.Point(952, 55);
            this.textBoxImg.Name = "textBoxImg";
            this.textBoxImg.Size = new System.Drawing.Size(246, 26);
            this.textBoxImg.TabIndex = 11;
            // 
            // textBoxSmell
            // 
            this.textBoxSmell.Location = new System.Drawing.Point(952, 97);
            this.textBoxSmell.Name = "textBoxSmell";
            this.textBoxSmell.Size = new System.Drawing.Size(246, 26);
            this.textBoxSmell.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(809, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 438);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Coffee ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Coffee Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Coffee tatse:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Expire Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(805, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Image Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(805, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Coffee Smell:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(805, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Producttion Place:";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(952, 135);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(246, 26);
            this.textBoxPlace.TabIndex = 22;
            // 
            // coffeeTableAdapter
            // 
            this.coffeeTableAdapter.ClearBeforeFill = true;
            // 
            // coffeeBindingSource1
            // 
            this.coffeeBindingSource1.DataSource = typeof(managercoffee.coffee);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // tasteDataGridViewTextBoxColumn
            // 
            this.tasteDataGridViewTextBoxColumn.DataPropertyName = "taste";
            this.tasteDataGridViewTextBoxColumn.HeaderText = "taste";
            this.tasteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tasteDataGridViewTextBoxColumn.Name = "tasteDataGridViewTextBoxColumn";
            this.tasteDataGridViewTextBoxColumn.Width = 150;
            // 
            // expiredateDataGridViewTextBoxColumn
            // 
            this.expiredateDataGridViewTextBoxColumn.DataPropertyName = "expire_date";
            this.expiredateDataGridViewTextBoxColumn.HeaderText = "expire_date";
            this.expiredateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.expiredateDataGridViewTextBoxColumn.Name = "expiredateDataGridViewTextBoxColumn";
            this.expiredateDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // smellDataGridViewTextBoxColumn
            // 
            this.smellDataGridViewTextBoxColumn.DataPropertyName = "smell";
            this.smellDataGridViewTextBoxColumn.HeaderText = "smell";
            this.smellDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.smellDataGridViewTextBoxColumn.Name = "smellDataGridViewTextBoxColumn";
            this.smellDataGridViewTextBoxColumn.Width = 150;
            // 
            // productionplaceDataGridViewTextBoxColumn
            // 
            this.productionplaceDataGridViewTextBoxColumn.DataPropertyName = "production_place";
            this.productionplaceDataGridViewTextBoxColumn.HeaderText = "production_place";
            this.productionplaceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productionplaceDataGridViewTextBoxColumn.Name = "productionplaceDataGridViewTextBoxColumn";
            this.productionplaceDataGridViewTextBoxColumn.Width = 150;
            // 
            // imgDataGridViewTextBoxColumn
            // 
            this.imgDataGridViewTextBoxColumn.DataPropertyName = "img";
            this.imgDataGridViewTextBoxColumn.HeaderText = "img";
            this.imgDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.imgDataGridViewTextBoxColumn.Name = "imgDataGridViewTextBoxColumn";
            this.imgDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 681);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSmell);
            this.Controls.Add(this.textBoxImg);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDateExpire);
            this.Controls.Add(this.textBoxtatse);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_LoadSQL);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_LoadSQL;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxtatse;
        private System.Windows.Forms.TextBox textBoxDateExpire;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxImg;
        private System.Windows.Forms.TextBox textBoxSmell;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.BindingSource bindingSource1;
        private QLCFDataSetTableAdapters.coffeeTableAdapter coffeeTableAdapter;
        private QLCFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLCFDataSet QLCFDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionplaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource coffeeBindingSource1;
    }
}

