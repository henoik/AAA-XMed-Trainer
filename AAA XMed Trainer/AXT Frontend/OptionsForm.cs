using System.Windows.Forms;

namespace AXT_Frontend
{
    public partial class OptionsForm : Form
    {
        private static OptionsForm instance;

        public static OptionsForm GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new OptionsForm();
                }

                return instance;
            }
        }

        private OptionsForm()
        {
            InitializeComponent();
        }
    }
}
