namespace AXT_Frontend
{
    partial class AboutForm
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
            this.versionHeaderLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.developersHeaderLabel = new System.Windows.Forms.Label();
            this.jdbDeveloperLinkLabel = new System.Windows.Forms.LinkLabel();
            this.relatedGroupsLabel = new System.Windows.Forms.Label();
            this.aaaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.XMedSystemLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // versionHeaderLabel
            // 
            this.versionHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionHeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.versionHeaderLabel.Name = "versionHeaderLabel";
            this.versionHeaderLabel.Size = new System.Drawing.Size(260, 23);
            this.versionHeaderLabel.TabIndex = 0;
            this.versionHeaderLabel.Text = "Version";
            this.versionHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.Location = new System.Drawing.Point(12, 32);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(260, 23);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "verison";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // developersHeaderLabel
            // 
            this.developersHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developersHeaderLabel.Location = new System.Drawing.Point(12, 55);
            this.developersHeaderLabel.Name = "developersHeaderLabel";
            this.developersHeaderLabel.Size = new System.Drawing.Size(260, 23);
            this.developersHeaderLabel.TabIndex = 2;
            this.developersHeaderLabel.Text = "Developers";
            this.developersHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jdbDeveloperLinkLabel
            // 
            this.jdbDeveloperLinkLabel.Location = new System.Drawing.Point(12, 78);
            this.jdbDeveloperLinkLabel.Name = "jdbDeveloperLinkLabel";
            this.jdbDeveloperLinkLabel.Size = new System.Drawing.Size(260, 23);
            this.jdbDeveloperLinkLabel.TabIndex = 3;
            this.jdbDeveloperLinkLabel.TabStop = true;
            this.jdbDeveloperLinkLabel.Text = "@JDBoronkas";
            this.jdbDeveloperLinkLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.jdbDeveloperLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.jdbDeveloperLinkLabel_LinkClicked);
            // 
            // relatedGroupsLabel
            // 
            this.relatedGroupsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatedGroupsLabel.Location = new System.Drawing.Point(12, 178);
            this.relatedGroupsLabel.Name = "relatedGroupsLabel";
            this.relatedGroupsLabel.Size = new System.Drawing.Size(260, 23);
            this.relatedGroupsLabel.TabIndex = 4;
            this.relatedGroupsLabel.Text = "Related Groups";
            this.relatedGroupsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aaaLinkLabel
            // 
            this.aaaLinkLabel.Location = new System.Drawing.Point(12, 201);
            this.aaaLinkLabel.Name = "aaaLinkLabel";
            this.aaaLinkLabel.Size = new System.Drawing.Size(260, 23);
            this.aaaLinkLabel.TabIndex = 5;
            this.aaaLinkLabel.TabStop = true;
            this.aaaLinkLabel.Text = "Arma Air Assault";
            this.aaaLinkLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aaaLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aaaLinkLabel_LinkClicked);
            // 
            // XMedSystemLabel
            // 
            this.XMedSystemLabel.Location = new System.Drawing.Point(12, 224);
            this.XMedSystemLabel.Name = "XMedSystemLabel";
            this.XMedSystemLabel.Size = new System.Drawing.Size(260, 23);
            this.XMedSystemLabel.TabIndex = 6;
            this.XMedSystemLabel.TabStop = true;
            this.XMedSystemLabel.Text = "XMedSys by X39";
            this.XMedSystemLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.XMedSystemLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.XMedSystemLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 257);
            this.Controls.Add(this.XMedSystemLabel);
            this.Controls.Add(this.aaaLinkLabel);
            this.Controls.Add(this.relatedGroupsLabel);
            this.Controls.Add(this.jdbDeveloperLinkLabel);
            this.Controls.Add(this.developersHeaderLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.versionHeaderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label versionHeaderLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label developersHeaderLabel;
        private System.Windows.Forms.LinkLabel jdbDeveloperLinkLabel;
        private System.Windows.Forms.Label relatedGroupsLabel;
        private System.Windows.Forms.LinkLabel aaaLinkLabel;
        private System.Windows.Forms.LinkLabel XMedSystemLabel;

    }
}