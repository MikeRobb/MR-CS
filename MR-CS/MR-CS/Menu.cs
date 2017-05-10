using System.Windows.Forms;
using LeagueOfLegendsDrinkCalculator;

namespace MR_CS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            launchLolDrinkCalcBtn.Click += (s, args) => LaunchForm<LoLDrinkCalc>();
        }

        public void LaunchForm<T>() where T : Form, new()
        {
            this.Hide();
            var f = new T();
            f.Closed += (s, args) => this.Show();
            f.Show();
        }
    }
}
