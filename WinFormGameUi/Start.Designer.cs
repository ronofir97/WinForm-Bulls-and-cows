using System;

namespace WinFormGameUi
{
    public partial class Start
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.buttonNumberOfChances = new System.Windows.Forms.Button();
            this.buttonStasrt = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // buttonNumberOfChances

            this.buttonNumberOfChances.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonNumberOfChances.Location = new System.Drawing.Point(51, 27);
            this.buttonNumberOfChances.Name = "buttonNumberOfChances";
            this.buttonNumberOfChances.Size = new System.Drawing.Size(365, 68);
            this.buttonNumberOfChances.TabIndex = 0;
            this.buttonNumberOfChances.Text = "Number of choices: 4";
            this.buttonNumberOfChances.UseVisualStyleBackColor = false;
            this.buttonNumberOfChances.Click += new System.EventHandler(this.ButtonBumberOfChoices_Click);

            // buttonStasrt

            this.buttonStasrt.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonStasrt.Location = new System.Drawing.Point(297, 186);
            this.buttonStasrt.Name = "buttonStasrt";
            this.buttonStasrt.Size = new System.Drawing.Size(142, 46);
            this.buttonStasrt.TabIndex = 1;
            this.buttonStasrt.Text = "Start";
            this.buttonStasrt.UseVisualStyleBackColor = false;
            this.buttonStasrt.Click += new EventHandler(this.ButtonStart_Click);
            
            // Start
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(451, 244);
            this.Controls.Add(this.buttonStasrt);
            this.Controls.Add(this.buttonNumberOfChances);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bool Pgia";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNumberOfChances;
        private System.Windows.Forms.Button buttonStasrt;
    }
}