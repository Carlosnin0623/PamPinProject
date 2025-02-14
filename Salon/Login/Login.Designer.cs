namespace Salon
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drakeUITextBox1 = new DrakeUI.Framework.DrakeUITextBox();
            this.drakeUITextBox2 = new DrakeUI.Framework.DrakeUITextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Closelogin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Closelogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(82)))), ((int)(((byte)(134)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 445);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(82)))), ((int)(((byte)(134)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(529, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // drakeUITextBox1
            // 
            this.drakeUITextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(82)))), ((int)(((byte)(134)))));
            this.drakeUITextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drakeUITextBox1.FillColor = System.Drawing.SystemColors.Window;
            this.drakeUITextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUITextBox1.Location = new System.Drawing.Point(444, 163);
            this.drakeUITextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUITextBox1.Maximum = 2147483647D;
            this.drakeUITextBox1.Minimum = -2147483648D;
            this.drakeUITextBox1.Name = "drakeUITextBox1";
            this.drakeUITextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.drakeUITextBox1.Radius = 0;
            this.drakeUITextBox1.RectColor = System.Drawing.Color.Silver;
            this.drakeUITextBox1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUITextBox1.Size = new System.Drawing.Size(249, 29);
            this.drakeUITextBox1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITextBox1.TabIndex = 7;
            this.drakeUITextBox1.Text = "Usuario";
            // 
            // drakeUITextBox2
            // 
            this.drakeUITextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(82)))), ((int)(((byte)(134)))));
            this.drakeUITextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drakeUITextBox2.FillColor = System.Drawing.Color.White;
            this.drakeUITextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUITextBox2.Location = new System.Drawing.Point(444, 222);
            this.drakeUITextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUITextBox2.Maximum = 2147483647D;
            this.drakeUITextBox2.Minimum = -2147483648D;
            this.drakeUITextBox2.Name = "drakeUITextBox2";
            this.drakeUITextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.drakeUITextBox2.Radius = 0;
            this.drakeUITextBox2.RectColor = System.Drawing.Color.Silver;
            this.drakeUITextBox2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUITextBox2.Size = new System.Drawing.Size(249, 29);
            this.drakeUITextBox2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITextBox2.TabIndex = 8;
            this.drakeUITextBox2.Text = "Contraseña";
            // 
            // Closelogin
            // 
            this.Closelogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closelogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(82)))), ((int)(((byte)(134)))));
            this.Closelogin.Image = global::Salon.Properties.Resources.icons8_multiply_23;
            this.Closelogin.Location = new System.Drawing.Point(714, 5);
            this.Closelogin.Name = "Closelogin";
            this.Closelogin.Size = new System.Drawing.Size(28, 24);
            this.Closelogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Closelogin.TabIndex = 143;
            this.Closelogin.TabStop = false;
            this.Closelogin.Click += new System.EventHandler(this.Closelogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Salon.Properties.Resources.front_view_woman_getting_her_manicure_done_at_the_salon_scaled_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 144;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Closelogin);
            this.Controls.Add(this.drakeUITextBox2);
            this.Controls.Add(this.drakeUITextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Closelogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private DrakeUI.Framework.DrakeUITextBox drakeUITextBox1;
        private DrakeUI.Framework.DrakeUITextBox drakeUITextBox2;
        private System.Windows.Forms.PictureBox Closelogin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}