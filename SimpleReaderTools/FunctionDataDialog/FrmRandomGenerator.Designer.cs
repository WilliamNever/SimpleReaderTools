namespace SimpleReaderTools.FunctionDataDialog
{
    partial class FrmRandomGenerator
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
            this.pnl1 = new System.Windows.Forms.Panel();
            this.grpbConfig = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCharactersSeeds = new System.Windows.Forms.TextBox();
            this.cmbPattern = new System.Windows.Forms.ComboBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtCcpComp = new SimpleReaderTools.Components.CutCopyPastControl();
            this.pnl1.SuspendLayout();
            this.grpbConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.grpbConfig);
            this.pnl1.Controls.Add(this.txtContent);
            this.pnl1.Controls.Add(this.txtCcpComp);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(800, 450);
            this.pnl1.TabIndex = 0;
            // 
            // grpbConfig
            // 
            this.grpbConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbConfig.Controls.Add(this.btnGenerate);
            this.grpbConfig.Controls.Add(this.txtNumber);
            this.grpbConfig.Controls.Add(this.lblNumber);
            this.grpbConfig.Controls.Add(this.txtLength);
            this.grpbConfig.Controls.Add(this.lblLength);
            this.grpbConfig.Controls.Add(this.btnClear);
            this.grpbConfig.Controls.Add(this.txtCharactersSeeds);
            this.grpbConfig.Controls.Add(this.cmbPattern);
            this.grpbConfig.Location = new System.Drawing.Point(4, 4);
            this.grpbConfig.Name = "grpbConfig";
            this.grpbConfig.Size = new System.Drawing.Size(793, 92);
            this.grpbConfig.TabIndex = 2;
            this.grpbConfig.TabStop = false;
            this.grpbConfig.Text = "Configs";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(688, 60);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(99, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(299, 47);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(236, 20);
            this.txtNumber.TabIndex = 6;
            this.txtNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtControl_Validating);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(243, 51);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(50, 13);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Number -";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(58, 47);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(179, 20);
            this.txtLength.TabIndex = 4;
            this.txtLength.Validating += new System.ComponentModel.CancelEventHandler(this.txtControl_Validating);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(8, 51);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(46, 13);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "Length -";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(725, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCharactersSeeds
            // 
            this.txtCharactersSeeds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCharactersSeeds.Location = new System.Drawing.Point(192, 19);
            this.txtCharactersSeeds.Name = "txtCharactersSeeds";
            this.txtCharactersSeeds.Size = new System.Drawing.Size(527, 20);
            this.txtCharactersSeeds.TabIndex = 1;
            this.txtCharactersSeeds.Validating += new System.ComponentModel.CancelEventHandler(this.txtNullOrEmpty_Validating);
            // 
            // cmbPattern
            // 
            this.cmbPattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPattern.FormattingEnabled = true;
            this.cmbPattern.Location = new System.Drawing.Point(8, 19);
            this.cmbPattern.Name = "cmbPattern";
            this.cmbPattern.Size = new System.Drawing.Size(178, 21);
            this.cmbPattern.TabIndex = 0;
            this.cmbPattern.SelectedIndexChanged += new System.EventHandler(this.cmbPattern_SelectedIndexChanged);
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(3, 102);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(794, 310);
            this.txtContent.TabIndex = 1;
            // 
            // txtCcpComp
            // 
            this.txtCcpComp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCcpComp.Location = new System.Drawing.Point(455, 418);
            this.txtCcpComp.Name = "txtCcpComp";
            this.txtCcpComp.Size = new System.Drawing.Size(342, 29);
            this.txtCcpComp.TabIndex = 0;
            this.txtCcpComp.TxtContents = this.txtContent;
            // 
            // FrmRandomGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl1);
            this.Name = "FrmRandomGenerator";
            this.Text = "Random Strings Generator";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.grpbConfig.ResumeLayout(false);
            this.grpbConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private Components.CutCopyPastControl txtCcpComp;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.GroupBox grpbConfig;
        private System.Windows.Forms.ComboBox cmbPattern;
        private System.Windows.Forms.TextBox txtCharactersSeeds;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnGenerate;
    }
}