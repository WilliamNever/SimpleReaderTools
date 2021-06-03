namespace SimpleReaderTools.FunctionDataDialog
{
    partial class FrmShowCharNumber
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
            this.txtMessageInformation = new System.Windows.Forms.TextBox();
            this.btnShowCharNumber = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpFunctionality = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFontBig = new System.Windows.Forms.Button();
            this.btnPickFont = new System.Windows.Forms.Button();
            this.btnFontSmall = new System.Windows.Forms.Button();
            this.chbAutoWrap = new System.Windows.Forms.CheckBox();
            this.btnFontDefault = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGeneralNewGuid = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.MSMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFunctions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCopyFromMain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCopyToMain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAppToForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAppAndClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowFormattedJson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowNoFormattedJson = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOrderJsonProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmShowFormattedXml = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowNoFormattedXml = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOrderXmlNodes = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            this.grpFunctionality.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MSMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessageInformation
            // 
            this.txtMessageInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageInformation.Location = new System.Drawing.Point(16, 156);
            this.txtMessageInformation.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessageInformation.MaxLength = 0;
            this.txtMessageInformation.Multiline = true;
            this.txtMessageInformation.Name = "txtMessageInformation";
            this.txtMessageInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageInformation.Size = new System.Drawing.Size(1033, 382);
            this.txtMessageInformation.TabIndex = 0;
            // 
            // btnShowCharNumber
            // 
            this.btnShowCharNumber.Location = new System.Drawing.Point(8, 21);
            this.btnShowCharNumber.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowCharNumber.Name = "btnShowCharNumber";
            this.btnShowCharNumber.Size = new System.Drawing.Size(112, 28);
            this.btnShowCharNumber.TabIndex = 0;
            this.btnShowCharNumber.Text = "Char Number";
            this.btnShowCharNumber.UseVisualStyleBackColor = true;
            this.btnShowCharNumber.Click += new System.EventHandler(this.btnShowCharNumber_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grpFunctionality);
            this.pnlMain.Controls.Add(this.txtMessageInformation);
            this.pnlMain.Controls.Add(this.MSMainMenu);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1067, 554);
            this.pnlMain.TabIndex = 1;
            // 
            // grpFunctionality
            // 
            this.grpFunctionality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFunctionality.Controls.Add(this.panel1);
            this.grpFunctionality.Controls.Add(this.btnClear);
            this.grpFunctionality.Controls.Add(this.btnGeneralNewGuid);
            this.grpFunctionality.Controls.Add(this.btnMinMax);
            this.grpFunctionality.Controls.Add(this.btnShowCharNumber);
            this.grpFunctionality.Location = new System.Drawing.Point(16, 44);
            this.grpFunctionality.Margin = new System.Windows.Forms.Padding(4);
            this.grpFunctionality.Name = "grpFunctionality";
            this.grpFunctionality.Padding = new System.Windows.Forms.Padding(4);
            this.grpFunctionality.Size = new System.Drawing.Size(1035, 105);
            this.grpFunctionality.TabIndex = 1;
            this.grpFunctionality.TabStop = false;
            this.grpFunctionality.Text = "Functionality";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFontBig);
            this.panel1.Controls.Add(this.btnPickFont);
            this.panel1.Controls.Add(this.btnFontSmall);
            this.panel1.Controls.Add(this.chbAutoWrap);
            this.panel1.Controls.Add(this.btnFontDefault);
            this.panel1.Location = new System.Drawing.Point(786, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 83);
            this.panel1.TabIndex = 16;
            // 
            // btnFontBig
            // 
            this.btnFontBig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFontBig.Location = new System.Drawing.Point(163, 11);
            this.btnFontBig.Margin = new System.Windows.Forms.Padding(4);
            this.btnFontBig.Name = "btnFontBig";
            this.btnFontBig.Size = new System.Drawing.Size(69, 28);
            this.btnFontBig.TabIndex = 13;
            this.btnFontBig.Text = ">>";
            this.btnFontBig.UseVisualStyleBackColor = true;
            this.btnFontBig.Click += new System.EventHandler(this.btnFontBig_Click);
            // 
            // btnPickFont
            // 
            this.btnPickFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickFont.Location = new System.Drawing.Point(8, 46);
            this.btnPickFont.Name = "btnPickFont";
            this.btnPickFont.Size = new System.Drawing.Size(78, 28);
            this.btnPickFont.TabIndex = 15;
            this.btnPickFont.Text = "Font Pick";
            this.btnPickFont.UseVisualStyleBackColor = true;
            this.btnPickFont.Click += new System.EventHandler(this.btnPickFont_Click);
            // 
            // btnFontSmall
            // 
            this.btnFontSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFontSmall.Location = new System.Drawing.Point(8, 11);
            this.btnFontSmall.Margin = new System.Windows.Forms.Padding(4);
            this.btnFontSmall.Name = "btnFontSmall";
            this.btnFontSmall.Size = new System.Drawing.Size(69, 28);
            this.btnFontSmall.TabIndex = 11;
            this.btnFontSmall.Text = "<<";
            this.btnFontSmall.UseVisualStyleBackColor = true;
            this.btnFontSmall.Click += new System.EventHandler(this.btnFontSmall_Click);
            // 
            // chbAutoWrap
            // 
            this.chbAutoWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbAutoWrap.AutoSize = true;
            this.chbAutoWrap.Checked = true;
            this.chbAutoWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAutoWrap.Location = new System.Drawing.Point(139, 51);
            this.chbAutoWrap.Margin = new System.Windows.Forms.Padding(4);
            this.chbAutoWrap.Name = "chbAutoWrap";
            this.chbAutoWrap.Size = new System.Drawing.Size(93, 21);
            this.chbAutoWrap.TabIndex = 14;
            this.chbAutoWrap.Text = "AutoWrap";
            this.chbAutoWrap.UseVisualStyleBackColor = true;
            this.chbAutoWrap.CheckedChanged += new System.EventHandler(this.chbAutoWrap_CheckedChanged);
            // 
            // btnFontDefault
            // 
            this.btnFontDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFontDefault.Location = new System.Drawing.Point(85, 11);
            this.btnFontDefault.Margin = new System.Windows.Forms.Padding(4);
            this.btnFontDefault.Name = "btnFontDefault";
            this.btnFontDefault.Size = new System.Drawing.Size(69, 28);
            this.btnFontDefault.TabIndex = 12;
            this.btnFontDefault.Text = "Default";
            this.btnFontDefault.UseVisualStyleBackColor = true;
            this.btnFontDefault.Click += new System.EventHandler(this.btnFontDefault_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.Location = new System.Drawing.Point(688, 70);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGeneralNewGuid
            // 
            this.btnGeneralNewGuid.Location = new System.Drawing.Point(264, 21);
            this.btnGeneralNewGuid.Name = "btnGeneralNewGuid";
            this.btnGeneralNewGuid.Size = new System.Drawing.Size(112, 28);
            this.btnGeneralNewGuid.TabIndex = 2;
            this.btnGeneralNewGuid.Text = "New Guid";
            this.btnGeneralNewGuid.UseVisualStyleBackColor = true;
            this.btnGeneralNewGuid.Click += new System.EventHandler(this.btnGeneralNewGuid_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(136, 21);
            this.btnMinMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(112, 28);
            this.btnMinMax.TabIndex = 1;
            this.btnMinMax.Text = "MinMaxValue";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // MSMainMenu
            // 
            this.MSMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MSMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFunctions,
            this.tsmiTools});
            this.MSMainMenu.Location = new System.Drawing.Point(0, 0);
            this.MSMainMenu.Name = "MSMainMenu";
            this.MSMainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MSMainMenu.Size = new System.Drawing.Size(1067, 28);
            this.MSMainMenu.TabIndex = 2;
            this.MSMainMenu.Text = "Main Menu";
            // 
            // tsmiFunctions
            // 
            this.tsmiFunctions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCopyFromMain,
            this.toolStripSeparator2,
            this.tsmCopyToMain,
            this.tsmiCopyClose,
            this.tsmAppToForm,
            this.tsmAppAndClose,
            this.toolStripSeparator1,
            this.tsmClose});
            this.tsmiFunctions.Name = "tsmiFunctions";
            this.tsmiFunctions.Size = new System.Drawing.Size(79, 24);
            this.tsmiFunctions.Text = "&Function";
            this.tsmiFunctions.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsmiFunctions_DropDownItemClicked);
            // 
            // tsmCopyFromMain
            // 
            this.tsmCopyFromMain.Name = "tsmCopyFromMain";
            this.tsmCopyFromMain.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.M)));
            this.tsmCopyFromMain.Size = new System.Drawing.Size(319, 26);
            this.tsmCopyFromMain.Text = "Copy From MainForm";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(316, 6);
            // 
            // tsmCopyToMain
            // 
            this.tsmCopyToMain.Name = "tsmCopyToMain";
            this.tsmCopyToMain.Size = new System.Drawing.Size(319, 26);
            this.tsmCopyToMain.Text = "&Copy To Main Form";
            // 
            // tsmiCopyClose
            // 
            this.tsmiCopyClose.Name = "tsmiCopyClose";
            this.tsmiCopyClose.Size = new System.Drawing.Size(319, 26);
            this.tsmiCopyClose.Text = "Copy &and Close";
            // 
            // tsmAppToForm
            // 
            this.tsmAppToForm.Name = "tsmAppToForm";
            this.tsmAppToForm.Size = new System.Drawing.Size(319, 26);
            this.tsmAppToForm.Text = "&Append To Main Form";
            // 
            // tsmAppAndClose
            // 
            this.tsmAppAndClose.Name = "tsmAppAndClose";
            this.tsmAppAndClose.Size = new System.Drawing.Size(319, 26);
            this.tsmAppAndClose.Text = "Append and Close";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(316, 6);
            // 
            // tsmClose
            // 
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(319, 26);
            this.tsmClose.Text = "Cl&ose";
            // 
            // tsmiTools
            // 
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowFormattedJson,
            this.tsmShowNoFormattedJson,
            this.tsmOrderJsonProperties,
            this.toolStripSeparator3,
            this.tsmShowFormattedXml,
            this.tsmShowNoFormattedXml,
            this.tsmOrderXmlNodes});
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(58, 24);
            this.tsmiTools.Text = "&Tools";
            this.tsmiTools.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsmiFunctions_DropDownItemClicked);
            // 
            // tsmShowFormattedJson
            // 
            this.tsmShowFormattedJson.Name = "tsmShowFormattedJson";
            this.tsmShowFormattedJson.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.J)));
            this.tsmShowFormattedJson.Size = new System.Drawing.Size(338, 26);
            this.tsmShowFormattedJson.Text = "Show Formatted Json";
            // 
            // tsmShowNoFormattedJson
            // 
            this.tsmShowNoFormattedJson.Name = "tsmShowNoFormattedJson";
            this.tsmShowNoFormattedJson.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.tsmShowNoFormattedJson.Size = new System.Drawing.Size(338, 26);
            this.tsmShowNoFormattedJson.Text = "Show No Formatted json";
            // 
            // tsmOrderJsonProperties
            // 
            this.tsmOrderJsonProperties.Name = "tsmOrderJsonProperties";
            this.tsmOrderJsonProperties.Size = new System.Drawing.Size(338, 26);
            this.tsmOrderJsonProperties.Text = "Order Json Properties";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(335, 6);
            // 
            // tsmShowFormattedXml
            // 
            this.tsmShowFormattedXml.Name = "tsmShowFormattedXml";
            this.tsmShowFormattedXml.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.tsmShowFormattedXml.Size = new System.Drawing.Size(338, 26);
            this.tsmShowFormattedXml.Text = "Show Formatted Xml";
            // 
            // tsmShowNoFormattedXml
            // 
            this.tsmShowNoFormattedXml.Name = "tsmShowNoFormattedXml";
            this.tsmShowNoFormattedXml.Size = new System.Drawing.Size(338, 26);
            this.tsmShowNoFormattedXml.Text = "Show No Formatted Xml";
            // 
            // tsmOrderXmlNodes
            // 
            this.tsmOrderXmlNodes.Name = "tsmOrderXmlNodes";
            this.tsmOrderXmlNodes.Size = new System.Drawing.Size(338, 26);
            this.tsmOrderXmlNodes.Text = "Order Xml Nodes";
            // 
            // FrmShowCharNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlMain);
            this.MainMenuStrip = this.MSMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmShowCharNumber";
            this.Text = "Const Tools Windows";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.grpFunctionality.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MSMainMenu.ResumeLayout(false);
            this.MSMainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessageInformation;
        private System.Windows.Forms.Button btnShowCharNumber;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox grpFunctionality;
        private System.Windows.Forms.MenuStrip MSMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFunctions;
        private System.Windows.Forms.ToolStripMenuItem tsmCopyToMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyClose;
        private System.Windows.Forms.ToolStripMenuItem tsmAppToForm;
        private System.Windows.Forms.ToolStripMenuItem tsmAppAndClose;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnGeneralNewGuid;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripMenuItem tsmShowFormattedJson;
        private System.Windows.Forms.ToolStripMenuItem tsmShowNoFormattedJson;
        private System.Windows.Forms.CheckBox chbAutoWrap;
        private System.Windows.Forms.Button btnFontBig;
        private System.Windows.Forms.Button btnFontDefault;
        private System.Windows.Forms.Button btnFontSmall;
        private System.Windows.Forms.Button btnPickFont;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem tsmCopyFromMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmOrderJsonProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmShowFormattedXml;
        private System.Windows.Forms.ToolStripMenuItem tsmShowNoFormattedXml;
        private System.Windows.Forms.ToolStripMenuItem tsmOrderXmlNodes;
    }
}