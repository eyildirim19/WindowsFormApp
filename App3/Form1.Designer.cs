namespace App3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSayac = new System.Windows.Forms.Button();
            this.lblSayac = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBut = new System.Windows.Forms.Button();
            this.btnGosterGizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSayac
            // 
            this.btnSayac.Location = new System.Drawing.Point(21, 129);
            this.btnSayac.Name = "btnSayac";
            this.btnSayac.Size = new System.Drawing.Size(194, 40);
            this.btnSayac.TabIndex = 0;
            this.btnSayac.Text = "Arttır";
            this.btnSayac.UseVisualStyleBackColor = true;
            this.btnSayac.Click += new System.EventHandler(this.btnSayac_Click);
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSayac.Location = new System.Drawing.Point(77, 19);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(74, 89);
            this.lblSayac.TabIndex = 1;
            this.lblSayac.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblSayac);
            this.groupBox1.Controls.Add(this.btnSayac);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 208);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sayaç Örnek";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBut);
            this.groupBox2.Controls.Add(this.btnGosterGizle);
            this.groupBox2.Location = new System.Drawing.Point(299, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 203);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Göster Gizle";
            // 
            // btnBut
            // 
            this.btnBut.Location = new System.Drawing.Point(6, 22);
            this.btnBut.Name = "btnBut";
            this.btnBut.Size = new System.Drawing.Size(239, 81);
            this.btnBut.TabIndex = 1;
            this.btnBut.UseVisualStyleBackColor = true;
            this.btnBut.Visible = false;
            // 
            // btnGosterGizle
            // 
            this.btnGosterGizle.Location = new System.Drawing.Point(6, 124);
            this.btnGosterGizle.Name = "btnGosterGizle";
            this.btnGosterGizle.Size = new System.Drawing.Size(239, 40);
            this.btnGosterGizle.TabIndex = 0;
            this.btnGosterGizle.Text = "Göster / Gizle";
            this.btnGosterGizle.UseVisualStyleBackColor = true;
            this.btnGosterGizle.Click += new System.EventHandler(this.btnGosterGizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 258);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSayac;
        private Label lblSayac;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnBut;
        private Button btnGosterGizle;
    }
}