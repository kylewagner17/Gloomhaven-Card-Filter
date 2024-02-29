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
            button1 = new Button();
            textBox1 = new TextBox();
            trackBar1 = new TrackBar();
            checkBox1 = new CheckBox();
            trackBarText = new TextBox();
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
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1.Appearance = Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.BackgroundImage = Properties.Resources.BR;
            checkBox1.BackgroundImageLayout = ImageLayout.Zoom;
            checkBox1.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.ForeColor = SystemColors.ControlText;
            checkBox1.Location = new Point(928, 127);
            checkBox1.MaximumSize = new Size(50, 50);
            checkBox1.MinimumSize = new Size(40, 40);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(40, 40);
            checkBox1.TabIndex = 3;
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // trackBarText
            // 
            trackBarText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1121, 657);
            Controls.Add(trackBarText);
            Controls.Add(checkBox1);
            Controls.Add(trackBar1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TrackBar trackBar1;
        private CheckBox checkBox1;
        private TextBox trackBarText;
    }
}
