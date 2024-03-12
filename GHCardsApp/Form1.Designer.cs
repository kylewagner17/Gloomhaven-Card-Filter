using System.Windows.Forms;

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
            radioButton1.Location = new Point(1069, 127);
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
            radioButton2.Location = new Point(1069, 173);
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
            radioButton3.Location = new Point(1069, 219);
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
            radioButton4.Location = new Point(1069, 265);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(40, 40);
            radioButton4.TabIndex = 8;
            radioButton4.Tag = CardClass.Scoundrel;
            radioButton4.TextAlign = ContentAlignment.MiddleCenter;
            radioButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButtton_CheckedChanged;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1121, 657);
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

        private void ClearControls()
        {
            // Remove TableLayoutPanel and pictureboxes
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] != button1 && Controls[i] != textBox1 && Controls[i] != trackBar1
                   && Controls[i] != trackBarText && Controls[i] != radioButton1 && Controls[i] != radioButton2
                   && Controls[i] != radioButton3 && Controls[i] != radioButton4)
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
    }
}
