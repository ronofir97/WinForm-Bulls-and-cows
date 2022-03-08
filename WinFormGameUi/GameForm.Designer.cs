using System.Windows.Forms;
using System.Drawing;

namespace WinFormGameUi
{
    public partial class GameForm
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
            this.ButtonComputerSelect1 = new System.Windows.Forms.Button();
            this.ButtonComputerSelect2 = new System.Windows.Forms.Button();
            this.ButtonComputerSelect3 = new System.Windows.Forms.Button();
            this.ButtonComputerSelect4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
             
            // ButtonComputerSelect1
             
            this.ButtonComputerSelect1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonComputerSelect1.Location = new System.Drawing.Point(38, 32);
            this.ButtonComputerSelect1.Name = "ButtonComputerSelect1";
            this.ButtonComputerSelect1.Size = new System.Drawing.Size(65, 65);
            this.ButtonComputerSelect1.TabIndex = 0;
            this.ButtonComputerSelect1.UseVisualStyleBackColor = false;
             
            // ButtonComputerSelect2
             
            this.ButtonComputerSelect2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonComputerSelect2.Location = new System.Drawing.Point(109, 32);
            this.ButtonComputerSelect2.Name = "ButtonComputerSelect2";
            this.ButtonComputerSelect2.Size = new System.Drawing.Size(65, 65);
            this.ButtonComputerSelect2.TabIndex = 1;
            this.ButtonComputerSelect2.UseVisualStyleBackColor = false;
             
            // ButtonComputerSelect3
             
            this.ButtonComputerSelect3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonComputerSelect3.Location = new System.Drawing.Point(180, 32);
            this.ButtonComputerSelect3.Name = "ButtonComputerSelect3";
            this.ButtonComputerSelect3.Size = new System.Drawing.Size(65, 65);
            this.ButtonComputerSelect3.TabIndex = 2;
            this.ButtonComputerSelect3.UseVisualStyleBackColor = false;
             
            // ButtonComputerSelect4
            
            this.ButtonComputerSelect4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonComputerSelect4.Location = new System.Drawing.Point(251, 32);
            this.ButtonComputerSelect4.Name = "ButtonComputerSelect4";
            this.ButtonComputerSelect4.Size = new System.Drawing.Size(65, 65);
            this.ButtonComputerSelect4.TabIndex = 3;
            this.ButtonComputerSelect4.UseVisualStyleBackColor = false;
             
            // GameForm
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(494, 244);
            this.Controls.Add(this.ButtonComputerSelect4);
            this.Controls.Add(this.ButtonComputerSelect3);
            this.Controls.Add(this.ButtonComputerSelect2);
            this.Controls.Add(this.ButtonComputerSelect1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonComputerSelect1;
        private System.Windows.Forms.Button ButtonComputerSelect2;
        private System.Windows.Forms.Button ButtonComputerSelect3;
        private System.Windows.Forms.Button ButtonComputerSelect4;
    }
}