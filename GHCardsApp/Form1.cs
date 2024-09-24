using GHCardsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml.Permissions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using RadioButton = System.Windows.Forms.RadioButton;

namespace GHCardsApp
{
    public partial class Form1 : Form
    {
        // Initializing variables
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=""Gloomhaven Cards"";Integrated Security=True;";
        private string sql = "SELECT CardPicture FROM Gloomhaven_Cards";
        private string currentTable;
        private DataSet ds = new DataSet();
        private Byte[] byteBLOBData = new Byte[0];
        private CardClass selectedOption = CardClass.Brute;
        
        private enum CardClass
        {
            Brute, Tinkerer, Spellweaver, Scoundrel,
            Cragheart, Mindthief, Sunkeeper, Quartermaster,
            Summoner, Nightshroud, Plagueherald, Berserker,
            Soothsinger, Doomstalker, Sawbones, Elementalist,
            Beast_Tyrant, Diviner, Bladeswarm, Hatchet, Demolitionist,
            Voidwarden, RedGuard
        };

        List<Control> gloomControls = new List<Control>();
        List<Control> jawsControls = new List<Control>();

        public Form1()
        {
            InitializeComponent();

            currentTable = "Gloomhaven_Cards";
            foreach (Control control in this.Controls)
            {
                if (control is RadioButton)
                {
                    gloomControls.Add(control);
                }

            }
            searchBar();
            ClassSwitch(selectedOption);
            GeneratePictureBoxes(Query(sql, connectionString));
        }

        // Main Function 
        private void button1_Click(object sender, EventArgs e)
        {
            searchBar();
            addCheckedListBoxOptions();
            ClassSwitch(selectedOption);
            CheckCheckBoxes(null, e);
            GeneratePictureBoxes(Query(sql, connectionString));
            //MessageBox.Show(sql);
        }

        // Saves search input into string to pass to sql query
        private void searchBar()
        {
            sql = "SELECT CardPicture FROM " + currentTable + " WHERE CardLevel <= " + trackBar1.Value + " ";
            if (textBox1.Text != "")
            {
                sql += " AND (CardName LIKE '%" + textBox1.Text + "%')";
            }

        }

        // Queries the sql database and fills dataset with query
        private DataSet Query(String sqlQuery, String sqlConnectionString)
        {
            ds = new DataSet();
            SqlConnection cnn = new SqlConnection(sqlConnectionString);
            SqlCommand command = new SqlCommand(sqlQuery, cnn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds, currentTable);
            cnn.Close();
            return ds;
        }

        // Function for dynamicaly creating pictureboxes and the table that holds them
        private void GeneratePictureBoxes(DataSet QueryResult)
        {
            SuspendLayout();
            ClearControls();
            this.AutoScrollPosition = new Point(0, 0);

            int numCols = 4; // Number of columns

            // Create table for picturebox spacing
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            // Dynamically set number of rows based on card count from query
            int numRows = (int)Math.Ceiling((double)QueryResult.Tables[currentTable].Rows.Count / numCols);

            // Define columns and rows with sizes to fit pictureboxes
            for (int i = 0; i < numCols; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 100f / numCols));
            }

            for (int i = 0; i < numRows; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize, 100f / numRows));
            }

            // Add pictureboxes to the TableLayoutPanel
            int pictureIndex = 0;
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (pictureIndex < QueryResult.Tables[currentTable].Rows.Count)
                    {
                        byteBLOBData = (Byte[])(QueryResult.Tables[currentTable].Rows[pictureIndex]["CardPicture"]);

                        // Memorystream disposal via using block 
                        using (MemoryStream stmBLOBData = new MemoryStream(byteBLOBData))
                        {
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Visible = false;
                            pictureBox.Image = Image.FromStream(stmBLOBData); // Set image source
                            pictureBox.Size = new Size(250, 375);
                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            tableLayoutPanel1.Controls.Add(pictureBox, col, row);
                            pictureBox.Visible = true;
                        }
                        pictureIndex++;
                    }
                    else
                    {
                        // If there are no more pictures, break
                        break;
                    }
                }
            }

            // Table location set after resuming layout to ensure proper placement
            // Resuming after adding to controls stops flickering
            Controls.Add(tableLayoutPanel1);
            ResumeLayout(true);
            tableLayoutPanel1.Location = new Point((ClientSize.Width - tableLayoutPanel1.Width) / 2, 0);
        }

        // Adjust sql query to account for level of cards searched for
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            sql = "SELECT CardPicture FROM Gloomhaven_Cards WHERE CardLevel <= " + trackBar1.Value + " ";

            trackBarText.Text = "Level: " + trackBar1.Value;
            ClassSwitch(selectedOption);

            //passing null just so it still displays the correct cards
            CheckCheckBoxes(null, EventArgs.Empty);
            GeneratePictureBoxes(Query(sql, connectionString));
        }

        private void ClassSwitch(CardClass cardClass)

        {
            switch (cardClass)
            {
                case CardClass.Brute:
                    sql += " AND ClassName = 'Brute' ";
                    break;
                case CardClass.Tinkerer:
                    sql += " AND ClassName = 'Tinkerer' ";
                    break;
                case CardClass.Spellweaver:
                    sql += " AND ClassName = 'Spellweaver' ";
                    break;
                case CardClass.Scoundrel:
                    sql += " AND ClassName = 'Scoundrel' ";
                    break;
                case CardClass.Cragheart:
                    sql += " AND ClassName = 'Cragheart' ";
                    break;
                case CardClass.Mindthief:
                    sql += " AND ClassName = 'Mindthief' ";
                    break;
                case CardClass.Sunkeeper:
                    sql += " AND ClassName = 'Sunkeeper' ";
                    break;
                case CardClass.Quartermaster:
                    sql += " AND ClassName = 'Quartermaster' ";
                    break;
                case CardClass.Summoner:
                    sql += " AND ClassName = 'Summoner' ";
                    break;
                case CardClass.Nightshroud:
                    sql += " AND ClassName = 'Nightshroud' ";
                    break;
                case CardClass.Plagueherald:
                    sql += " AND ClassName = 'Plagueherald' ";
                    break;
                case CardClass.Berserker:
                    sql += " AND ClassName = 'Berserker' ";
                    break;
                case CardClass.Soothsinger:
                    sql += " AND ClassName = 'Soothsinger' ";
                    break;
                case CardClass.Doomstalker:
                    sql += " AND ClassName = 'Doomstalker' ";
                    break;
                case CardClass.Elementalist:
                    sql += " AND ClassName = 'Elementalist' ";
                    break;
                case CardClass.Sawbones:
                    sql += " AND ClassName = 'Sawbones' ";
                    break;
                case CardClass.Beast_Tyrant:
                    sql += " AND ClassName = 'Beast Tyrant' ";
                    break;
                case CardClass.Diviner:
                    sql += " AND ClassName = 'Diviner' ";
                    break;
                case CardClass.Bladeswarm:
                    sql += " AND ClassName = 'Bladeswarm' ";
                    break;
                case CardClass.Hatchet:
                    sql += " AND ClassName = 'Hatchet' ";
                    break;
                case CardClass.Demolitionist:
                    sql += " AND ClassName = 'Demolitionist' ";
                    break;
                case CardClass.Voidwarden:
                    sql += " AND ClassName = 'Voidwarden' ";
                    break;
                case CardClass.RedGuard:
                    sql += " AND ClassName = 'RedGuard' ";
                    break;
                default:
                    break;
            }
        }

        // Runs a search after switching the current cardclass to the one clicked
        // Resets checkboxes
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked && radioButton.Tag != null)
            {
                UncheckAllCheckBoxes();
                selectedOption = (CardClass)radioButton.Tag;
                searchBar();
                ClassSwitch(selectedOption);
                GeneratePictureBoxes(Query(sql, connectionString));
            }
        }



        // Check if any CheckBoxes are checked and perform an action for each checked CheckBox
        private void CheckCheckBoxes(object sender, EventArgs e)
        {
            searchBar();
            foreach (Control control in Controls)
            {
                if (control is CheckBox checkBox)
                {
                    if (checkBox.Checked)
                    {
                        if (checkBox.Tag != null)
                        {
                            foreach (Control control2 in Controls)
                            {
                                if (control2 is TextBox textBox && textBox.Tag == checkBox.Tag)
                                {
                                    sql += " AND (TopText LIKE '%" + checkBox.Text + " " + textBox.Text + "%' OR BotText LIKE '%" + checkBox.Text + " " + textBox.Text + "%')";
                                }
                            }
                        }

                        else
                        {
                            
                            sql += " AND (TopText LIKE '%" + checkBox.Text + "%' OR BotText LIKE '%" + checkBox.Text + "%')";
                        }


                    }
                }
            }
            addCheckedListBoxOptions();
            ClassSwitch(selectedOption);
            GeneratePictureBoxes(Query(sql, connectionString));
        }

        // Checks if each control is a checkbox, if yes, uncheck
        private void UncheckAllCheckBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
        }

        //Checks checked list boxes for any selected options and adds them to the sql query
        private void addCheckedListBoxOptions()
        {
            foreach (Control control in Controls)
            {
                if (control is CheckedListBox checkedListBox)
                {
                    if (checkedListBox.CheckedItems.Count != 0)
                    {
                        // If so, loop through all checked items and print results  
                        for (int i = 0; i < checkedListBox.CheckedItems.Count; i++)
                        {
                            if (checkedListBox.CheckedItems[i] == "Any")
                            {
                                sql += " AND (TopText LIKE '%forced%' OR BotText LIKE '%forced%')";
                            }
                            else
                            {
                                sql += " AND (TopText LIKE '%" + checkedListBox.CheckedItems[i].ToString() + "%' OR BotText LIKE '%" + checkedListBox.CheckedItems[i].ToString() + "%')";
                            }
                        }
                        
                    }
                }
            }
        }

        private void swapGame(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Text)
            {
                case "Gloom":
                    GloomControls();
                    break;
                case "Jaws":
                    JawsControls();
                    break;
            }
            ClassSwitch(selectedOption);

            //MessageBox.Show(sql);
                
        }

        private void JawsControls()
        {
            foreach (Control control in Controls)
            {
                if (control is RadioButton)
                {
                    control.Visible = false;
                }
            }
            currentTable = "Jaws_Of_The_Lion";

            radioButton1.BackgroundImage = Properties.Resources.HA;
            radioButton1.Tag = CardClass.Hatchet;
            radioButton1.Visible = true;
            radioButton1.Checked = false;
            radioButton1.Checked = true;
            radioButton2.BackgroundImage = Properties.Resources.DE;
            radioButton2.Tag = CardClass.Demolitionist;
            radioButton2.Visible = true;
            radioButton3.BackgroundImage = Properties.Resources.VW;
            radioButton3.Tag = CardClass.Voidwarden;
            radioButton3.Visible = true;
            radioButton4.BackgroundImage = Properties.Resources.RG;
            radioButton4.Tag = CardClass.RedGuard;
            radioButton4.Visible = true;

   
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;           
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            radioButton16.Visible = false;
            radioButton17.Visible = false;
            radioButton18.Visible = false;
            radioButton19.Visible = false;



        }
        private void GloomControls()
        {
            foreach(Control control in Controls)
            {
                if (control is RadioButton) 
                { 
                    control.Visible = false;
                }
            }
            currentTable = "Gloomhaven_Cards";

            radioButton1.BackgroundImage = Properties.Resources.BR;
            radioButton1.Tag = CardClass.Brute;
            radioButton1.Visible = true;
            radioButton1.Checked = false;
            radioButton1.Checked = true;
            radioButton2.BackgroundImage = Properties.Resources.TI;
            radioButton2.Tag = CardClass.Tinkerer;
            radioButton2.Visible = true;
            radioButton3.BackgroundImage = Properties.Resources.SW;
            radioButton3.Tag = CardClass.Spellweaver;
            radioButton3.Visible = true;
            radioButton4.BackgroundImage = Properties.Resources.SC;
            radioButton4.Tag = CardClass.Scoundrel;
            radioButton4.Visible = true;
            radioButton5.BackgroundImage = Properties.Resources.CH;
            radioButton5.Tag = CardClass.Cragheart;
            radioButton5.Visible = true;
            radioButton6.BackgroundImage = Properties.Resources.MT;
            radioButton6.Tag = CardClass.Mindthief;
            radioButton6.Visible = true;
            radioButton7.BackgroundImage = Properties.Resources.SK;
            radioButton7.Tag = CardClass.Sunkeeper;
            radioButton7.Visible = true;
            radioButton8.BackgroundImage = Properties.Resources.QM;
            radioButton8.Tag = CardClass.Quartermaster;
            radioButton8.Visible = true;
            radioButton9.BackgroundImage = Properties.Resources.SU;
            radioButton9.Tag = CardClass.Summoner;
            radioButton9.Visible = true;
            radioButton10.BackgroundImage = Properties.Resources.NS;
            radioButton10.Tag = CardClass.Nightshroud;
            radioButton10.Visible = true;
            radioButton11.BackgroundImage = Properties.Resources.PH;
            radioButton11.Tag = CardClass.Plagueherald;
            radioButton11.Visible = true;
            radioButton12.BackgroundImage = Properties.Resources.BE;
            radioButton12.Tag = CardClass.Berserker;
            radioButton12.Visible = true;
            radioButton13.BackgroundImage = Properties.Resources.SS;
            radioButton13.Tag = CardClass.Soothsinger;
            radioButton13.Visible = true;
            radioButton14.BackgroundImage = Properties.Resources.DS;
            radioButton14.Tag = CardClass.Doomstalker;
            radioButton14.Visible = true;
            radioButton15.BackgroundImage = Properties.Resources.SB;
            radioButton15.Tag = CardClass.Sawbones;
            radioButton15.Visible = true;
            radioButton16.BackgroundImage = Properties.Resources.EL;
            radioButton16.Tag = CardClass.Elementalist;
            radioButton16.Visible = true;
            radioButton17.BackgroundImage = Properties.Resources.BT;
            radioButton17.Tag = CardClass.Beast_Tyrant;
            radioButton17.Visible = true;
            radioButton18.BackgroundImage = Properties.Resources.DR;
            radioButton18.Tag = CardClass.Diviner;
            radioButton18.Visible = true;
            radioButton19.BackgroundImage = Properties.Resources.BS;
            radioButton19.Tag = CardClass.Bladeswarm;
            radioButton19.Visible = true;

        }
    }
}
