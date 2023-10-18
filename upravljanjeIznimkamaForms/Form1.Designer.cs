namespace upravljanjeIznimkamaForms
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
            this.textBoxUnos = new System.Windows.Forms.TextBox();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.textBoxIspis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUnos
            // 
            this.textBoxUnos.Location = new System.Drawing.Point(27, 42);
            this.textBoxUnos.Name = "textBoxUnos";
            this.textBoxUnos.Size = new System.Drawing.Size(268, 20);
            this.textBoxUnos.TabIndex = 0;
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(27, 84);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(75, 23);
            this.buttonUnesi.TabIndex = 1;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // textBoxIspis
            // 
            this.textBoxIspis.Location = new System.Drawing.Point(27, 147);
            this.textBoxIspis.Name = "textBoxIspis";
            this.textBoxIspis.Size = new System.Drawing.Size(268, 20);
            this.textBoxIspis.TabIndex = 2;
            this.textBoxIspis.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unesi svoju godinu rođej";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rođen si: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 199);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIspis);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.textBoxUnos);
            this.Name = "Form1";
            this.Text = "upravljanjeIznimkama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUnos;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.TextBox textBoxIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

