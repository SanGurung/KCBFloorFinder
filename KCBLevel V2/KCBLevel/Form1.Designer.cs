namespace KCBLevel
{
    partial class KCBFloorForm
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
            System.Windows.Forms.Timer autoDetectFloorTimer;
            this.floor_detect = new System.Windows.Forms.Button();
            this.autoDetectCheck = new System.Windows.Forms.CheckBox();
            this.Tick5 = new System.Windows.Forms.PictureBox();
            this.Tick4 = new System.Windows.Forms.PictureBox();
            this.Tick3 = new System.Windows.Forms.PictureBox();
            this.Tick2 = new System.Windows.Forms.PictureBox();
            this.Tick1 = new System.Windows.Forms.PictureBox();
            this.TickG = new System.Windows.Forms.PictureBox();
            this.TickB = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.audioLevelBar = new System.Windows.Forms.ProgressBar();
            this.showRSSI = new System.Windows.Forms.Button();
            autoDetectFloorTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Tick5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickB)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoDetectFloorTimer
            // 
            autoDetectFloorTimer.Enabled = true;
            autoDetectFloorTimer.Interval = 9000;
            autoDetectFloorTimer.Tick += new System.EventHandler(this.autoDetectFloorTimer_Tick);
            // 
            // floor_detect
            // 
            this.floor_detect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floor_detect.ForeColor = System.Drawing.Color.Black;
            this.floor_detect.Location = new System.Drawing.Point(76, 251);
            this.floor_detect.Name = "floor_detect";
            this.floor_detect.Size = new System.Drawing.Size(177, 39);
            this.floor_detect.TabIndex = 3;
            this.floor_detect.Text = "Detect Floor?";
            this.floor_detect.UseVisualStyleBackColor = true;
            this.floor_detect.Click += new System.EventHandler(this.floor_detect_Click);
            // 
            // autoDetectCheck
            // 
            this.autoDetectCheck.AutoSize = true;
            this.autoDetectCheck.BackColor = System.Drawing.Color.Transparent;
            this.autoDetectCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoDetectCheck.Location = new System.Drawing.Point(76, 216);
            this.autoDetectCheck.Name = "autoDetectCheck";
            this.autoDetectCheck.Size = new System.Drawing.Size(188, 29);
            this.autoDetectCheck.TabIndex = 5;
            this.autoDetectCheck.Text = "Auto detect floor";
            this.autoDetectCheck.UseVisualStyleBackColor = false;
            // 
            // Tick5
            // 
            this.Tick5.BackColor = System.Drawing.Color.Transparent;
            this.Tick5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Tick5.Enabled = false;
            this.Tick5.Image = global::KCBLevel.Properties.Resources.tick1;
            this.Tick5.Location = new System.Drawing.Point(504, 132);
            this.Tick5.Name = "Tick5";
            this.Tick5.Size = new System.Drawing.Size(42, 39);
            this.Tick5.TabIndex = 6;
            this.Tick5.TabStop = false;
            this.Tick5.Visible = false;
            // 
            // Tick4
            // 
            this.Tick4.BackColor = System.Drawing.Color.Transparent;
            this.Tick4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Tick4.Image = global::KCBLevel.Properties.Resources.tick1;
            this.Tick4.Location = new System.Drawing.Point(504, 175);
            this.Tick4.Name = "Tick4";
            this.Tick4.Size = new System.Drawing.Size(42, 39);
            this.Tick4.TabIndex = 7;
            this.Tick4.TabStop = false;
            this.Tick4.Visible = false;
            // 
            // Tick3
            // 
            this.Tick3.BackColor = System.Drawing.Color.Transparent;
            this.Tick3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Tick3.Image = global::KCBLevel.Properties.Resources.tick1;
            this.Tick3.Location = new System.Drawing.Point(504, 212);
            this.Tick3.Name = "Tick3";
            this.Tick3.Size = new System.Drawing.Size(42, 39);
            this.Tick3.TabIndex = 8;
            this.Tick3.TabStop = false;
            this.Tick3.Visible = false;
            // 
            // Tick2
            // 
            this.Tick2.BackColor = System.Drawing.Color.Transparent;
            this.Tick2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Tick2.Image = global::KCBLevel.Properties.Resources.tick1;
            this.Tick2.Location = new System.Drawing.Point(504, 251);
            this.Tick2.Name = "Tick2";
            this.Tick2.Size = new System.Drawing.Size(42, 39);
            this.Tick2.TabIndex = 9;
            this.Tick2.TabStop = false;
            this.Tick2.Visible = false;
            // 
            // Tick1
            // 
            this.Tick1.BackColor = System.Drawing.Color.Transparent;
            this.Tick1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Tick1.Image = global::KCBLevel.Properties.Resources.tick1;
            this.Tick1.Location = new System.Drawing.Point(504, 286);
            this.Tick1.Name = "Tick1";
            this.Tick1.Size = new System.Drawing.Size(42, 39);
            this.Tick1.TabIndex = 10;
            this.Tick1.TabStop = false;
            // 
            // TickG
            // 
            this.TickG.BackColor = System.Drawing.Color.Transparent;
            this.TickG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TickG.Image = global::KCBLevel.Properties.Resources.tick1;
            this.TickG.Location = new System.Drawing.Point(504, 323);
            this.TickG.Name = "TickG";
            this.TickG.Size = new System.Drawing.Size(42, 39);
            this.TickG.TabIndex = 11;
            this.TickG.TabStop = false;
            this.TickG.Visible = false;
            // 
            // TickB
            // 
            this.TickB.BackColor = System.Drawing.Color.Transparent;
            this.TickB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TickB.Image = global::KCBLevel.Properties.Resources.tick1;
            this.TickB.Location = new System.Drawing.Point(504, 363);
            this.TickB.Name = "TickB";
            this.TickB.Size = new System.Drawing.Size(42, 39);
            this.TickB.TabIndex = 12;
            this.TickB.TabStop = false;
            this.TickB.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(677, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(163, 17);
            this.toolStripStatusLabel1.Text = "Designed by: Santosh Gurung";
            // 
            // audioLevelBar
            // 
            this.audioLevelBar.Location = new System.Drawing.Point(76, 323);
            this.audioLevelBar.Name = "audioLevelBar";
            this.audioLevelBar.Size = new System.Drawing.Size(177, 20);
            this.audioLevelBar.TabIndex = 15;
            // 
            // showRSSI
            // 
            this.showRSSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRSSI.Location = new System.Drawing.Point(76, 363);
            this.showRSSI.Name = "showRSSI";
            this.showRSSI.Size = new System.Drawing.Size(177, 43);
            this.showRSSI.TabIndex = 16;
            this.showRSSI.Text = "Show RSSI";
            this.showRSSI.UseVisualStyleBackColor = true;
            this.showRSSI.Click += new System.EventHandler(this.showRSSI_Click);
            // 
            // KCBFloorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::KCBLevel.Properties.Resources.Level_PSD1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(677, 451);
            this.Controls.Add(this.showRSSI);
            this.Controls.Add(this.audioLevelBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TickB);
            this.Controls.Add(this.TickG);
            this.Controls.Add(this.Tick1);
            this.Controls.Add(this.Tick2);
            this.Controls.Add(this.Tick3);
            this.Controls.Add(this.Tick4);
            this.Controls.Add(this.Tick5);
            this.Controls.Add(this.autoDetectCheck);
            this.Controls.Add(this.floor_detect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KCBFloorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KCBFloorForm_FormClosing);
            this.Load += new System.EventHandler(this.KCBFloorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tick5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickB)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button floor_detect;
        private System.Windows.Forms.CheckBox autoDetectCheck;
        private System.Windows.Forms.PictureBox Tick5;
        private System.Windows.Forms.PictureBox Tick4;
        private System.Windows.Forms.PictureBox Tick3;
        private System.Windows.Forms.PictureBox Tick2;
        private System.Windows.Forms.PictureBox Tick1;
        private System.Windows.Forms.PictureBox TickG;
        private System.Windows.Forms.PictureBox TickB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ProgressBar audioLevelBar;
        private System.Windows.Forms.Button showRSSI;


    }
}

