namespace Kustia_Trading_Agency_Management
{
    partial class Home_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_form));
            this.calendarClock1 = new CalendarClock.CalendarClock();
            this.Management_groupbox = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Calculation_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.Management_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarClock1
            // 
            this.calendarClock1.BackColor = System.Drawing.Color.Transparent;
            this.calendarClock1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calendarClock1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarClock1.Location = new System.Drawing.Point(817, 212);
            this.calendarClock1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.calendarClock1.Name = "calendarClock1";
            this.calendarClock1.Size = new System.Drawing.Size(256, 321);
            this.calendarClock1.TabIndex = 104;
            // 
            // Management_groupbox
            // 
            this.Management_groupbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Management_groupbox.BackgroundImage")));
            this.Management_groupbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Management_groupbox.Controls.Add(this.button4);
            this.Management_groupbox.Controls.Add(this.button3);
            this.Management_groupbox.Controls.Add(this.button2);
            this.Management_groupbox.Controls.Add(this.button1);
            this.Management_groupbox.Controls.Add(this.Calculation_button);
            this.Management_groupbox.Location = new System.Drawing.Point(23, 28);
            this.Management_groupbox.Name = "Management_groupbox";
            this.Management_groupbox.Size = new System.Drawing.Size(760, 505);
            this.Management_groupbox.TabIndex = 106;
            this.Management_groupbox.TabStop = false;
            this.Management_groupbox.Text = "Management";
            this.Management_groupbox.Enter += new System.EventHandler(this.Management_groupbox_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(517, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 195);
            this.button3.TabIndex = 3;
            this.button3.Text = "Report";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(18, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(295, 195);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ship";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(405, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 195);
            this.button1.TabIndex = 1;
            this.button1.Text = "Track";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculation_button
            // 
            this.Calculation_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calculation_button.BackgroundImage")));
            this.Calculation_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Calculation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculation_button.Location = new System.Drawing.Point(18, 38);
            this.Calculation_button.Name = "Calculation_button";
            this.Calculation_button.Size = new System.Drawing.Size(353, 195);
            this.Calculation_button.TabIndex = 0;
            this.Calculation_button.Text = "Shifting";
            this.Calculation_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Calculation_button.UseVisualStyleBackColor = true;
            this.Calculation_button.Click += new System.EventHandler(this.Calculation_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImage = global::Kustia_Trading_Agency_Management.Properties.Resources.appbar_lock;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(899, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 99);
            this.panel1.TabIndex = 105;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(319, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 194);
            this.button4.TabIndex = 4;
            this.button4.Text = "Customer";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Home_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1097, 568);
            this.Controls.Add(this.Management_groupbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calendarClock1);
            this.Name = "Home_form";
            this.Text = "Home";
            this.Management_groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CalendarClock.CalendarClock calendarClock1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Management_groupbox;
        private System.Windows.Forms.Button Calculation_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}