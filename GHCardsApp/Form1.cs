using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GHCardsApp
{
    public partial class Form1 : Form
    {
        // Creating string containing information for connecting to sql server
        // Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
        private string connectionString = @"Data Source=DESKTOP-QN510QT\SQLEXPRESS;Initial Catalog=""Gloomhaven Cards"";Integrated Security=True;Encrypt=False;Trusted_Connection=True;";
        private string sql = "SELECT CardPicture FROM Gloomhaven_Cards";
        private DataSet ds = new DataSet();
        private Byte[] byteBLOBData = new Byte[0];
        private CardClass selectedOption = CardClass.Brute;
        private enum CardClass
        {
            Brute, Tinkerer, Spellweaver, Scoundrel, Cragheart, Mindthief, Sunkeeper, Quartermaster, Summoner,
            Nightshroud, Plagueherald, Berserker, Soothsinger, Doomstalker, Sawbones, Elementalist, Beast_Tyrant, Diviner, Bladeswarm
        };

        public Form1()
        {
            InitializeComponent();
            //Testing----------------------------
            string[] options = { "=", ">", "<" };
            comboBox1.Items.AddRange(options);
            comboBox2.Items.AddRange(options);
            comboBox3.Items.AddRange(options);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            //Testing----------------------------
            searchBar();
            ClassSwitch(selectedOption);
            GeneratePictureBoxes(Query(sql, connectionString));
        }

        // Main Function 
        private void button1_Click(object sender, EventArgs e)
        {
            searchBar();
            ClassSwitch(selectedOption);
            GeneratePictureBoxes(Query(sql, connectionString));
            //-------------------------
            CheckCheckBoxes();
            MessageBox.Show(sql);
            //-------------------------
        }

        // Saves search input into string to pass to sql query
        private void searchBar()
        {
            sql = "SELECT CardPicture FROM Gloomhaven_Cards WHERE CardLevel <= " + trackBar1.Value + " ";
            if (textBox1.Text != "")
            {
                sql += " AND (TopText LIKE '%" + textBox1.Text + "%' OR BotText LIKE '%" + textBox1.Text + "%')";
            }
        }

        // Queries the sql database and fills dataset with query
        private DataSet Query(String sqlQuery, String sqlConnectionString)
        {
            ds = new DataSet();
            SqlConnection cnn = new SqlConnection(sqlConnectionString);
            SqlCommand command = new SqlCommand(sqlQuery, cnn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds, "Gloomhaven_Cards");
            cnn.Close();
            return ds;
        }

        // Function for dynamicaly creating pictureboxes and the table that holds them
        private void GeneratePictureBoxes(DataSet QueryResult)
        {
            SuspendLayout();
            ClearControls();

            int numCols = 4; // Number of columns

            // Create table for picturebox spacing
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            // Dynamically set number of rows based on card count from query
            int numRows = (int)Math.Ceiling((double)QueryResult.Tables["Gloomhaven_Cards"].Rows.Count / numCols);

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
                    if (pictureIndex < QueryResult.Tables["Gloomhaven_Cards"].Rows.Count)
                    {
                        byteBLOBData = (Byte[])(QueryResult.Tables["Gloomhaven_Cards"].Rows[pictureIndex]["CardPicture"]);

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
                default:
                    break;
            }
        }

        // Runs a search after switching the current cardclass to the one clicked
        // Resets checkboxes
        void RadioButton_CheckedChanged(object sender, EventArgs e)
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
        private void CheckCheckBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is CheckBox checkBox)
                {
                    if (checkBox.Checked)
                    {
                        MessageBox.Show($"CheckBox '{checkBox.Text}' is checked.");
                        sql += " AND (TopText LIKE '%" + checkBox.Text + "%' OR BotText LIKE '%" + checkBox.Text + "%')";
                    }
                }
            }
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

    }
}
