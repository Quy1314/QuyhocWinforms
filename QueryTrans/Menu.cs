namespace QueryTrans
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sql_to_Excel ste = new Sql_to_Excel();
            ste.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sql_to_XML ste = new Sql_to_XML();
            ste.ShowDialog();
        }
    }
}
