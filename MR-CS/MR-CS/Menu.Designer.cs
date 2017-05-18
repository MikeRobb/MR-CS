namespace MR_CS
{
    partial class Menu
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
            this.launchLolDrinkCalcBtn = new System.Windows.Forms.Button();
            this.launchOwDrinkCalcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // launchLolDrinkCalcBtn
            // 
            this.launchLolDrinkCalcBtn.Location = new System.Drawing.Point(13, 12);
            this.launchLolDrinkCalcBtn.Name = "launchLolDrinkCalcBtn";
            this.launchLolDrinkCalcBtn.Size = new System.Drawing.Size(259, 23);
            this.launchLolDrinkCalcBtn.TabIndex = 0;
            this.launchLolDrinkCalcBtn.Text = "LoL Drink Calc";
            this.launchLolDrinkCalcBtn.UseVisualStyleBackColor = true;
            // 
            // launchOwDrinkCalcBtn
            // 
            this.launchOwDrinkCalcBtn.Location = new System.Drawing.Point(13, 41);
            this.launchOwDrinkCalcBtn.Name = "launchOwDrinkCalcBtn";
            this.launchOwDrinkCalcBtn.Size = new System.Drawing.Size(259, 23);
            this.launchOwDrinkCalcBtn.TabIndex = 0;
            this.launchOwDrinkCalcBtn.Text = "OW Drink Calc";
            this.launchOwDrinkCalcBtn.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.launchOwDrinkCalcBtn);
            this.Controls.Add(this.launchLolDrinkCalcBtn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button launchLolDrinkCalcBtn;
        private System.Windows.Forms.Button launchOwDrinkCalcBtn;
    }
}