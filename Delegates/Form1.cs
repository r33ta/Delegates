namespace Delegates
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        public delegate void AddToList_(string value);


        void AddToList(string value) => list.Items.Add(value);
        void AddToSecondList_(string value) => list2.Items.Add(value);


        private void btn_Click(object sender, EventArgs e)
        {
            AddToList_ d = new AddToList_(AddToList);
            d += AddToSecondList_;

            Form2 form2 = new Form2(d);
            form2.Show();
        }
    }
}