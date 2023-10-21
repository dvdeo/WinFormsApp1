namespace WinFormsApp1
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();

        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = openFileDialog.FileName;
                MessageBox.Show(fileName);
            }
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form new_mdi_child = new Form();
            new_mdi_child.Text = "Child Form";
            new_mdi_child.MdiParent = this;
            new_mdi_child.ShowDialog();
        }

        private void frm_main_Activated(object sender, EventArgs e)
        {
            //frm_login login = new frm_login();
            //login.ShowDialog();
        }

        private void frm_main_Shown(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.ShowDialog();
        }
    }
}