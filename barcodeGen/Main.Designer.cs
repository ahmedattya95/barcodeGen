namespace barcodeGen
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.metroSetPanel1 = new MetroSet_UI.Controls.MetroSetPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnStartGenerateBarcode = new System.Windows.Forms.Button();
            this.MainPanel = new MetroSet_UI.Controls.MetroSetPanel();
            this.metroSetPanel3 = new MetroSet_UI.Controls.MetroSetPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdiocodeEAN8 = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.rdiocodeEAN13 = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.rdiocode39 = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.rdiocode128 = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkShowLabel = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.metroSetPanel2 = new MetroSet_UI.Controls.MetroSetPanel();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.metroSetPanel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.metroSetPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroSetPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetPanel1
            // 
            this.metroSetPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel1.BorderThickness = 1;
            this.metroSetPanel1.Controls.Add(this.richTextBox1);
            this.metroSetPanel1.Controls.Add(this.btnStartGenerateBarcode);
            this.metroSetPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroSetPanel1.IsDerivedStyle = true;
            this.metroSetPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel1.Name = "metroSetPanel1";
            this.metroSetPanel1.Size = new System.Drawing.Size(169, 367);
            this.metroSetPanel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel1.StyleManager = null;
            this.metroSetPanel1.TabIndex = 3;
            this.metroSetPanel1.ThemeAuthor = "Narwin";
            this.metroSetPanel1.ThemeName = "MetroLite";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(169, 296);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.ZoomFactor = 2F;
            // 
            // btnStartGenerateBarcode
            // 
            this.btnStartGenerateBarcode.BackColor = System.Drawing.Color.Black;
            this.btnStartGenerateBarcode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartGenerateBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGenerateBarcode.ForeColor = System.Drawing.Color.White;
            this.btnStartGenerateBarcode.Location = new System.Drawing.Point(0, 296);
            this.btnStartGenerateBarcode.Name = "btnStartGenerateBarcode";
            this.btnStartGenerateBarcode.Size = new System.Drawing.Size(169, 71);
            this.btnStartGenerateBarcode.TabIndex = 4;
            this.btnStartGenerateBarcode.Text = "Start Generate Barcode";
            this.btnStartGenerateBarcode.UseVisualStyleBackColor = false;
            this.btnStartGenerateBarcode.Click += new System.EventHandler(this.btnStartGenerateBarcode_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundColor = System.Drawing.Color.White;
            this.MainPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MainPanel.BorderThickness = 1;
            this.MainPanel.Controls.Add(this.metroSetPanel3);
            this.MainPanel.Controls.Add(this.metroSetPanel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.IsDerivedStyle = true;
            this.MainPanel.Location = new System.Drawing.Point(12, 70);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(580, 367);
            this.MainPanel.Style = MetroSet_UI.Enums.Style.Light;
            this.MainPanel.StyleManager = null;
            this.MainPanel.TabIndex = 4;
            this.MainPanel.ThemeAuthor = "Narwin";
            this.MainPanel.ThemeName = "MetroLite";
            // 
            // metroSetPanel3
            // 
            this.metroSetPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroSetPanel3.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroSetPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel3.BorderThickness = 3;
            this.metroSetPanel3.Controls.Add(this.groupBox2);
            this.metroSetPanel3.Controls.Add(this.groupBox1);
            this.metroSetPanel3.Controls.Add(this.metroSetPanel2);
            this.metroSetPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroSetPanel3.IsDerivedStyle = true;
            this.metroSetPanel3.Location = new System.Drawing.Point(169, 0);
            this.metroSetPanel3.Name = "metroSetPanel3";
            this.metroSetPanel3.Size = new System.Drawing.Size(411, 364);
            this.metroSetPanel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel3.StyleManager = null;
            this.metroSetPanel3.TabIndex = 4;
            this.metroSetPanel3.ThemeAuthor = "Narwin";
            this.metroSetPanel3.ThemeName = "MetroLite";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.rdiocodeEAN8);
            this.groupBox2.Controls.Add(this.rdiocodeEAN13);
            this.groupBox2.Controls.Add(this.rdiocode39);
            this.groupBox2.Controls.Add(this.rdiocode128);
            this.groupBox2.Location = new System.Drawing.Point(200, 100);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(200, 264);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "barcode Type";
            // 
            // rdiocodeEAN8
            // 
            this.rdiocodeEAN8.BackgroundColor = System.Drawing.Color.White;
            this.rdiocodeEAN8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rdiocodeEAN8.Checked = false;
            this.rdiocodeEAN8.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.rdiocodeEAN8.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.rdiocodeEAN8.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.rdiocodeEAN8.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdiocodeEAN8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdiocodeEAN8.Group = 0;
            this.rdiocodeEAN8.IsDerivedStyle = true;
            this.rdiocodeEAN8.Location = new System.Drawing.Point(8, 79);
            this.rdiocodeEAN8.Name = "rdiocodeEAN8";
            this.rdiocodeEAN8.Size = new System.Drawing.Size(184, 17);
            this.rdiocodeEAN8.Style = MetroSet_UI.Enums.Style.Light;
            this.rdiocodeEAN8.StyleManager = null;
            this.rdiocodeEAN8.TabIndex = 5;
            this.rdiocodeEAN8.Text = "EAN8";
            this.rdiocodeEAN8.ThemeAuthor = "Narwin";
            this.rdiocodeEAN8.ThemeName = "MetroLite";
            // 
            // rdiocodeEAN13
            // 
            this.rdiocodeEAN13.BackgroundColor = System.Drawing.Color.White;
            this.rdiocodeEAN13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rdiocodeEAN13.Checked = false;
            this.rdiocodeEAN13.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.rdiocodeEAN13.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.rdiocodeEAN13.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.rdiocodeEAN13.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdiocodeEAN13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdiocodeEAN13.Group = 0;
            this.rdiocodeEAN13.IsDerivedStyle = true;
            this.rdiocodeEAN13.Location = new System.Drawing.Point(8, 62);
            this.rdiocodeEAN13.Name = "rdiocodeEAN13";
            this.rdiocodeEAN13.Size = new System.Drawing.Size(184, 17);
            this.rdiocodeEAN13.Style = MetroSet_UI.Enums.Style.Light;
            this.rdiocodeEAN13.StyleManager = null;
            this.rdiocodeEAN13.TabIndex = 4;
            this.rdiocodeEAN13.Text = "EAN13";
            this.rdiocodeEAN13.ThemeAuthor = "Narwin";
            this.rdiocodeEAN13.ThemeName = "MetroLite";
            // 
            // rdiocode39
            // 
            this.rdiocode39.BackgroundColor = System.Drawing.Color.White;
            this.rdiocode39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rdiocode39.Checked = false;
            this.rdiocode39.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.rdiocode39.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.rdiocode39.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.rdiocode39.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdiocode39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdiocode39.Group = 0;
            this.rdiocode39.IsDerivedStyle = true;
            this.rdiocode39.Location = new System.Drawing.Point(8, 45);
            this.rdiocode39.Name = "rdiocode39";
            this.rdiocode39.Size = new System.Drawing.Size(184, 17);
            this.rdiocode39.Style = MetroSet_UI.Enums.Style.Light;
            this.rdiocode39.StyleManager = null;
            this.rdiocode39.TabIndex = 3;
            this.rdiocode39.Text = "CODE39";
            this.rdiocode39.ThemeAuthor = "Narwin";
            this.rdiocode39.ThemeName = "MetroLite";
            // 
            // rdiocode128
            // 
            this.rdiocode128.BackgroundColor = System.Drawing.Color.White;
            this.rdiocode128.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rdiocode128.Checked = true;
            this.rdiocode128.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.rdiocode128.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            this.rdiocode128.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.rdiocode128.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdiocode128.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdiocode128.Group = 0;
            this.rdiocode128.IsDerivedStyle = true;
            this.rdiocode128.Location = new System.Drawing.Point(8, 28);
            this.rdiocode128.Name = "rdiocode128";
            this.rdiocode128.Size = new System.Drawing.Size(184, 17);
            this.rdiocode128.Style = MetroSet_UI.Enums.Style.Light;
            this.rdiocode128.StyleManager = null;
            this.rdiocode128.TabIndex = 2;
            this.rdiocode128.Text = "CODE128";
            this.rdiocode128.ThemeAuthor = "Narwin";
            this.rdiocode128.ThemeName = "MetroLite";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.chkShowLabel);
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(200, 264);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chkShowLabel
            // 
            this.chkShowLabel.BackColor = System.Drawing.Color.Transparent;
            this.chkShowLabel.BackgroundColor = System.Drawing.Color.White;
            this.chkShowLabel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chkShowLabel.Checked = false;
            this.chkShowLabel.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chkShowLabel.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chkShowLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowLabel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chkShowLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkShowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkShowLabel.IsDerivedStyle = true;
            this.chkShowLabel.Location = new System.Drawing.Point(8, 28);
            this.chkShowLabel.Name = "chkShowLabel";
            this.chkShowLabel.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.chkShowLabel.Size = new System.Drawing.Size(184, 16);
            this.chkShowLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.chkShowLabel.StyleManager = null;
            this.chkShowLabel.TabIndex = 0;
            this.chkShowLabel.Text = "ShowLabel";
            this.chkShowLabel.ThemeAuthor = "Narwin";
            this.chkShowLabel.ThemeName = "MetroLite";
            this.chkShowLabel.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.chkShowLabel_CheckedChanged);
            // 
            // metroSetPanel2
            // 
            this.metroSetPanel2.BackgroundColor = System.Drawing.Color.White;
            this.metroSetPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetPanel2.BorderThickness = 1;
            this.metroSetPanel2.Controls.Add(this.picPreview);
            this.metroSetPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroSetPanel2.IsDerivedStyle = true;
            this.metroSetPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroSetPanel2.Name = "metroSetPanel2";
            this.metroSetPanel2.Size = new System.Drawing.Size(411, 100);
            this.metroSetPanel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetPanel2.StyleManager = null;
            this.metroSetPanel2.TabIndex = 3;
            this.metroSetPanel2.ThemeAuthor = "Narwin";
            this.metroSetPanel2.ThemeName = "MetroLite";
            // 
            // picPreview
            // 
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPreview.Image = ((System.Drawing.Image)(resources.GetObject("picPreview.Image")));
            this.picPreview.Location = new System.Drawing.Point(0, 0);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(411, 100);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(567, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnExit);
            // 
            // Main
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderThickness = 2F;
            this.ClientSize = new System.Drawing.Size(604, 449);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.btnClose);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarcodeGen";
            this.TextAlign = MetroSet_UI.Enums.TextAlign.Center;
            this.ThemeAuthor = "AAA";
            this.UseSlideAnimation = true;
            this.metroSetPanel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.metroSetPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.metroSetPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel1;
        private RichTextBox richTextBox1;
        private MetroSet_UI.Controls.MetroSetPanel MainPanel;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel3;
        private Button btnStartGenerateBarcode;
        private Button btnClose;
        private GroupBox groupBox2;
        private MetroSet_UI.Controls.MetroSetRadioButton rdiocode128;
        private MetroSet_UI.Controls.MetroSetRadioButton metroSetRadioButton2;
        private MetroSet_UI.Controls.MetroSetRadioButton metroSetRadioButton1;
        private GroupBox groupBox1;
        private MetroSet_UI.Controls.MetroSetCheckBox chkShowLabel;
        private MetroSet_UI.Controls.MetroSetPanel metroSetPanel2;
        private PictureBox picPreview;
        private MetroSet_UI.Controls.MetroSetRadioButton rdiocode39;
        private MetroSet_UI.Controls.MetroSetRadioButton rdiocodeEAN13;
        private MetroSet_UI.Controls.MetroSetRadioButton rdiocodeEAN8;
    }
}