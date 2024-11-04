namespace appFP_NET.secuenciales
{
    public partial class Frm01 : Form
    {
        public Frm01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int varones = int.Parse(txtVarones.Text);
            int mujeres = int.Parse(txtMujeres.Text);

            int total = varones + mujeres;
            double pVarones = varones * 100 / total;
            double pMujeres = mujeres * 100 / total;

            lblPVarones.Text = string.Format("{0:0.00} %", pVarones);
            lblPMujeres.Text = string.Format("{0:0.00} %", pMujeres);
        }

        private void txtVarones_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
