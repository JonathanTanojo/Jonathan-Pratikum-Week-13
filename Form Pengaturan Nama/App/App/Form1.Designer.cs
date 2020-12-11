namespace App
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
            this.labelinput = new System.Windows.Forms.Label();
            this.textBoxinput = new System.Windows.Forms.TextBox();
            this.buttonproses = new System.Windows.Forms.Button();
            this.labelempty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelinput
            // 
            this.labelinput.AutoSize = true;
            this.labelinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinput.Location = new System.Drawing.Point(52, 55);
            this.labelinput.Name = "labelinput";
            this.labelinput.Size = new System.Drawing.Size(82, 18);
            this.labelinput.TabIndex = 0;
            this.labelinput.Text = "Input Data :";
            // 
            // textBoxinput
            // 
            this.textBoxinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxinput.Location = new System.Drawing.Point(55, 87);
            this.textBoxinput.Name = "textBoxinput";
            this.textBoxinput.Size = new System.Drawing.Size(140, 22);
            this.textBoxinput.TabIndex = 1;
            this.textBoxinput.TextChanged += new System.EventHandler(this.textBoxinput_TextChanged);
            this.textBoxinput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxinput_KeyDown);
            // 
            // buttonproses
            // 
            this.buttonproses.Location = new System.Drawing.Point(55, 136);
            this.buttonproses.Name = "buttonproses";
            this.buttonproses.Size = new System.Drawing.Size(87, 24);
            this.buttonproses.TabIndex = 2;
            this.buttonproses.Text = "Proses";
            this.buttonproses.UseVisualStyleBackColor = true;
            this.buttonproses.Click += new System.EventHandler(this.buttonproses_Click);
            // 
            // labelempty
            // 
            this.labelempty.AutoSize = true;
            this.labelempty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelempty.Location = new System.Drawing.Point(49, 213);
            this.labelempty.Name = "labelempty";
            this.labelempty.Size = new System.Drawing.Size(123, 31);
            this.labelempty.TabIndex = 3;
            this.labelempty.Text = "[EMPTY]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 323);
            this.Controls.Add(this.labelempty);
            this.Controls.Add(this.buttonproses);
            this.Controls.Add(this.textBoxinput);
            this.Controls.Add(this.labelinput);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Nama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinput;
        private System.Windows.Forms.TextBox textBoxinput;
        private System.Windows.Forms.Button buttonproses;
        private System.Windows.Forms.Label labelempty;
    }
}

