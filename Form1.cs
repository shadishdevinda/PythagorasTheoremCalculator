using System.Buffers.Text;
using System.Drawing.Text;

namespace PythagorasTheoremCalculator
{
    public partial class PythagorasTheoremCalculator : Form
    {
        // Declare shared variables
        double attitude, baselg, hypotenuse;
        bool Attitude, Base, Hypotenuse;

        public PythagorasTheoremCalculator()
        {
            InitializeComponent();
        }

        private void FindBT_Click(object sender, EventArgs e)
        {

            // Try to parse the input values from the text boxes
            Attitude = double.TryParse(AttitudeTB.Text, out attitude);
            Base = double.TryParse(BaseTB.Text, out baselg);
            Hypotenuse = double.TryParse(HypotenuseTB.Text, out hypotenuse);

            //Check which sides are provided and calculate the missing one
            int isTwoSides = (Attitude ? 1 : 0) + (Base ? 1 : 0) + (Hypotenuse ? 1 : 0);

            if (isTwoSides == 3)
            {
                MessageBox.Show("All sides are provided.", "Input Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (isTwoSides == 2)
            {
                if ((Attitude && attitude <= 0) || (Base && baselg <= 0) || (Hypotenuse && hypotenuse <= 0))
                {
                    MessageBox.Show("Please enter positive numbers!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Call the calucaltion function to calculate the pythagoras's theorem
                Calculation();
            }
            else
            {
                MessageBox.Show("Please enter any two side positive values!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void Calculation()
        {
            // Check which sides are provided and calculate the missing one
            if (Attitude && Base && !Hypotenuse)
            {
                // Calculate the missing Hypotenuse side based on the Attitude && Base
                hypotenuse = Math.Sqrt(Math.Pow(attitude, 2) + Math.Pow(baselg, 2));
                HypotenuseTB.Text = hypotenuse.ToString();
            }
            else if (Hypotenuse && Base && !Attitude)
            {
                // Calculate the missing Attitude side based on the Hypotenuse && Base
                attitude = Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(baselg, 2));
                AttitudeTB.Text = attitude.ToString();
            }
            else if (Hypotenuse && Attitude && !Base)
            {
                // Calculate the missing Base side based on the Hypotenuse && Attitude
                baselg = Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(attitude, 2));
                BaseTB.Text = baselg.ToString();
            }
        }

        // Clear the text boxes when the Clear button is clicked
        private void ClearTB_Click(object sender, EventArgs e)
        {
            AttitudeTB.Clear();
            BaseTB.Clear();
            HypotenuseTB.Clear();

        }
    }
}
