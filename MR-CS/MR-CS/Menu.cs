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
            launchOwDrinkCalcBtn.Click += (s, args) => LaunchForm<OverwatchDrinkCalculator.OverwatchDrinkCalculator>();
        }

        public void LaunchForm<T>() where T : Form, new()
        {
            var f = new T();
            this.Hide();
            f.Closed += (s, args) =>
            {
                DesktopLocation = f.DesktopLocation;
                this.Show();
            };
            f.Show();
            f.DesktopLocation = this.DesktopLocation;
        }
    }
}
