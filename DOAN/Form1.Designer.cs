namespace AES_File
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_vb = new System.Windows.Forms.TextBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_vb
            // 
            this.txt_vb.Location = new System.Drawing.Point(99, 213);
            this.txt_vb.Name = "txt_vb";
            this.txt_vb.Size = new System.Drawing.Size(236, 20);
            this.txt_vb.TabIndex = 0;
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(99, 278);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(236, 20);
            this.txt_key.TabIndex = 1;
            this.txt_key.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(87, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "L O G I N";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(403, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.txt_vb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_vb;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Button button1;
    }
}

