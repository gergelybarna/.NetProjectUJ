namespace AutoWashingProject
{
    partial class NewCarPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCarPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(192, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto Hozzáadása";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(112, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rendszám:";
            this.label2.UseWaitCursor = true;
            // 
            // textBoxPlate
            // 
            this.textBoxPlate.Location = new System.Drawing.Point(194, 194);
            this.textBoxPlate.Name = "textBoxPlate";
            this.textBoxPlate.Size = new System.Drawing.Size(150, 20);
            this.textBoxPlate.TabIndex = 2;
            this.textBoxPlate.UseWaitCursor = true;
            this.textBoxPlate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(246, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 45);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(223, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hozzáad";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(223, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 31);
            this.button3.TabIndex = 5;
            this.button3.Text = "Mégsem";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(194, 229);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(150, 20);
            this.textBoxBrand.TabIndex = 6;
            this.textBoxBrand.UseWaitCursor = true;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(194, 266);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(150, 20);
            this.textBoxType.TabIndex = 7;
            this.textBoxType.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(124, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Márka:";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(127, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Modell:";
            this.label4.UseWaitCursor = true;
            // 
            // NewCarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(513, 498);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPlate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "NewCarPage";
            this.Text = "Auto Mosás & Szerviz";
            this.Load += new System.EventHandler(this.NewCarPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


