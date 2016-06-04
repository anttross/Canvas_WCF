using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ServiceReference1.OrderDetailes request = new ServiceReference1.OrderDetailes();

            #region picture
            ServiceReference1.Pictures p1 = new ServiceReference1.Pictures();
            p1.fileName = "p1";
            p1.fileBody = picture1;
            p1.fileSize = 30;
            p1.size = 50.50F;
            p1.angle = 10F;
            p1.left = 50F;
            p1.top = 50F;
            //ServiceReference1.Pictures p2 = new ServiceReference1.Pictures();
            //p2.fileName = "p2";
            //p2.fileBody = picture2;
            //p2.fileSize = 40;
            //p2.size = 50.50F;
            //p2.angle = 11F;
            //p2.left = 50F;
            //p2.top = 50F;
            //ServiceReference1.Pictures p3 = new ServiceReference1.Pictures();
            //p3.fileName = "p3";
            //p3.fileBody = picture3;
            //p3.fileSize = 50;
            //p3.size = 50.50F;
            //p3.angle = 0F;
            //p3.left = 50F;
            //p3.top = 50F;

            ServiceReference1.Pictures[] pictures = new ServiceReference1.Pictures[1];
            pictures[0] = p1;
            //pictures[1] = p2;
            //pictures[2] = p3;
            #endregion

            #region  text
            ServiceReference1.Text t1 = new ServiceReference1.Text();
            t1.fontFamily = "Arial";
            t1.fontSize = 30;
            t1.fontColor = "Red";
            t1.left = 0;
            t1.top = 0;
            t1.angle = 0;
            t1.textBody = "first";

            ServiceReference1.Text t2 = new ServiceReference1.Text();
            t2.fontFamily = "Arial";
            t2.fontSize = 30;
            t2.fontColor = "Green";
            t2.left = 0;
            t2.top = 0;
            t2.angle = 0;
            t2.textBody = "second";

            ServiceReference1.Text[] texts = new ServiceReference1.Text[2];
            texts[0] = t1;
            texts[1] = t2;
            #endregion

            #region client + order
            request.picturesList = pictures;
            request.textsList = texts;
            request.clientID = "b@a.com";
            request.phone = "0123456798";
            request.address = "here and now 7/8";
            request.fullName = "nobody here";
            request.city = "jer";
            request.zipCode = 123;
            request.POB = 555;

            request.amount = 1;
            request.pattern = 111;
            request.deliveryMethod = 1;
            #endregion

            //  System.Net.ServicePointManager.Expect100Continue = false;

            int newOrder = (int)client.GetOrder(request);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chooseFile(out picture1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            chooseFile(out picture2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chooseFile(out picture3);
        }

        string fileName = "";
        string fileSafeName = "";
        byte[] picture1 = null;
        byte[] picture2 = null;
        byte[] picture3 = null;
        string safeFileName = "";
        string ext = "";
        private void chooseFile(out byte[] picture)
        {
            //Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            openFileDialog1.ShowDialog();
            //openFileDialog1.Title = "בחירת קובץ מצורף למשימה";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            // Add a default extension if the user does not type one.
            openFileDialog1.AddExtension = true;
            openFileDialog1.Filter = "Office files Image files |(*.JPG;*.jpg;*.jpeg;*.bmp;*.png;*.tif;*.tiff;*.gif;*.pdf;)";
            if ( openFileDialog1.FileName.Trim().Length > 0)
            {
                safeFileName = openFileDialog1.SafeFileName;
                ext = System.IO.Path.GetExtension(openFileDialog1.FileName).Replace(".", "").Trim();
                // ext = (safeFileName.Substring(safeFileName.LastIndexOf('.'), (safeFileName.Length) - safeFileName.LastIndexOf('.'))).Replace(".", "");
                string[] arr = safeFileName.Split('.');

                fileName = openFileDialog1.FileName;
                FileInfo fi = new FileInfo(openFileDialog1.FileName);
                fi.IsReadOnly = false;
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                long temp = fi.Length;
                int lung = Convert.ToInt32(temp);
                picture = new byte[lung];
                fs.Read(picture, 0, lung);
                fs.Close();
                fileSafeName = openFileDialog1.SafeFileName;
            }
            else
            {
                picture = null;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString ="Data Source=DESKTOP-BUV55UA; Initial Catalog=Canvas_DB; Integrated Security=true; ";
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "select_test";
            
            cmd.Parameters.Add(new SqlParameter("@ee",1223));
            con.Open();
            int res = (int)cmd.ExecuteScalar();
            con.Close();


        }
    }
}
