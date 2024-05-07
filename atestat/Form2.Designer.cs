namespace atestat
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblsk = new System.Windows.Forms.Label();
            this.pickey = new System.Windows.Forms.PictureBox();
            this.usaNivel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pickey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usaNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(217, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 50);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblsk
            // 
            this.lblsk.AutoSize = true;
            this.lblsk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblsk.Location = new System.Drawing.Point(205, 9);
            this.lblsk.Name = "lblsk";
            this.lblsk.Size = new System.Drawing.Size(0, 15);
            this.lblsk.TabIndex = 3;
            // 
            // pickey
            // 
            this.pickey.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pickey.Image = ((System.Drawing.Image)(resources.GetObject("pickey.Image")));
            this.pickey.Location = new System.Drawing.Point(217, 43);
            this.pickey.Name = "pickey";
            this.pickey.Size = new System.Drawing.Size(50, 24);
            this.pickey.TabIndex = 4;
            this.pickey.TabStop = false;
            this.pickey.Tag = "key";
            // 
            // usaNivel
            // 
            this.usaNivel.Image = ((System.Drawing.Image)(resources.GetObject("usaNivel.Image")));
            this.usaNivel.Location = new System.Drawing.Point(56, 43);
            this.usaNivel.Name = "usaNivel";
            this.usaNivel.Size = new System.Drawing.Size(75, 62);
            this.usaNivel.TabIndex = 6;
            this.usaNivel.TabStop = false;
            this.usaNivel.Tag = "usa";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.usaNivel);
            this.Controls.Add(this.pickey);
            this.Controls.Add(this.lblsk);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrisonBreak";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pickey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usaNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label lblsk;
        private PictureBox pickey;
        private PictureBox usaNivel;
    }
}