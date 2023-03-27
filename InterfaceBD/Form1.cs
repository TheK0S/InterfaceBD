namespace InterfaceBD
{
    public partial class Form1 : Form
    {
        string? DataSource;
        string? InitialCatalog;
                
        public Form1()
        {
            InitializeComponent();
        }

        private void connection_Click(object sender, EventArgs e)
        {
            connectionPanel.Visible = true;
            connectionPanel.Dock = DockStyle.Fill;

            createPanel.Visible = false;
            readPanel.Visible = false;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            createPanel.Visible = true;
            createPanel.Dock = DockStyle.Fill;

            connectionPanel.Visible = false;
            readPanel.Visible = false;
        }

        private void read_Click(object sender, EventArgs e)
        {
            readPanel.Visible = true;
            readPanel.Dock = DockStyle.Fill;

            connectionPanel.Visible = false;
            createPanel.Visible = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void connectionPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}