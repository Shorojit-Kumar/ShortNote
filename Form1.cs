namespace ShortNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            gvd.Rows.Add(text1.Text, description1.Text);
            text1.Text = "";
            description1.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (gvd.CurrentRow != null)
                gvd.Rows.RemoveAt(gvd.CurrentRow.Index);
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (gvd.CurrentRow != null)
            {
                gvd.CurrentRow.Cells["Title"].Value = text1.Text;
                gvd.CurrentRow.Cells["Descriptions"].Value = description1.Text;
                text1.Text = "";
                description1.Text = "";
            }
        }

        private void gvd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvd.CurrentRow != null)
            {

            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}