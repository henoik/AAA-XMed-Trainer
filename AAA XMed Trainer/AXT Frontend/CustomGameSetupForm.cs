using System.Windows.Forms;

namespace AXT_Frontend
{
    public partial class CustomGameSetupForm : Form
    {
        private static CustomGameSetupForm instance;

        public static CustomGameSetupForm GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new CustomGameSetupForm();
                }

                return instance;
            }
        }

        private CustomGameSetupForm()
        {
            InitializeComponent();
        }
    }
}
