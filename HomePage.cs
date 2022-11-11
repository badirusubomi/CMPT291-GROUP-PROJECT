namespace CMPT291_GROUP_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;
            sidePanel.Hide();
        }

        public void loadForms(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidePanel.Show();
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;
            loadForms(new searchform(this));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Show();
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel.Show();
            sidePanel.Height = button3.Height;
            sidePanel.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidePanel.Show();
            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidePanel.Show();
            sidePanel.Height = button5.Height;
            sidePanel.Top = button5.Top;
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchFormuc1_Load(object sender, EventArgs e)
        {

        }

        private void searchFormuc1_Load_1(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Hide();
        }
    }
}