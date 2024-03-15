using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace GHCardsApp
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
            button1 = new Button();
            textBox1 = new TextBox();
            trackBar1 = new TrackBar();
            trackBarText = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton13 = new RadioButton();
            radioButton14 = new RadioButton();
            radioButton15 = new RadioButton();
            radioButton16 = new RadioButton();
            radioButton17 = new RadioButton();
            radioButton18 = new RadioButton();
            radioButton19 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(1034, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 0;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(928, 12);
            textBox1.MinimumSize = new Size(100, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 1;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trackBar1.BackColor = SystemColors.Window;
            trackBar1.Location = new Point(928, 76);
            trackBar1.Maximum = 9;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(181, 45);
            trackBar1.TabIndex = 2;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBarText
            // 
            trackBarText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trackBarText.BackColor = SystemColors.Window;
            trackBarText.BorderStyle = BorderStyle.None;
            trackBarText.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trackBarText.Location = new Point(989, 50);
            trackBarText.MaxLength = 1;
            trackBarText.Name = "trackBarText";
            trackBarText.ReadOnly = true;
            trackBarText.Size = new Size(66, 20);
            trackBarText.TabIndex = 4;
            trackBarText.Text = "Level: 1";
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton1.Appearance = Appearance.Button;
            radioButton1.BackgroundImage = Properties.Resources.BR;
            radioButton1.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(928, 127);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(40, 40);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Tag = CardClass.Brute;
            radioButton1.TextAlign = ContentAlignment.MiddleCenter;
            radioButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton2.Appearance = Appearance.Button;
            radioButton2.BackgroundImage = (Image)resources.GetObject("radioButton2.BackgroundImage");
            radioButton2.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton2.Location = new Point(974, 127);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(40, 40);
            radioButton2.TabIndex = 6;
            radioButton2.Tag = CardClass.Tinkerer;
            radioButton2.TextAlign = ContentAlignment.MiddleCenter;
            radioButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton3.Appearance = Appearance.Button;
            radioButton3.BackgroundImage = Properties.Resources.SW;
            radioButton3.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton3.Location = new Point(1023, 127);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(40, 40);
            radioButton3.TabIndex = 7;
            radioButton3.Tag = CardClass.Spellweaver;
            radioButton3.TextAlign = ContentAlignment.MiddleCenter;
            radioButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton4.Appearance = Appearance.Button;
            radioButton4.BackgroundImage = Properties.Resources.SC;
            radioButton4.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton4.Location = new Point(1069, 127);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(40, 40);
            radioButton4.TabIndex = 8;
            radioButton4.Tag = CardClass.Scoundrel;
            radioButton4.TextAlign = ContentAlignment.MiddleCenter;
            radioButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton5.Appearance = Appearance.Button;
            radioButton5.BackgroundImage = Properties.Resources.CH;
            radioButton5.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton5.Location = new Point(928, 173);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(40, 40);
            radioButton5.TabIndex = 9;
            radioButton5.Tag = CardClass.Cragheart;
            radioButton5.TextAlign = ContentAlignment.MiddleCenter;
            radioButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton6.Appearance = Appearance.Button;
            radioButton6.BackgroundImage = Properties.Resources.MT;
            radioButton6.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton6.Location = new Point(974, 173);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(40, 40);
            radioButton6.TabIndex = 10;
            radioButton6.Tag = CardClass.Mindthief;
            radioButton6.TextAlign = ContentAlignment.MiddleCenter;
            radioButton6.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton7.Appearance = Appearance.Button;
            radioButton7.BackgroundImage = Properties.Resources.SK;
            radioButton7.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton7.Location = new Point(1023, 173);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(40, 40);
            radioButton7.TabIndex = 11;
            radioButton7.Tag = CardClass.Sunkeeper;
            radioButton7.TextAlign = ContentAlignment.MiddleCenter;
            radioButton7.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton8
            // 
            radioButton8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton8.Appearance = Appearance.Button;
            radioButton8.BackgroundImage = Properties.Resources.QM;
            radioButton8.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton8.Location = new Point(1069, 173);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(40, 40);
            radioButton8.TabIndex = 12;
            radioButton8.Tag = CardClass.Quartermaster;
            radioButton8.TextAlign = ContentAlignment.MiddleCenter;
            radioButton8.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton9
            // 
            radioButton9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton9.Appearance = Appearance.Button;
            radioButton9.BackgroundImage = Properties.Resources.SU;
            radioButton9.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton9.Location = new Point(928, 219);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(40, 40);
            radioButton9.TabIndex = 13;
            radioButton9.Tag = CardClass.Summoner;
            radioButton9.TextAlign = ContentAlignment.MiddleCenter;
            radioButton9.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton9.UseVisualStyleBackColor = true;
            radioButton9.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton10
            // 
            radioButton10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton10.Appearance = Appearance.Button;
            radioButton10.BackgroundImage = Properties.Resources.NS;
            radioButton10.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton10.Location = new Point(974, 219);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(40, 40);
            radioButton10.TabIndex = 14;
            radioButton10.Tag = CardClass.Nightshroud;
            radioButton10.TextAlign = ContentAlignment.MiddleCenter;
            radioButton10.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton10.UseVisualStyleBackColor = true;
            radioButton10.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton11
            // 
            radioButton11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton11.Appearance = Appearance.Button;
            radioButton11.BackgroundImage = Properties.Resources.PH;
            radioButton11.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton11.Location = new Point(1023, 219);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(40, 40);
            radioButton11.TabIndex = 15;
            radioButton11.Tag = CardClass.Plagueherald;
            radioButton11.TextAlign = ContentAlignment.MiddleCenter;
            radioButton11.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton11.UseVisualStyleBackColor = true;
            radioButton11.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton12
            // 
            radioButton12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton12.Appearance = Appearance.Button;
            radioButton12.BackgroundImage = Properties.Resources.BE;
            radioButton12.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton12.Location = new Point(1069, 219);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(40, 40);
            radioButton12.TabIndex = 16;
            radioButton12.Tag = CardClass.Berserker;
            radioButton12.TextAlign = ContentAlignment.MiddleCenter;
            radioButton12.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton12.UseVisualStyleBackColor = true;
            radioButton12.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton13
            // 
            radioButton13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton13.Appearance = Appearance.Button;
            radioButton13.BackgroundImage = Properties.Resources.SS;
            radioButton13.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton13.Location = new Point(928, 265);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(40, 40);
            radioButton13.TabIndex = 17;
            radioButton13.Tag = CardClass.Soothsinger;
            radioButton13.TextAlign = ContentAlignment.MiddleCenter;
            radioButton13.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton13.UseVisualStyleBackColor = true;
            radioButton13.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton14
            // 
            radioButton14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton14.Appearance = Appearance.Button;
            radioButton14.BackgroundImage = Properties.Resources.DS;
            radioButton14.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton14.Location = new Point(974, 265);
            radioButton14.Name = "radioButton14";
            radioButton14.Size = new Size(40, 40);
            radioButton14.TabIndex = 18;
            radioButton14.Tag = CardClass.Doomstalker;
            radioButton14.TextAlign = ContentAlignment.MiddleCenter;
            radioButton14.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton14.UseVisualStyleBackColor = true;
            radioButton14.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton15
            // 
            radioButton15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton15.Appearance = Appearance.Button;
            radioButton15.BackgroundImage = Properties.Resources.SB;
            radioButton15.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton15.Location = new Point(1023, 265);
            radioButton15.Name = "radioButton15";
            radioButton15.Size = new Size(40, 40);
            radioButton15.TabIndex = 19;
            radioButton15.Tag = CardClass.Sawbones;
            radioButton15.TextAlign = ContentAlignment.MiddleCenter;
            radioButton15.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton15.UseVisualStyleBackColor = true;
            radioButton15.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton16
            // 
            radioButton16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton16.Appearance = Appearance.Button;
            radioButton16.BackgroundImage = Properties.Resources.EL;
            radioButton16.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton16.Location = new Point(1069, 265);
            radioButton16.Name = "radioButton16";
            radioButton16.Size = new Size(40, 40);
            radioButton16.TabIndex = 20;
            radioButton16.Tag = CardClass.Elementalist;
            radioButton16.TextAlign = ContentAlignment.MiddleCenter;
            radioButton16.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton16.UseVisualStyleBackColor = true;
            radioButton16.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton17
            // 
            radioButton17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton17.Appearance = Appearance.Button;
            radioButton17.BackgroundImage = Properties.Resources.BT;
            radioButton17.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton17.Location = new Point(928, 311);
            radioButton17.Name = "radioButton17";
            radioButton17.Size = new Size(40, 40);
            radioButton17.TabIndex = 21;
            radioButton17.Tag = CardClass.Beast_Tyrant;
            radioButton17.TextAlign = ContentAlignment.MiddleCenter;
            radioButton17.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton17.UseVisualStyleBackColor = true;
            radioButton17.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton18
            // 
            radioButton18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton18.Appearance = Appearance.Button;
            radioButton18.BackgroundImage = Properties.Resources.DR;
            radioButton18.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton18.Location = new Point(974, 311);
            radioButton18.Name = "radioButton18";
            radioButton18.Size = new Size(40, 40);
            radioButton18.TabIndex = 22;
            radioButton18.Tag = CardClass.Diviner;
            radioButton18.TextAlign = ContentAlignment.MiddleCenter;
            radioButton18.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton18.UseVisualStyleBackColor = true;
            radioButton18.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // radioButton19
            // 
            radioButton19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton19.Appearance = Appearance.Button;
            radioButton19.BackgroundImage = Properties.Resources.BS;
            radioButton19.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton19.Location = new Point(1023, 311);
            radioButton19.Name = "radioButton19";
            radioButton19.Size = new Size(40, 40);
            radioButton19.TabIndex = 23;
            radioButton19.Tag = CardClass.Bladeswarm;
            radioButton19.TextAlign = ContentAlignment.MiddleCenter;
            radioButton19.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton19.UseVisualStyleBackColor = true;
            radioButton19.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1121, 657);
            Controls.Add(radioButton19);
            Controls.Add(radioButton18);
            Controls.Add(radioButton17);
            Controls.Add(radioButton16);
            Controls.Add(radioButton15);
            Controls.Add(radioButton14);
            Controls.Add(radioButton13);
            Controls.Add(radioButton12);
            Controls.Add(radioButton11);
            Controls.Add(radioButton10);
            Controls.Add(radioButton9);
            Controls.Add(radioButton8);
            Controls.Add(radioButton7);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(trackBarText);
            Controls.Add(trackBar1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        /*private void ClearControls()
        {
            // Remove TableLayoutPanel and pictureboxes
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] != button1 && Controls[i] != textBox1 && Controls[i] != trackBar1
                   && Controls[i] != trackBarText && Controls[i] != radioButton1 && Controls[i] != radioButton2
                   && Controls[i] != radioButton3 && Controls[i] != radioButton4 && Controls[i] != radioButton5
                   && Controls[i] != radioButton6 && Controls[i] != radioButton7 && Controls[i] != radioButton8 
                   && Controls[i] != radioButton9 && Controls[i] != radioButton10 && Controls[i] != radioButton11 
                   && Controls[i] != radioButton12 && Controls[i] != radioButton13 && Controls[i] != radioButton14 
                   && Controls[i] != radioButton15 && Controls[i] != radioButton16 && Controls[i] != radioButton17 
                   && Controls[i] != radioButton18 && Controls[i] != radioButton19)
                {
                    Controls.RemoveAt(i);
                }
            }
        }*/

        // Used to clear Tablelayoutpanel and Pictureboxes
        private void ClearControls()
        {
            var controlsToKeep = new HashSet<Control>
    {
        button1, textBox1, trackBar1, trackBarText
    };

            controlsToKeep.UnionWith(Controls.OfType<RadioButton>()
                .Where(radioButton => radioButton.Name.StartsWith("radioButton")));

            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (!controlsToKeep.Contains(Controls[i]))
                {
                    Controls.RemoveAt(i);
                }
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TrackBar trackBar1;
        private TextBox trackBarText;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton15;
        private RadioButton radioButton16;
        private RadioButton radioButton17;
        private RadioButton radioButton18;
        private RadioButton radioButton19;
    }
}
