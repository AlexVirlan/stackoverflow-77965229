namespace Stackoverflow77965229
{
    public partial class FrmMain : Form
    {
        FrmBrowser _frmBrowser;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _frmBrowser = new FrmBrowser();
            _frmBrowser.Show();
        }
    }
}
