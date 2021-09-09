
namespace deneme
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
            this.liste = new System.Windows.Forms.ListBox();
            this.sepet = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liste
            // 
            this.liste.FormattingEnabled = true;
            this.liste.Location = new System.Drawing.Point(334, 76);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(236, 199);
            this.liste.TabIndex = 0;
            // 
            // sepet
            // 
            this.sepet.Location = new System.Drawing.Point(132, 76);
            this.sepet.Name = "sepet";
            this.sepet.Size = new System.Drawing.Size(153, 20);
            this.sepet.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "sepetime ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = global::deneme.Properties.Resources._5c8dd10045d2a09e009ffea6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(596, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sepet);
            this.Controls.Add(this.liste);
            this.Name = "Form1";
            this.Text = "Sepet listesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox liste;
        private System.Windows.Forms.TextBox sepet;
        private System.Windows.Forms.Button button1;
    }
}

