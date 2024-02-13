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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Connection button handler
        private void button1_Click(object sender, EventArgs e)
        {
            //Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
            //Creating string containing information for connecting to sql server
            string connectionString;
            connectionString = @"Data Source=DESKTOP-QN510QT\SQLEXPRESS;Initial Catalog=""Gloomhaven Cards"";Integrated Security=True;Encrypt=False;Trusted_Connection=True;";
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            //sql = "Select CardPicture from Gloomhaven_Cards";
            sql = "Select CardPicture from Gloomhaven_Cards";
            cnn.Open();
            command = new SqlCommand(sql, cnn);

            /* dataReader = command.ExecuteReader();

             while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0);
            }

            MessageBox.Show(Output);
            */

            //Possibly use sqlCredential for security relating to database

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Gloomhaven_Cards");
            int c = ds.Tables["Gloomhaven_Cards"].Rows.Count;

            //while i < ds.tables["gloomhaven_Cards"].rows.count;
            //foreach row in table
            //{Byte Array = new Byte array
            //byte array = gloomhaven cards table . rows i-1 [card picture column]
            //new memorystream(byte array)
            //new picturebox = image.fromstream(memorystream)
            //***********new placement for picturebox
            //}



            if (c > 0)
            {
                //BLOB is read into Byte array, then used to construct MemoryStream,
                //then passed to PictureBox.
                Byte[] byteBLOBData = new Byte[0];
                byteBLOBData = (Byte[])(ds.Tables["Gloomhaven_Cards"].Rows[c - 1]["CardPicture"]);
                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                pictureBox1.Image = Image.FromStream(stmBLOBData);

                //create new picture boxes using for loop and iterator ( "picturebox"+ToString(i) )
                //cannot create variables within for loop but can add to an array instantiated before the loop

            }
            





            //Opens sql connection using property settings of SqlConnection

            MessageBox.Show("Connection Open!");

            //Closes sql connection
            cnn.Close();
        }


    }
}