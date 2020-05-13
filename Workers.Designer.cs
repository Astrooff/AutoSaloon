namespace AutoSaloon
{
    partial class Workers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workers));
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.labelPnone = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelSurName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSpecial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewWorkers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(12, 237);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(150, 20);
            this.textBoxAdress.TabIndex = 4;
            // 
            // labelPnone
            // 
            this.labelPnone.AutoSize = true;
            this.labelPnone.Location = new System.Drawing.Point(9, 182);
            this.labelPnone.Name = "labelPnone";
            this.labelPnone.Size = new System.Drawing.Size(52, 13);
            this.labelPnone.TabIndex = 16;
            this.labelPnone.Text = "Телефон";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(12, 143);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(54, 13);
            this.labelSecondName.TabIndex = 15;
            this.labelSecondName.Text = "Отчество";
            // 
            // labelSurName
            // 
            this.labelSurName.AutoSize = true;
            this.labelSurName.Location = new System.Drawing.Point(9, 104);
            this.labelSurName.Name = "labelSurName";
            this.labelSurName.Size = new System.Drawing.Size(56, 13);
            this.labelSurName.TabIndex = 14;
            this.labelSurName.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 13);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Имя ";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(12, 198);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(150, 20);
            this.textBoxPhone.TabIndex = 12;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(12, 159);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(150, 20);
            this.textBoxSecondName.TabIndex = 11;
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(12, 120);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(150, 20);
            this.textBoxSurName.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 81);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Адрес";
            // 
            // comboBoxSpecial
            // 
            this.comboBoxSpecial.FormattingEnabled = true;
            this.comboBoxSpecial.Items.AddRange(new object[] {
            "Техническое обслуживание",
            "Двигатель",
            "Кузовной ремонт",
            "Обслуживание ходовой части",
            "Шиномонтаж",
            "Трансмиссия",
            "Рулевое управление",
            "Тормозная система"});
            this.comboBoxSpecial.Location = new System.Drawing.Point(12, 276);
            this.comboBoxSpecial.Name = "comboBoxSpecial";
            this.comboBoxSpecial.Size = new System.Drawing.Size(150, 21);
            this.comboBoxSpecial.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Специализация";
            // 
            // listViewWorkers
            // 
            this.listViewWorkers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewWorkers.FullRowSelect = true;
            this.listViewWorkers.GridLines = true;
            this.listViewWorkers.HideSelection = false;
            this.listViewWorkers.Location = new System.Drawing.Point(177, 12);
            this.listViewWorkers.MultiSelect = false;
            this.listViewWorkers.Name = "listViewWorkers";
            this.listViewWorkers.Size = new System.Drawing.Size(556, 252);
            this.listViewWorkers.TabIndex = 20;
            this.listViewWorkers.UseCompatibleStateImageBehavior = false;
            this.listViewWorkers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Код";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фамилия";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Отчество";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Телефон";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Адрес";
            this.columnHeader6.Width = 55;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Специализация";
            this.columnHeader7.Width = 102;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(658, 270);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 23;
            this.buttonDel.Text = "УДАЛИТЬ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(567, 270);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(85, 23);
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.Text = "ИЗМЕНИТЬ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(477, 270);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(745, 305);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewWorkers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSpecial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPnone);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.labelSurName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxSurName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxAdress);
            this.Name = "Workers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Персонал";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label labelPnone;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelSurName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSpecial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewWorkers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}