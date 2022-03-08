using System;

namespace WinFormGameUi
{
    public partial class RowItemForGame
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
            this.ButtonUnit1 = new System.Windows.Forms.Button();
            this.ButtonUnit2 = new System.Windows.Forms.Button();
            this.ButtonUnit3 = new System.Windows.Forms.Button();
            this.ButtonUnit4 = new System.Windows.Forms.Button();
            this.ButtonExecute = new System.Windows.Forms.Button();
            this.ResBtn1 = new System.Windows.Forms.Button();
            this.ResBtn2 = new System.Windows.Forms.Button();
            this.ResBtn3 = new System.Windows.Forms.Button();
            this.ResBtn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // ButtonUnit1
           
            this.ButtonUnit1.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonUnit1.Location = new System.Drawing.Point(-1, 0);
            this.ButtonUnit1.Name = "ButtonUnit1";
            this.ButtonUnit1.Size = new System.Drawing.Size(65, 65);
            this.ButtonUnit1.TabIndex = 0;
            this.ButtonUnit1.UseVisualStyleBackColor = false;
            this.ButtonUnit1.Click += new System.EventHandler(this.ButtonUnitColor_Click);
            this.ButtonUnit1.Click += new System.EventHandler(this.allButtonsHandlerCheckIfTiOpenExecuteButton_Click);

            // ButtonUnit2

            this.ButtonUnit2.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonUnit2.Location = new System.Drawing.Point(70, 0);
            this.ButtonUnit2.Name = "ButtonUnit2";
            this.ButtonUnit2.Size = new System.Drawing.Size(65, 65);
            this.ButtonUnit2.TabIndex = 1;
            this.ButtonUnit2.UseVisualStyleBackColor = false;
            this.ButtonUnit2.Click += new System.EventHandler(this.ButtonUnitColor_Click);
            this.ButtonUnit2.Click += new System.EventHandler(this.allButtonsHandlerCheckIfTiOpenExecuteButton_Click);

            // ButtonUnit3

            this.ButtonUnit3.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonUnit3.Location = new System.Drawing.Point(141, 0);
            this.ButtonUnit3.Name = "ButtonUnit3";
            this.ButtonUnit3.Size = new System.Drawing.Size(65, 65);
            this.ButtonUnit3.TabIndex = 2;
            this.ButtonUnit3.UseVisualStyleBackColor = false;
            this.ButtonUnit3.Click += new System.EventHandler(this.ButtonUnitColor_Click);
            this.ButtonUnit3.Click += new System.EventHandler(this.allButtonsHandlerCheckIfTiOpenExecuteButton_Click);

            // ButtonUnit4

            this.ButtonUnit4.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonUnit4.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonUnit4.Location = new System.Drawing.Point(212, 2);
            this.ButtonUnit4.Name = "ButtonUnit4";
            this.ButtonUnit4.Size = new System.Drawing.Size(65, 65);
            this.ButtonUnit4.TabIndex = 3;
            this.ButtonUnit4.UseMnemonic = false;
            this.ButtonUnit4.UseVisualStyleBackColor = false;
            this.ButtonUnit4.Click += new System.EventHandler(this.ButtonUnitColor_Click);
            this.ButtonUnit4.Click += new System.EventHandler(this.allButtonsHandlerCheckIfTiOpenExecuteButton_Click);

            // ButtonExecute

            this.ButtonExecute.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonExecute.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonExecute.Location = new System.Drawing.Point(293, 23);
            this.ButtonExecute.Name = "ButtonExecute";
            this.ButtonExecute.Size = new System.Drawing.Size(54, 29);
            this.ButtonExecute.TabIndex = 4;
            this.ButtonExecute.Text = "-->>";
            this.ButtonExecute.UseVisualStyleBackColor = false;
            this.ButtonExecute.Click += new EventHandler(this.ButtonExecute_Click);
             
            // ResBtn1
             
            this.ResBtn1.BackColor = System.Drawing.SystemColors.Control;
            this.ResBtn1.Location = new System.Drawing.Point(365, 12);
            this.ResBtn1.Name = "ResBtn1";
            this.ResBtn1.Size = new System.Drawing.Size(27, 23);
            this.ResBtn1.TabIndex = 5;
            this.ResBtn1.UseVisualStyleBackColor = false;
             
            // ResBtn2
             
            this.ResBtn2.BackColor = System.Drawing.SystemColors.Control;
            this.ResBtn2.Location = new System.Drawing.Point(398, 12);
            this.ResBtn2.Name = "ResBtn2";
            this.ResBtn2.Size = new System.Drawing.Size(27, 23);
            this.ResBtn2.TabIndex = 6;
            this.ResBtn2.UseVisualStyleBackColor = false;
            
            // ResBtn3
            
            this.ResBtn3.BackColor = System.Drawing.SystemColors.Control;
            this.ResBtn3.Location = new System.Drawing.Point(365, 41);
            this.ResBtn3.Name = "ResBtn3";
            this.ResBtn3.Size = new System.Drawing.Size(27, 23);
            this.ResBtn3.TabIndex = 7;
            this.ResBtn3.UseVisualStyleBackColor = false;
            
            // ResBtn4
             
            this.ResBtn4.BackColor = System.Drawing.SystemColors.Control;
            this.ResBtn4.Location = new System.Drawing.Point(398, 41);
            this.ResBtn4.Name = "ResBtn4";
            this.ResBtn4.Size = new System.Drawing.Size(27, 23);
            this.ResBtn4.TabIndex = 8;
            this.ResBtn4.UseVisualStyleBackColor = false;
             
            // RowItemForGame
             
            this.AcceptButton = this.ResBtn1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(427, 68);
            this.ControlBox = false;
            this.Controls.Add(this.ResBtn4);
            this.Controls.Add(this.ResBtn3);
            this.Controls.Add(this.ResBtn2);
            this.Controls.Add(this.ResBtn1);
            this.Controls.Add(this.ButtonExecute);
            this.Controls.Add(this.ButtonUnit4);
            this.Controls.Add(this.ButtonUnit3);
            this.Controls.Add(this.ButtonUnit2);
            this.Controls.Add(this.ButtonUnit1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RowItemForGame";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button ButtonUnit1;
        public System.Windows.Forms.Button ButtonUnit2;
        public System.Windows.Forms.Button ButtonUnit3;
        public System.Windows.Forms.Button ButtonUnit4;
        public System.Windows.Forms.Button ButtonExecute;
        public System.Windows.Forms.Button ResBtn1;
        public System.Windows.Forms.Button ResBtn2;
        public System.Windows.Forms.Button ResBtn3;
        public System.Windows.Forms.Button ResBtn4;
    }
}