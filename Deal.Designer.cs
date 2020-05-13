namespace AutoSaloon
{
    partial class Deal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deal));
            this.comboBoxCar = new System.Windows.Forms.ComboBox();
            this.comboBoxWorkers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPriceClient = new System.Windows.Forms.TextBox();
            this.textBoxPriceWorker = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewDeals = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.FormattingEnabled = true;
            this.comboBoxCar.Location = new System.Drawing.Point(10, 84);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCar.TabIndex = 0;
            this.comboBoxCar.SelectedIndexChanged += new System.EventHandler(this.comboBoxCar_SelectedIndexChanged);
            // 
            // comboBoxWorkers
            // 
            this.comboBoxWorkers.FormattingEnabled = true;
            this.comboBoxWorkers.Location = new System.Drawing.Point(10, 124);
            this.comboBoxWorkers.Name = "comboBoxWorkers";
            this.comboBoxWorkers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWorkers.TabIndex = 1;
            this.comboBoxWorkers.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorkers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Машина";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Персонал";
            // 
            // textBoxPriceClient
            // 
            this.textBoxPriceClient.Location = new System.Drawing.Point(10, 162);
            this.textBoxPriceClient.Name = "textBoxPriceClient";
            this.textBoxPriceClient.Size = new System.Drawing.Size(121, 20);
            this.textBoxPriceClient.TabIndex = 4;
            this.textBoxPriceClient.TextChanged += new System.EventHandler(this.textBoxPriceClient_TextChanged);
            // 
            // textBoxPriceWorker
            // 
            this.textBoxPriceWorker.Location = new System.Drawing.Point(10, 201);
            this.textBoxPriceWorker.Name = "textBoxPriceWorker";
            this.textBoxPriceWorker.Size = new System.Drawing.Size(121, 20);
            this.textBoxPriceWorker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена работ для клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена работ для персонала";
            // 
            // listViewDeals
            // 
            this.listViewDeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewDeals.FullRowSelect = true;
            this.listViewDeals.GridLines = true;
            this.listViewDeals.HideSelection = false;
            this.listViewDeals.Location = new System.Drawing.Point(156, 15);
            this.listViewDeals.MultiSelect = false;
            this.listViewDeals.Name = "listViewDeals";
            this.listViewDeals.Size = new System.Drawing.Size(596, 192);
            this.listViewDeals.TabIndex = 18;
            this.listViewDeals.UseCompatibleStateImageBehavior = false;
            this.listViewDeals.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Код";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя персонала";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фамилия";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Номер Гос. Регистрации";
            this.columnHeader4.Width = 124;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Вид поломки";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(677, 213);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 23;
            this.buttonDel.Text = "УДАЛИТЬ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(586, 213);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 23);
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.Text = "ИЗМЕНИТЬ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(496, 213);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(84, 23);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "СОЗДАТЬ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Deal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 251);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewDeals);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPriceWorker);
            this.Controls.Add(this.textBoxPriceClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxWorkers);
            this.Controls.Add(this.comboBoxCar);
            this.Name = "Deal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сделки";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCar;
        private System.Windows.Forms.ComboBox comboBoxWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPriceClient;
        private System.Windows.Forms.TextBox textBoxPriceWorker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewDeals;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}