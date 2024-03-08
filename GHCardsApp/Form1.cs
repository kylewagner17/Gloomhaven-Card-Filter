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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Main Function 
        private void button1_Click(object sender, EventArgs e)
        {
            
            searchBar();
            classRadioButton();

            GeneratePictureBoxes(query(sql, connectionString));
        }

        // Saves search input into string to pass to sql query
        private void searchBar()
        {
            sql = "SELECT CardPicture FROM Gloomhaven_Cards WHERE CardLevel <= " + trackBar1.Value + " ";
            if (textBox1.Text != "")
            {
                sql = sql + " AND (TopText LIKE '%" + textBox1.Text + "%' OR BotText LIKE '%" + textBox1.Text + "%')";
            }
        }

        // Queries the sql database and fills dataset with query
        private DataSet query(String sqlQuery, String sqlConnectionString)
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
                            pictureBox.Size = new Size(200, 300);
                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            tableLayoutPanel1.Controls.Add(pictureBox, col, row);
                            pictureBox.Visible = true;
                        }
                        pictureIndex++;
                    }
                    else
                    {
                        // If there are no more pictures, break the loop
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

        private void ClearControls()
        {
            // Remove TableLayoutPanel and pictureboxes
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] != button1 && Controls[i] != textBox1 && Controls[i] != trackBar1 
                   && Controls[i] != trackBarText && Controls[i] != radioButton1 && Controls[i] != radioButton2)
                {
                    Controls.RemoveAt(i);
                }
            }
        }

        // Adjust sql query to account for level of cards searched for
        private void trackBar1_Scroll(object sender, EventArgs e)
        { 

            sql = "SELECT CardPicture FROM Gloomhaven_Cards WHERE CardLevel <= " + trackBar1.Value + " ";

            trackBarText.Text = "Level: " + trackBar1.Value;
            classRadioButton();
            GeneratePictureBoxes(query(sql, connectionString));
        }

        private void classRadioButton()

        {
            if (radioButton1.Checked)
            {
                sql = sql + " AND ClassName = 'Brute' ";
            }

            else if (radioButton2.Checked)
            {
                sql = sql + " AND ClassName = 'Tinkerer' ";
            }
                
        }

        void radioButtton_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

    }
}
