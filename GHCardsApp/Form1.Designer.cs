using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;
using ComboBox = System.Windows.Forms.ComboBox;
using Button = System.Windows.Forms.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using TrackBar = System.Windows.Forms.TrackBar;
using TextBox = System.Windows.Forms.TextBox;
using System.Reflection;

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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox6 = new CheckBox();
            MoveOptions = new CheckedListBox();
            AttackOptions = new CheckedListBox();
            Elements = new CheckedListBox();
            ForcedMovement = new CheckedListBox();
            textBox2 = new TextBox();
            rangeNum = new TextBox();
            sufferNum = new TextBox();
            moveNum = new TextBox();
            checkBox5 = new CheckBox();
            checkedListBox1 = new CheckedListBox();
            radioButton20 = new RadioButton();
            radioButton21 = new RadioButton();
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
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton4.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton5.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton6.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton7.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton8.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton9.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton10.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton11.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton12.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton13.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton14.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton15.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton16.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton17.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton18.CheckedChanged += RadioButton_CheckedChanged;
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
            radioButton19.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 18);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 24;
            checkBox1.Tag = "atk";
            checkBox1.Text = "Attack";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += CheckCheckBoxes;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 194);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(56, 19);
            checkBox2.TabIndex = 25;
            checkBox2.Tag = "move";
            checkBox2.Text = "Move";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += CheckCheckBoxes;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 43);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(59, 19);
            checkBox3.TabIndex = 26;
            checkBox3.Tag = "range";
            checkBox3.Text = "Range";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += CheckCheckBoxes;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 68);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(57, 19);
            checkBox4.TabIndex = 30;
            checkBox4.Tag = "suffer";
            checkBox4.Text = "Suffer";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += CheckCheckBoxes;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.FlatAppearance.BorderColor = Color.Black;
            checkBox6.Location = new Point(12, 147);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(49, 19);
            checkBox6.TabIndex = 33;
            checkBox6.Text = "AOE";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += CheckCheckBoxes;
            // 
            // MoveOptions
            // 
            MoveOptions.BorderStyle = BorderStyle.None;
            MoveOptions.CheckOnClick = true;
            MoveOptions.FormattingEnabled = true;
            MoveOptions.Items.AddRange(new object[] { "Jump", "Moved Through", "Teleport" });
            MoveOptions.Location = new Point(12, 227);
            MoveOptions.Name = "MoveOptions";
            MoveOptions.Size = new Size(118, 54);
            MoveOptions.TabIndex = 41;
            MoveOptions.SelectedIndexChanged += CheckCheckBoxes;
            // 
            // AttackOptions
            // 
            AttackOptions.BorderStyle = BorderStyle.None;
            AttackOptions.CheckOnClick = true;
            AttackOptions.FormattingEnabled = true;
            AttackOptions.Items.AddRange(new object[] { "Melee", "Ranged Attack" });
            AttackOptions.Location = new Point(12, 105);
            AttackOptions.Name = "AttackOptions";
            AttackOptions.Size = new Size(118, 36);
            AttackOptions.TabIndex = 42;
            AttackOptions.SelectedIndexChanged += CheckCheckBoxes;
            // 
            // Elements
            // 
            Elements.BorderStyle = BorderStyle.None;
            Elements.CheckOnClick = true;
            Elements.ColumnWidth = 60;
            Elements.FormattingEnabled = true;
            Elements.Items.AddRange(new object[] { "Fire", "Ice", "Wind", "Earth", "Light", "Dark", "Wild" });
            Elements.Location = new Point(12, 291);
            Elements.MultiColumn = true;
            Elements.Name = "Elements";
            Elements.Size = new Size(125, 72);
            Elements.TabIndex = 43;
            Elements.SelectedIndexChanged += CheckCheckBoxes;
            // 
            // ForcedMovement
            // 
            ForcedMovement.BorderStyle = BorderStyle.None;
            ForcedMovement.CheckOnClick = true;
            ForcedMovement.FormattingEnabled = true;
            ForcedMovement.Items.AddRange(new object[] { "Push", "Pull", "Grant Movement", "Any" });
            ForcedMovement.Location = new Point(12, 373);
            ForcedMovement.Name = "ForcedMovement";
            ForcedMovement.Size = new Size(125, 72);
            ForcedMovement.TabIndex = 44;
            ForcedMovement.SelectedIndexChanged += CheckCheckBoxes;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 14);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(19, 23);
            textBox2.TabIndex = 45;
            textBox2.Tag = "atk";
            textBox2.TextChanged += CheckCheckBoxes;
            // 
            // rangeNum
            // 
            rangeNum.Location = new Point(78, 39);
            rangeNum.Name = "rangeNum";
            rangeNum.Size = new Size(19, 23);
            rangeNum.TabIndex = 46;
            rangeNum.Tag = "range";
            rangeNum.TextChanged += CheckCheckBoxes;
            // 
            // sufferNum
            // 
            sufferNum.Location = new Point(78, 64);
            sufferNum.Name = "sufferNum";
            sufferNum.Size = new Size(19, 23);
            sufferNum.TabIndex = 47;
            sufferNum.Tag = "suffer";
            sufferNum.TextChanged += CheckCheckBoxes;
            // 
            // moveNum
            // 
            moveNum.Location = new Point(78, 190);
            moveNum.Name = "moveNum";
            moveNum.Size = new Size(19, 23);
            moveNum.TabIndex = 48;
            moveNum.Tag = "move";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.FlatAppearance.BorderColor = Color.Black;
            checkBox5.Location = new Point(12, 169);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(92, 19);
            checkBox5.TabIndex = 49;
            checkBox5.Text = "Grant Attack";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Loot", "XP", "Active", "Round Bonus", "Shield", "Retaliate", "Target", "Recover", "Lost", "Token" });
            checkedListBox1.Location = new Point(12, 451);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(242, 90);
            checkedListBox1.TabIndex = 50;
            checkedListBox1.SelectedIndexChanged += CheckCheckBoxes;
            // 
            // radioButton20
            // 
            radioButton20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton20.Appearance = Appearance.Button;
            radioButton20.BackgroundImage = Properties.Resources.BR;
            radioButton20.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton20.Location = new Point(928, 387);
            radioButton20.Name = "radioButton20";
            radioButton20.Size = new Size(40, 40);
            radioButton20.TabIndex = 51;
            radioButton20.TabStop = true;
            radioButton20.Tag = CardClass.Brute;
            radioButton20.TextAlign = ContentAlignment.MiddleCenter;
            radioButton20.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton20.UseVisualStyleBackColor = true;
            radioButton20.CheckedChanged += swapGame;
            // 
            // radioButton21
            // 
            radioButton21.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButton21.Appearance = Appearance.Button;
            radioButton21.BackgroundImage = (Image)resources.GetObject("radioButton21.BackgroundImage");
            radioButton21.BackgroundImageLayout = ImageLayout.Zoom;
            radioButton21.Location = new Point(974, 387);
            radioButton21.Name = "radioButton21";
            radioButton21.Size = new Size(40, 40);
            radioButton21.TabIndex = 52;
            radioButton21.Tag = CardClass.Tinkerer;
            radioButton21.TextAlign = ContentAlignment.MiddleCenter;
            radioButton21.TextImageRelation = TextImageRelation.ImageAboveText;
            radioButton21.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1121, 657);
            Controls.Add(radioButton21);
            Controls.Add(radioButton20);
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox5);
            Controls.Add(checkBox2);
            Controls.Add(moveNum);
            Controls.Add(checkBox3);
            Controls.Add(checkBox4);
            Controls.Add(sufferNum);
            Controls.Add(rangeNum);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(ForcedMovement);
            Controls.Add(Elements);
            Controls.Add(AttackOptions);
            Controls.Add(MoveOptions);
            Controls.Add(checkBox6);
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
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // Used to clear Tablelayoutpanel and Pictureboxes
        private void ClearControls()
        {
            var controlsToKeep = new HashSet<Control>
            {button1, trackBar1, trackBarText};


            controlsToKeep.UnionWith(Controls.OfType<RadioButton>());

            controlsToKeep.UnionWith(Controls.OfType<ComboBox>());

            controlsToKeep.UnionWith(Controls.OfType<CheckBox>());

            controlsToKeep.UnionWith(Controls.OfType<CheckedListBox>());

            controlsToKeep.UnionWith(Controls.OfType<TextBox>());
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox6;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckedListBox MoveOptions;
        private CheckedListBox AttackOptions;
        private CheckedListBox Elements;
        private CheckedListBox ForcedMovement;
        private TextBox textBox2;
        private TextBox rangeNum;
        private TextBox sufferNum;
        private TextBox moveNum;
        private CheckBox checkBox5;
        private CheckedListBox checkedListBox1;
        private RadioButton radioButton20;
        private RadioButton radioButton21;
    }
}
