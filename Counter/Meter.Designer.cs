namespace Counter
{
    partial class Meter
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lblDay = new Label();
            lblClock = new Label();
            lblMinute = new Label();
            lblSecond = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnReset = new Button();
            btnTour = new Button();
            lstTour = new ListBox();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblDay
            // 
            lblDay.BorderStyle = BorderStyle.FixedSingle;
            lblDay.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            lblDay.Location = new Point(25, 42);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(123, 100);
            lblDay.TabIndex = 0;
            lblDay.Text = "00";
            lblDay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClock
            // 
            lblClock.BorderStyle = BorderStyle.FixedSingle;
            lblClock.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            lblClock.Location = new Point(174, 42);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(123, 100);
            lblClock.TabIndex = 1;
            lblClock.Text = "00";
            lblClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMinute
            // 
            lblMinute.BorderStyle = BorderStyle.FixedSingle;
            lblMinute.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            lblMinute.Location = new Point(321, 42);
            lblMinute.Name = "lblMinute";
            lblMinute.Size = new Size(123, 100);
            lblMinute.TabIndex = 2;
            lblMinute.Text = "00";
            lblMinute.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSecond
            // 
            lblSecond.BorderStyle = BorderStyle.FixedSingle;
            lblSecond.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            lblSecond.Location = new Point(466, 42);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(123, 100);
            lblSecond.TabIndex = 3;
            lblSecond.Text = "00";
            lblSecond.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(25, 177);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(123, 47);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.Location = new Point(183, 177);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(123, 47);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(25, 263);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(123, 47);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset To";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnTour
            // 
            btnTour.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnTour.Location = new Point(183, 263);
            btnTour.Name = "btnTour";
            btnTour.Size = new Size(123, 47);
            btnTour.TabIndex = 7;
            btnTour.Text = "Tour Around";
            btnTour.UseVisualStyleBackColor = true;
            btnTour.Click += btnTour_Click;
            // 
            // lstTour
            // 
            lstTour.FormattingEnabled = true;
            lstTour.ItemHeight = 15;
            lstTour.Location = new Point(324, 180);
            lstTour.Name = "lstTour";
            lstTour.Size = new Size(265, 139);
            lstTour.TabIndex = 8;
            // 
            // Meter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 360);
            Controls.Add(lstTour);
            Controls.Add(btnTour);
            Controls.Add(btnReset);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblSecond);
            Controls.Add(lblMinute);
            Controls.Add(lblClock);
            Controls.Add(lblDay);
            Name = "Meter";
            Text = "Meter";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblDay;
        private Label lblClock;
        private Label lblMinute;
        private Label lblSecond;
        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
        private Button btnTour;
        private ListBox lstTour;
    }
}