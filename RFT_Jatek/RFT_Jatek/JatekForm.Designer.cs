namespace RFT_Jatek
{
    partial class JatekForm
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
            this.jatekter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jatekter)).BeginInit();
            this.SuspendLayout();
            // 
            // jatekter
            // 
            this.jatekter.BackColor = System.Drawing.Color.Navy;
            this.jatekter.Location = new System.Drawing.Point(13, 13);
            this.jatekter.Margin = new System.Windows.Forms.Padding(4);
            this.jatekter.Name = "jatekter";
            this.jatekter.Size = new System.Drawing.Size(956, 612);
            this.jatekter.TabIndex = 0;
            this.jatekter.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 629);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Játékos:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_name.ForeColor = System.Drawing.Color.Maroon;
            this.lb_name.Location = new System.Drawing.Point(88, 629);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(15, 20);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "-";
            // 
            // JatekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jatekter);
            this.Name = "JatekForm";
            this.Text = "Játék";
            ((System.ComponentModel.ISupportInitialize)(this.jatekter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox jatekter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_name;
    }
}