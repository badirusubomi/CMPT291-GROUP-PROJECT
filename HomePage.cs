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
            /*this.panel1.Hide();
            this.panel2.Hide();
            this.panel3.Hide();
            this.button1.Hide();
            this.button2.Hide();
            this.button3.Hide();
            this.button4.Hide();
            this.button5.Hide();
            this.button6.Hide();
            this.button7.Hide();
            this.button8.Hide();
            this.button9.Hide();
            this.button10.Hide();*/
            hideForms(this);
            this.loadBigForms(new LogInPage(this));
        }
        public void hideForms(object Form)
        {
            this.panel1.Hide();
            this.panel2.Hide();
            this.panel3.Hide();
            this.button1.Hide();
            this.button2.Hide();
            this.button3.Hide();
            this.button4.Hide();
            this.button5.Hide();
            this.button6.Hide();
            this.button7.Hide();
            this.button8.Hide();
            this.button9.Hide();
            this.button10.Hide();
        }
        public void showForms(object Form)
        {
            this.panel1.Show();
            this.panel2.Show();
            this.panel3.Show();
            this.button1.Show();
            this.button2.Show();
            this.button3.Show();
            this.button4.Show();
            this.button5.Show();
            this.button6.Show();
            this.button7.Show();
            this.button8.Show();
            this.button9.Show();
            this.button10.Show();
        }
        public void loadBigForms(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            this.mainpanel.SetBounds(0,0,this.Width,this.Height);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        public void loadForms(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            this.mainpanel.SetBounds(this.panel1.Width, this.panel3.Height, this.Width, this.Height);
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
            hideForms(this);
            this.loadBigForms(new ProfilePage(this));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel.Show();
            sidePanel.Height = button3.Height;
            sidePanel.Top = button3.Top;
            hideForms(this);
            this.loadBigForms(new Categories(this));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidePanel.Show();
            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;
            hideForms(this);
            this.loadBigForms(new AboutPage(this));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidePanel.Show();
            sidePanel.Height = button5.Height;
            sidePanel.Top = button5.Top;
            hideForms(this);
            this.loadBigForms(new FAQpage(this));
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

        private void button11_Click(object sender, EventArgs e)
        {
            sidePanel.Show();
            sidePanel.Height = button5.Height;
            sidePanel.Top = button5.Top;
            hideForms(this);
            this.loadBigForms(new SalesReport(this));
        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signOut_Click(object sender, EventArgs e)
        {
            this.hideForms(this);
            this.loadBigForms(new Form1());
        }
    }
}