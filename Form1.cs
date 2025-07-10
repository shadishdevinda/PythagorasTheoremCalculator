namespace PythagorasTheoremCalculator
{
    public partial class PythagorasTheoremCalculator : Form
    {
        public PythagorasTheoremCalculator()
        {
            InitializeComponent();
        }

        private void FindBT_Click(object sender, EventArgs e)
        {
            AttitudeTB.Text = double.TryParse(AttitudeTB.Text, out double a) ? a.ToString() : "Invalid input";
            BaseTB.Text = double.TryParse(BaseTB.Text, out double b) ? b.ToString() : "Invalid input";
            HypotenuseTB.Text = double.TryParse(HypotenuseTB.Text, out double c) ? c.ToString() : "Invalid input";

            if (double.TryParse(AttitudeTB.Text, out a) && (double.TryParse(BaseTB.Text, out b) && (!double.TryParse(HypotenuseTB.Text, out c))))
            {
                c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                HypotenuseTB.Text = c.ToString();
            }
            else if (double.TryParse(BaseTB.Text, out b) && (double.TryParse(HypotenuseTB.Text, out c) && (!double.TryParse(AttitudeTB.Text, out a))))
            {
                a = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2));
                AttitudeTB.Text = a.ToString();
            }
            else if (double.TryParse(HypotenuseTB.Text, out c) && (double.TryParse(AttitudeTB.Text, out a) && (!double.TryParse(BaseTB.Text, out b))))
            {
                b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
                BaseTB.Text = b.ToString();
            }
            else
            {
                AttitudeTB.Text = a.ToString("Invalid input");
                BaseTB.Text = b.ToString("Invalid input");
                HypotenuseTB.Text = c.ToString("Invalid input");

                MessageBox.Show("Please enter valid numbers for the sides of the triangle.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTB_Click(object sender, EventArgs e)
        {
            AttitudeTB.Clear();
            BaseTB.Clear();
            HypotenuseTB.Clear();

        }
    }
}
