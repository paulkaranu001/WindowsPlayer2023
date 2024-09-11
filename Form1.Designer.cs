namespace WindowsPlayer2023
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            panel1 = new Panel();
            btnLoad = new Button();
            button2 = new Button();
            btnStart = new Button();
            btbPause = new Button();
            btnStop = new Button();
            trackBar1 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)MediaPlayer).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // MediaPlayer
            // 
            MediaPlayer.Enabled = true;
            MediaPlayer.Location = new Point(12, 12);
            MediaPlayer.Name = "MediaPlayer";
            MediaPlayer.OcxState = (AxHost.State)resources.GetObject("MediaPlayer.OcxState");
            MediaPlayer.Size = new Size(803, 141);
            MediaPlayer.TabIndex = 0;
            MediaPlayer.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(btbPause);
            panel1.Controls.Add(btnStop);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnLoad);
            panel1.Location = new Point(-8, 663);
            panel1.Name = "panel1";
            panel1.Size = new Size(834, 125);
            panel1.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoad.BackColor = Color.FromArgb(174, 168, 245);
            btnLoad.Cursor = Cursors.Cross;
            btnLoad.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.FromArgb(192, 43, 43);
            btnLoad.Location = new Point(16, 14);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(146, 53);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load";
            btnLoad.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(223, 42);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStart.BackColor = Color.FromArgb(174, 168, 245);
            btnStart.Cursor = Cursors.Cross;
            btnStart.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.FromArgb(192, 43, 43);
            btnStart.Location = new Point(168, 14);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(146, 53);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnStart.UseVisualStyleBackColor = false;
            // 
            // btbPause
            // 
            btbPause.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btbPause.BackColor = Color.FromArgb(174, 168, 245);
            btbPause.Cursor = Cursors.Cross;
            btbPause.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btbPause.ForeColor = Color.FromArgb(192, 43, 43);
            btbPause.Location = new Point(472, 14);
            btbPause.Name = "btbPause";
            btbPause.Size = new Size(146, 53);
            btbPause.TabIndex = 4;
            btbPause.Text = "Pause";
            btbPause.TextImageRelation = TextImageRelation.TextBeforeImage;
            btbPause.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            btnStop.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStop.BackColor = Color.FromArgb(174, 168, 245);
            btnStop.Cursor = Cursors.Cross;
            btnStop.DialogResult = DialogResult.Continue;
            btnStop.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStop.ForeColor = Color.FromArgb(192, 43, 43);
            btnStop.Location = new Point(320, 14);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(146, 53);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnStop.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.Silver;
            trackBar1.Location = new Point(627, 27);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(207, 56);
            trackBar1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(147, 49, 31);
            label1.Location = new Point(624, 4);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 6;
            label1.Text = "Volume";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(147, 49, 31);
            label2.Location = new Point(756, 4);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 7;
            label2.Text = "0:00 /0:00";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 179);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(809, 464);
            listBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(147, 49, 31);
            label3.Location = new Point(379, 156);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 7;
            label3.Text = "My Play List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(160, 243, 173);
            ClientSize = new Size(823, 774);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(MediaPlayer);
            Name = "Form1";
            Padding = new Padding(5);
            Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)MediaPlayer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private Panel panel1;
        private Button btnLoad;
        private Button button2;
        private Button btbPause;
        private Button btnStop;
        private Button btnStart;
        private TrackBar trackBar1;
        private Label label2;
        private Label label1;
        private ListBox listBox1;
        private Label label3;
    }
}
