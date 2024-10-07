namespace forms2
{
    partial class fcmm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 173);
            this.label1.TabIndex = 0;
            this.label1.Text = "tôi là lable";
            this.label1.MouseEnter += new System.EventHandler(this.vaoLable);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clickonbutton1);
            // 
            // fcmm
            // 
            this.AccessibleName = "";
            this.BackgroundImage = global::forms2.Properties.Resources._1286013;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "fcmm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.MouseEnter += new System.EventHandler(this.vaoform);
            this.MouseLeave += new System.EventHandler(this.rakhoichuongtrinh);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

