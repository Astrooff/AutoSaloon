namespace AutoSaloon
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonCars = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonWorkers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCars
            // 
            this.buttonCars.Location = new System.Drawing.Point(17, 55);
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.Size = new System.Drawing.Size(150, 34);
            this.buttonCars.TabIndex = 1;
            this.buttonCars.Text = "Автомобили на ремонте";
            this.buttonCars.UseVisualStyleBackColor = true;
            this.buttonCars.Click += new System.EventHandler(this.buttonCars_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "Сделки";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonWorkers
            // 
            this.buttonWorkers.Location = new System.Drawing.Point(17, 95);
            this.buttonWorkers.Name = "buttonWorkers";
            this.buttonWorkers.Size = new System.Drawing.Size(150, 34);
            this.buttonWorkers.TabIndex = 2;
            this.buttonWorkers.Text = "Персонал";
            this.buttonWorkers.UseVisualStyleBackColor = true;
            this.buttonWorkers.Click += new System.EventHandler(this.buttonWorkers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(184, 181);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonWorkers);
            this.Controls.Add(this.buttonCars);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCars;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonWorkers;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

