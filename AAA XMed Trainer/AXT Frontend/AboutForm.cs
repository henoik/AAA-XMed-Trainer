using System.Diagnostics;
using System.Windows.Forms;

namespace AXT_Frontend
{
    public partial class AboutForm : Form
    {
        private static AboutForm instance;

        public static AboutForm GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new AboutForm();
                }

                return instance;
            }
        }

        private AboutForm()
        {
            InitializeComponent();
            versionLabel.Text = Application.ProductVersion;
        }

        private void jdbDeveloperLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/jdboronkas");
        }

        private void aaaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://armaairassault.invisionzone.com/");
        }

        private void XMedSystemLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.armaholic.com/page.php?id=23617");
        }
    }
}
