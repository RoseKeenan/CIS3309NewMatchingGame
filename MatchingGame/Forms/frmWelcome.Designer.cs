namespace MatchingGame.Forms
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.lblCutePairsWelcome = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCutePairsWelcome
            // 
            this.lblCutePairsWelcome.AutoSize = true;
            this.lblCutePairsWelcome.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutePairsWelcome.Location = new System.Drawing.Point(473, 61);
            this.lblCutePairsWelcome.Name = "lblCutePairsWelcome";
            this.lblCutePairsWelcome.Size = new System.Drawing.Size(377, 99);
            this.lblCutePairsWelcome.TabIndex = 1;
            this.lblCutePairsWelcome.Text = "Cute Pairs";
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.Color.RosyBrown;
            this.txtInstructions.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructions.Location = new System.Drawing.Point(141, 200);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.Size = new System.Drawing.Size(1015, 556);
            this.txtInstructions.TabIndex = 2;
            this.txtInstructions.Text = resources.GetString("txtInstructions.Text");
            this.txtInstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Chartreuse;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(169, 914);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(343, 147);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START GAME";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(726, 914);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(343, 147);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 819);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Name:";
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(522, 821);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(483, 38);
            this.txtEnterName.TabIndex = 1;
            // 
            // frmWelcome
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1380, 1169);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.lblCutePairsWelcome);
            this.Name = "frmWelcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCutePairsWelcome;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterName;
    }
}

