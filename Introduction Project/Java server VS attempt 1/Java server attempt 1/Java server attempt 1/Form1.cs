using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;
using System.IO;



namespace Java_server_attempt_1
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



        private void BtnSendToServer_Click(object sender, EventArgs e)
        {

            WebRequest request = WebRequest.Create("http://10.28.109.112:42069");
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = textBox1.Text;
            if (textBox1.Text == "")
            {
                postData = "The user did not input any text.";
                textBox1.Text = null;
            }
            else
            {
                postData = textBox1.Text;
                textBox1.Text = null;
            }

            byte[] buffer = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = "Mario's Interface";
            // Set the ContentLength property of the WebRequest. 
            request.ContentLength = buffer.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(buffer, 0, buffer.Length);
            // Close the Stream object.
            dataStream.Close();
            //------------------------------------------------
            //my own attempt (also expecting proper http response, 
            //but once i remove the flag to use proper header, app crashes
           /* for (; ;)
            { 
            WebResponse storeResponse = request.GetResponse();
            Stream dataStreamIncoming = storeResponse.GetResponseStream();
            byte[] vale = new byte[1024];
            dataStreamIncoming.Read(vale, 0, 1024);
            StreamReader dataStreamRead = new StreamReader(dataStreamIncoming);
            char[] textFromServer = new char[1024];
            byte[] txt = new byte[1024];
            // txt = dataStream.Read();
            for (int k = 0; k < 1024; k++)
                txt[k] = (byte)dataStreamRead.Read();
            for (int k = 0; k < txt.Length; k++)
                textFromServer[k] = (char)txt[k];
            Console.WriteLine(txt[2]);
            //----------------------------------------------
        }*/
                            //code from internet (expecting proper http response(in my opinion)
                // Get the response.           
                WebResponse response = request.GetResponse();
                // Display the status.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
                // Clean up the streams.
                reader.Close();
                dataStream.Close();
                response.Close();
            
            
        }

        public string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Get("http://10.28.109.112:42069"));
        }
    }
}
