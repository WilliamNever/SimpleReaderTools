namespace SimpleReaderTools.Components
{
    partial class CutCopyPastControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPaste = new System.Windows.Forms.Button();
            this.BtnCopySel = new System.Windows.Forms.Button();
            this.btnSelALL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(153, 3);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(86, 23);
            this.btnPaste.TabIndex = 17;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // BtnCopySel
            // 
            this.BtnCopySel.Location = new System.Drawing.Point(65, 3);
            this.BtnCopySel.Name = "BtnCopySel";
            this.BtnCopySel.Size = new System.Drawing.Size(86, 23);
            this.BtnCopySel.TabIndex = 16;
            this.BtnCopySel.Text = "Copy Selection";
            this.BtnCopySel.UseVisualStyleBackColor = true;
            this.BtnCopySel.Click += new System.EventHandler(this.BtnCopySel_Click);
            // 
            // btnSelALL
            // 
            this.btnSelALL.Location = new System.Drawing.Point(3, 3);
            this.btnSelALL.Name = "btnSelALL";
            this.btnSelALL.Size = new System.Drawing.Size(60, 23);
            this.btnSelALL.TabIndex = 15;
            this.btnSelALL.Text = "Select All";
            this.btnSelALL.UseVisualStyleBackColor = true;
            this.btnSelALL.Click += new System.EventHandler(this.btnSelALL_Click);
            // 
            // CutCopyPastControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.BtnCopySel);
            this.Controls.Add(this.btnSelALL);
            this.Name = "CutCopyPastControl";
            this.Size = new System.Drawing.Size(243, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button BtnCopySel;
        private System.Windows.Forms.Button btnSelALL;
    }
}
