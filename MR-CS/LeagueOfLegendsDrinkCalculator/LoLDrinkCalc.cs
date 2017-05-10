using System.Windows.Forms;
using MrMathParser;
using System;

namespace LeagueOfLegendsDrinkCalculator
{
    public partial class LoLDrinkCalc : Form
    {
        public LoLDrinkCalc()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        public void InitializeCustomComponents()
        {
            killsTb.TextChanged += TbChanged;
            assistsTb.TextChanged += TbChanged;
        }

        public void TbChanged(object s, EventArgs args)
        {
            numberOfDrinksLb.Text = CalculateDrinks().ToString();
        }

        private int? CalculateDrinks()
        {
            var kills = GetTextBoxValue(killsTb.Text);
            var assists = GetTextBoxValue(assistsTb.Text);

            var killPoints = (kills ?? 0) * 2;
            var assistsPoints = assists ?? 0;

            return (killPoints + assistsPoints) / 5;
        }

        private int? GetTextBoxValue(string tbText)
        {
            if (!string.IsNullOrEmpty(tbText))
                try
                {
                    return Expression.Eval(tbText);
                } catch(Exception e)
                {
                    // ignore
                }
            return null;
        }
    }
}
