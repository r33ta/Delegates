namespace Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void AddToList_(string value);

        void AddToList(string value)
        {
            list.Items.Add(value);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(AddToList);
            form2.Show();

        }
    }
}