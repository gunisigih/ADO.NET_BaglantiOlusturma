namespace BaglantiOlusturma1
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
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_OpenOrClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(12, 11);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(115, 38);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "OPEN";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(12, 55);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(115, 38);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "CLOSE";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_OpenOrClose
            // 
            this.btn_OpenOrClose.Location = new System.Drawing.Point(12, 99);
            this.btn_OpenOrClose.Name = "btn_OpenOrClose";
            this.btn_OpenOrClose.Size = new System.Drawing.Size(115, 38);
            this.btn_OpenOrClose.TabIndex = 2;
            this.btn_OpenOrClose.Text = "OPEN | CLOSE";
            this.btn_OpenOrClose.UseVisualStyleBackColor = true;
            this.btn_OpenOrClose.Click += new System.EventHandler(this.btn_OpenOrClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(142, 161);
            this.Controls.Add(this.btn_OpenOrClose);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_OpenOrClose;
    }
}

