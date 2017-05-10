namespace LeagueOfLegendsDrinkCalculator
{
    partial class LoLDrinkCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.killsTb = new System.Windows.Forms.TextBox();
            this.killsLb = new System.Windows.Forms.Label();
            this.assistsTb = new System.Windows.Forms.TextBox();
            this.assistsLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfDrinksLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // killsTb
            // 
            this.killsTb.Location = new System.Drawing.Point(59, 10);
            this.killsTb.Name = "killsTb";
            this.killsTb.Size = new System.Drawing.Size(273, 20);
            this.killsTb.TabIndex = 1;
            // 
            // killsLb
            // 
            this.killsLb.AutoSize = true;
            this.killsLb.Location = new System.Drawing.Point(13, 13);
            this.killsLb.Name = "killsLb";
            this.killsLb.Size = new System.Drawing.Size(25, 13);
            this.killsLb.TabIndex = 100;
            this.killsLb.Text = "Kills";
            // 
            // assistsTb
            // 
            this.assistsTb.Location = new System.Drawing.Point(59, 36);
            this.assistsTb.Name = "assistsTb";
            this.assistsTb.Size = new System.Drawing.Size(273, 20);
            this.assistsTb.TabIndex = 2;
            // 
            // assistsLb
            // 
            this.assistsLb.AutoSize = true;
            this.assistsLb.Location = new System.Drawing.Point(13, 39);
            this.assistsLb.Name = "assistsLb";
            this.assistsLb.Size = new System.Drawing.Size(39, 13);
            this.assistsLb.TabIndex = 101;
            this.assistsLb.Text = "Assists";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Drinks:";
            // 
            // numberOfDrinksLb
            // 
            this.numberOfDrinksLb.AutoSize = true;
            this.numberOfDrinksLb.Location = new System.Drawing.Point(62, 75);
            this.numberOfDrinksLb.Name = "numberOfDrinksLb";
            this.numberOfDrinksLb.Size = new System.Drawing.Size(14, 13);
            this.numberOfDrinksLb.TabIndex = 103;
            this.numberOfDrinksLb.Text = "#";
            // 
            // LoLDrinkCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(342, 106);
            this.Controls.Add(this.numberOfDrinksLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assistsLb);
            this.Controls.Add(this.killsLb);
            this.Controls.Add(this.assistsTb);
            this.Controls.Add(this.killsTb);
            this.Name = "LoLDrinkCalc";
            this.Text = "LoL Drink Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox killsTb;
        private System.Windows.Forms.Label killsLb;
        private System.Windows.Forms.TextBox assistsTb;
        private System.Windows.Forms.Label assistsLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOfDrinksLb;
    }
}

