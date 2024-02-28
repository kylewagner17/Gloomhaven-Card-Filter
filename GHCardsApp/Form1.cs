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
        private string sql = "Select CardPicture from Gloomhaven_Cards";
        private DataSet ds = new DataSet();
        private Byte[] byteBLOBData = new Byte[0];

        public Form1()
        {      
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Connection button handler
        private void button1_Click(object sender, EventArgs e)
        {
            searchBar();

            SqlConnection cnn = new SqlConnection(connectionString);

            ClearControls();

            GeneratePictureBoxes(query(sql, connectionString));

            // Closes sql connection
            cnn.Close();
        }

        //Saves search input into string to pass to sql query
        private void searchBar()
        {
            sql = "Select CardPicture from Gloomhaven_Cards";

            if (textBox1.Text != "")
            {
                sql = sql + " WHERE TopText LIKE '%" + textBox1.Text + "%' OR BotText LIKE '%" + textBox1.Text + "%'";
            }
        }

        // Function for querying the sql database and filling a dataset
        private DataSet query(String sqlQuery, String sqlConnectionString)
        {
            ds = new DataSet();
            SqlConnection cnn = new SqlConnection(sqlConnectionString);
            SqlCommand command = new SqlCommand(sqlQuery, cnn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds, "Gloomhaven_Cards");
            return ds;
        }

        // Function for dynamicaly creating pictureboxes and the table that holds them
        private void GeneratePictureBoxes(DataSet QueryResult)
        {
            
            int numCols = 4; // Number of columns

            // Create table for picturebox spacing
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.None; // Anchor to the top center
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            // Allows for dynamic row creation based on card count pulled from database
            int numRows = (int)Math.Ceiling((double)QueryResult.Tables["Gloomhaven_Cards"].Rows.Count / numCols);

            // Define columns and rows with sizes to autofit pictureboxes
            for (int i = 0; i < numCols; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 100f / numCols));
            }

            for (int i = 0; i < numRows; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize, 100f / numRows));
            }

            // Add PictureBoxes to the TableLayoutPanel
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

            // Add TableLayoutPanel to the form
            Controls.Add(tableLayoutPanel1);

            // Adjust the location of the TableLayoutPanel to center it horizontally
            tableLayoutPanel1.Location = new Point((ClientSize.Width - tableLayoutPanel1.Width) / 2, 0);


        }

        private void ClearControls()
        {
            // Remove all controls except the TextBox (textBox1)
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] != textBox1 && Controls[i] != button1)
                {
                    Controls.RemoveAt(i);
                }
            }
        }

    }
}