namespace Modern_Web_Browser
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
            this.txtUrl = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.lnkNewTab = new MetroFramework.Controls.MetroLink();
            this.lnkForward = new MetroFramework.Controls.MetroLink();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.lnkGo = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtUrl.CustomButton.Image = null;
            this.txtUrl.CustomButton.Location = new System.Drawing.Point(494, 1);
            this.txtUrl.CustomButton.Name = "";
            this.txtUrl.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrl.CustomButton.TabIndex = 1;
            this.txtUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrl.CustomButton.UseSelectable = true;
            this.txtUrl.CustomButton.Visible = false;
            this.txtUrl.Lines = new string[0];
            this.txtUrl.Location = new System.Drawing.Point(85, 64);
            this.txtUrl.MaxLength = 32767;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionLength = 0;
            this.txtUrl.SelectionStart = 0;
            this.txtUrl.ShortcutsEnabled = true;
            this.txtUrl.Size = new System.Drawing.Size(516, 23);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.UseSelectable = true;
            this.txtUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabControl
            // 
            this.metroTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl.Location = new System.Drawing.Point(24, 94);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.Size = new System.Drawing.Size(653, 411);
            this.metroTabControl.TabIndex = 5;
            this.metroTabControl.UseSelectable = true;
            // 
            // lnkNewTab
            // 
            this.lnkNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkNewTab.BackgroundImage = global::Modern_Web_Browser.Properties.Resources.Pluse_2_20;
            this.lnkNewTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lnkNewTab.Location = new System.Drawing.Point(648, 63);
            this.lnkNewTab.Name = "lnkNewTab";
            this.lnkNewTab.Size = new System.Drawing.Size(29, 23);
            this.lnkNewTab.TabIndex = 6;
            this.lnkNewTab.UseSelectable = true;
            this.lnkNewTab.Click += new System.EventHandler(this.linkNewTab_Click);
            // 
            // lnkForward
            // 
            this.lnkForward.BackgroundImage = global::Modern_Web_Browser.Properties.Resources.circle_arrow_forward_next_glyph_20;
            this.lnkForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lnkForward.Location = new System.Drawing.Point(54, 64);
            this.lnkForward.Name = "lnkForward";
            this.lnkForward.Size = new System.Drawing.Size(25, 23);
            this.lnkForward.TabIndex = 1;
            this.lnkForward.UseSelectable = true;
            this.lnkForward.Click += new System.EventHandler(this.lnkForward_Click);
            // 
            // lnkBack
            // 
            this.lnkBack.BackgroundImage = global::Modern_Web_Browser.Properties.Resources.circle_arrow_back_previous_glyph_20;
            this.lnkBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lnkBack.Location = new System.Drawing.Point(24, 64);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(24, 23);
            this.lnkBack.TabIndex = 0;
            this.lnkBack.UseSelectable = true;
            this.lnkBack.Click += new System.EventHandler(this.lnkBack_Click);
            // 
            // lnkGo
            // 
            this.lnkGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkGo.BackgroundImage = global::Modern_Web_Browser.Properties.Resources.go_forward_next_arrow_20;
            this.lnkGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lnkGo.Location = new System.Drawing.Point(607, 63);
            this.lnkGo.Name = "lnkGo";
            this.lnkGo.Size = new System.Drawing.Size(35, 23);
            this.lnkGo.TabIndex = 7;
            this.lnkGo.UseSelectable = true;
            this.lnkGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.lnkGo);
            this.Controls.Add(this.lnkNewTab);
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lnkForward);
            this.Controls.Add(this.lnkBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Web Browser";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

            }

        #endregion
        private MetroFramework.Controls.MetroLink lnkBack;
        private MetroFramework.Controls.MetroLink lnkForward;
        private MetroFramework.Controls.MetroTextBox txtUrl;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroLink lnkNewTab;
        private MetroFramework.Controls.MetroLink lnkGo;
        }
    }

