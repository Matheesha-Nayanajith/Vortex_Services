
namespace Vortex_Services
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.indicator = new System.Windows.Forms.PictureBox();
            this.checkout = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.vehicle = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.update = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.search = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkin = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.home = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.indicator);
            this.panel1.Controls.Add(this.checkout);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.vehicle);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.checkin);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 729);
            this.panel1.TabIndex = 0;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.Black;
            this.indicator.Location = new System.Drawing.Point(0, 70);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(10, 59);
            this.indicator.TabIndex = 12;
            this.indicator.TabStop = false;
            // 
            // checkout
            // 
            this.checkout.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(25)))));
            this.checkout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.checkout.IconColor = System.Drawing.Color.White;
            this.checkout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.checkout.Location = new System.Drawing.Point(0, 615);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(93, 59);
            this.checkout.TabIndex = 11;
            this.checkout.UseVisualStyleBackColor = true;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 565);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(93, 50);
            this.panel9.TabIndex = 10;
            // 
            // vehicle
            // 
            this.vehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.vehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(25)))));
            this.vehicle.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.vehicle.IconColor = System.Drawing.Color.White;
            this.vehicle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vehicle.Location = new System.Drawing.Point(0, 506);
            this.vehicle.Name = "vehicle";
            this.vehicle.Size = new System.Drawing.Size(93, 59);
            this.vehicle.TabIndex = 9;
            this.vehicle.UseVisualStyleBackColor = true;
            this.vehicle.Click += new System.EventHandler(this.vehicle_Click);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 456);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(93, 50);
            this.panel8.TabIndex = 8;
            // 
            // update
            // 
            this.update.Dock = System.Windows.Forms.DockStyle.Top;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(25)))));
            this.update.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.update.IconColor = System.Drawing.Color.White;
            this.update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.update.Location = new System.Drawing.Point(0, 397);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(93, 59);
            this.update.TabIndex = 7;
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 347);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(93, 50);
            this.panel7.TabIndex = 6;
            // 
            // search
            // 
            this.search.Dock = System.Windows.Forms.DockStyle.Top;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(25)))));
            this.search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.search.IconColor = System.Drawing.Color.White;
            this.search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.search.Location = new System.Drawing.Point(0, 288);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(93, 59);
            this.search.TabIndex = 5;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 238);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(93, 50);
            this.panel6.TabIndex = 4;
            // 
            // checkin
            // 
            this.checkin.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(25)))));
            this.checkin.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.checkin.IconColor = System.Drawing.Color.White;
            this.checkin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.checkin.Location = new System.Drawing.Point(0, 179);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(93, 59);
            this.checkin.TabIndex = 3;
            this.checkin.UseVisualStyleBackColor = true;
            this.checkin.Click += new System.EventHandler(this.checkin_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 129);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(93, 50);
            this.panel5.TabIndex = 2;
            // 
            // home
            // 
            this.home.Dock = System.Windows.Forms.DockStyle.Top;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(25)))));
            this.home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.home.IconColor = System.Drawing.Color.White;
            this.home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.home.Location = new System.Drawing.Point(0, 70);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(93, 59);
            this.home.TabIndex = 1;
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(93, 70);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(93, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 44);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(861, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 44);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 44);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(93, 44);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(931, 685);
            this.mainpanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 729);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mainpanel;
        private FontAwesome.Sharp.IconButton checkout;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton vehicle;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton update;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton search;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton checkin;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton home;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox indicator;
    }
}

