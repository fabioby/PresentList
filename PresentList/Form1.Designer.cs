namespace PresentList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_shop = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.listBox_present = new System.Windows.Forms.ListBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.textBox_shop);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új elem hozzáadása";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Üzlet";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(13, 49);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(228, 22);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_shop
            // 
            this.textBox_shop.Location = new System.Drawing.Point(13, 95);
            this.textBox_shop.Name = "textBox_shop";
            this.textBox_shop.Size = new System.Drawing.Size(228, 22);
            this.textBox_shop.TabIndex = 3;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(13, 123);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "hozzáad";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // listBox_present
            // 
            this.listBox_present.FormattingEnabled = true;
            this.listBox_present.ItemHeight = 16;
            this.listBox_present.Location = new System.Drawing.Point(13, 184);
            this.listBox_present.Name = "listBox_present";
            this.listBox_present.Size = new System.Drawing.Size(1078, 292);
            this.listBox_present.TabIndex = 1;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(285, 137);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(94, 40);
            this.button_remove.TabIndex = 2;
            this.button_remove.Text = "TÖRLÉS";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 497);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.listBox_present);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Present List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_shop;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_present;
        private System.Windows.Forms.Button button_remove;
    }
}

