namespace appFP_NET.secuenciales
{
    public partial class Frm09 : Form
    {
        public Frm09()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            int c1 = numero / 1000; numero %= 1000;
            int c2 = numero / 100; numero %= 100;
            int c3 = numero / 100; 
            int c4 = numero % 10;

            txtSuma.Text = "" + (c1 + c2 + c3 + c4); 
        }
    }
}
