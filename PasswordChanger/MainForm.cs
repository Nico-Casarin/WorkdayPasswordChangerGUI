using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Internal;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Web;
using static System.Net.Mime.MediaTypeNames;
using System.Web.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Threading;
using System.Security.Principal;
using System.Security.Cryptography;

namespace PasswordChanger
{
    public partial class PasswordChanger : Form
    {

        public PasswordChanger()
        {
            InitializeComponent();

            string sAttr = ConfigurationManager.AppSettings.Get("pathCSV");
            textPath.Text = sAttr;
        }

        private DataView myDataView;
        private string Path;

        public void btnShow_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                myDataView = DataReadPrint.readCSV(filePath);
                dataGridView1.DataSource = myDataView;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                //int columnindex = dataGridView1.CurrentCell.ColumnIndex;

                ConfigurationManager.RefreshSection("appSettings");
                string account = ConfigurationManager.AppSettings["Username"];
                string account_passwd = ConfigurationManager.AppSettings["Password"];
                string APIURL = ConfigurationManager.AppSettings["APIURL"];
                string passwd = SoapHelper.GeneratePassword(16);

                //sub Cells[2] with columnindex to print the selected cell
                string userID = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                string employeeID = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();

                try
                {
                    string response = SoapHelper.CallWebService(userID, employeeID, passwd, account, account_passwd, APIURL);
                    //string sAttr = ConfigurationManager.AppSettings.Get("key0");
                    if (MessageBox.Show(passwd + "\n" + response, "Click Ok to Copy", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                    {
                        Clipboard.SetText(passwd);
                    }
                    else
                    {
                        MessageBox.Show(
                            "No data Loaded! Load the CSV and try again",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                }
                catch
                {
                    return;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchTerm = textSearch.Text;

            DataReadPrint.FilterDataView(myDataView, searchTerm);

            // You can optionally specify a column for filtering
            // dataView = FilterDataView(dataView, searchTerm, "columnName");

            // DataView is filtered based on the search term
            dataGridView1.DataSource = myDataView;  // Update your DataGridVie
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filePath = textPath.Text;
            myDataView = DataReadPrint.readCSV(filePath);
            dataGridView1.DataSource = myDataView;
        }

        private void mnuFile_Click(object sender, EventArgs e)
        {

        }

        private void mnuFileQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFileAbout_Click(object sender, EventArgs e)
        {
            Form About = new About();
            About.StartPosition = FormStartPosition.CenterParent;
            About.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchTerm = textSearch.Text;
                try
                {
                    DataReadPrint.FilterDataView(myDataView, searchTerm);
                }
                catch
                {

                }

                // You can optionally specify a column for filtering
                // dataView = FilterDataView(dataView, searchTerm, "columnName");

                // Now your dataView is filtered based on the search term
                dataGridView1.DataSource = myDataView;  // Update your DataGridVie
            }
        }

        private void PasswordChanger_Load(object sender, EventArgs e)
        {
            string sAttr = ConfigurationManager.AppSettings.Get("pathCSV");


            try
            {
                string path = System.IO.Path.GetFullPath(ConfigurationManager.AppSettings.Get("pathCSV"));
                DataTable dt = new DataTable();
                dt.Columns.Add("Worker");
                dt.Columns.Add("Employee");
                dt.Columns.Add("UserName");
                StreamReader ste = new StreamReader(path);
                string[] totalData = new string[File.ReadAllLines(path).Length];
                totalData = ste.ReadLine().Split(',');
                while (!ste.EndOfStream)
                {
                    totalData = ste.ReadLine().Split(',');
                    dt.Rows.Add(totalData[0], totalData[1], totalData[2]);
                }

                //create dataview from datatable 
                myDataView = dt.DefaultView;
                dataGridView1.DataSource = myDataView;
            }
            catch (Exception)
            {
            }
        }

        private void mnuFileConfiguration_Click(object sender, EventArgs e)
        {
            Form Config = new Config();
            Config.StartPosition = FormStartPosition.CenterParent;
            Config.ShowDialog();
        }
    }

    class DataReadPrint
    {

        public static DataView readCSV(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                return null;
            }
            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Worker");
                    dt.Columns.Add("Employee");
                    dt.Columns.Add("UserName");
                    StreamReader ste = new StreamReader(filePath);
                    string[] totalData = new string[File.ReadAllLines(filePath).Length];
                    totalData = ste.ReadLine().Split(',');
                    while (!ste.EndOfStream)
                    {
                        totalData = ste.ReadLine().Split(',');
                        dt.Rows.Add(totalData[0], totalData[1], totalData[2]);
                    }

                    //create dataview from datatable 
                    return dt.DefaultView;
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show(
                        "File not found!",
                        "File not foud",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    return null;
                }
                catch (IOException)
                {
                    MessageBox.Show(
                        "The file is being used by another process." +
                        "Close it and try to reload it",
                        "File already in use",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                    return null;
                }
            }

        }
        public static DataView FilterDataView(DataView dataView, string filterText, string filterColumn = null)
        {
            // Build the filter expression
            string filterExpression = "";
            if (dataView != null)
            {
                if (!String.IsNullOrEmpty(filterText))
                {
                    if (string.IsNullOrEmpty(filterColumn))
                    {
                        // Filter all columns if no specific column is provided
                        filterExpression = string.Join(" OR ", dataView.Table.Columns.Cast<DataColumn>()
                                                                     .Select(c => $"{c.ColumnName} LIKE '%{filterText}%'"));
                    }
                    else
                    {
                        // Filter specific column
                        filterExpression = $"{filterColumn} LIKE '%{filterText}%'";
                    }
                }
            }
            // Apply filter to DataView
            if (dataView != null)
            {
                dataView.RowFilter = filterExpression;
                return dataView;
            }
            else
            {
                return null;
            }
        }


    }

    public static class SoapHelper
    {
        private static XmlDocument CreateXmlBody(string username, string employeeID, string passwd, string account, string account_passwd)
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml($@"<?xml version=""1.0"" encoding=""utf-8""?>
            <env:Envelope
                xmlns:env=""http://schemas.xmlsoap.org/soap/envelope/""
                xmlns:xsd=""http://www.w3.org/2001/XMLSchema""
                xmlns:wsse=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd"">
                <env:Header>
                    <wsse:Security env:mustUnderstand=""1"">
                        <wsse:UsernameToken>
                            <wsse:Username>{account}</wsse:Username>
                            <wsse:Password
                                Type=""http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText"">{account_passwd}</wsse:Password>
                        </wsse:UsernameToken>
                    </wsse:Security>
                </env:Header>
                <env:Body>
                    <wd:Workday_Account_for_Worker_Update
                        xmlns:wd=""urn:com.workday/bsvc""
                        wd:version=""v41.0"">
                        <wd:Worker_Reference>
                            <wd:Employee_Reference>
                                <wd:Integration_ID_Reference>
                                    <wd:ID wd:System_ID=""WD-EMPLID"">{employeeID}</wd:ID>
                                </wd:Integration_ID_Reference>
                            </wd:Employee_Reference>
                        </wd:Worker_Reference>
                        <wd:Workday_Account_for_Worker_Data>
                            <wd:User_Name>{username}</wd:User_Name>
                            <wd:Password>{passwd}</wd:Password>
                            <wd:Require_New_Password_at_Next_Sign_In>true</wd:Require_New_Password_at_Next_Sign_In>
                        </wd:Workday_Account_for_Worker_Data>
                    </wd:Workday_Account_for_Worker_Update>
                </env:Body>
            </env:Envelope>");
            return soapEnvelopeDocument;
        }

        private static HttpWebRequest CreateWebRequest(string url)
        {

            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Method = "POST";
                webRequest.ContentType = "text/xml;charset=\"UTF-8\"";
                return webRequest;
            }
            catch (UriFormatException ex)
            {
                MessageBox.Show(
                       "Ivalid API URI, Please check the configuration",
                       "API URI Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                       );
                return null;
            }

        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            try
            {
                using (Stream stream = webRequest.GetRequestStream())
                {
                    soapEnvelopeXml.Save(stream);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static string CallWebService(string username, string employeeID, string passwd, string account, string account_passwd, string APIURL)
        {
            var url = APIURL;

            XmlDocument soapEnvelopeDocument = CreateXmlBody(username, employeeID, passwd, account, account_passwd);
            HttpWebRequest webRequest = CreateWebRequest(url);
            if (webRequest == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                InsertSoapEnvelopeIntoWebRequest(soapEnvelopeDocument, webRequest);

                try
                {
                    //Get the response
                    string soapResult;
                    using (WebResponse webResponse = webRequest.GetResponse())
                    {
                        using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                        {
                            soapResult = rd.ReadToEnd();
                        }
                        return soapResult;

                    }
                }
                catch (WebException ex)
                {
                    //500 error
                    if (ex.Response is HttpWebResponse httpWebResponse && httpWebResponse.StatusCode == HttpStatusCode.InternalServerError)
                    {
                        using (StreamReader errorReader = new StreamReader(httpWebResponse.GetResponseStream()))
                        {
                            string errorResponse = errorReader.ReadToEnd();
                            return errorResponse;

                        }
                    }
                    else
                    {
                        throw;
                    }

                }
            }
        }

        private static readonly char[] _passwordChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^()-=+;:".ToCharArray();

        public static string GeneratePassword(int len)
        {
            StringBuilder password = new StringBuilder();
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] data = new byte[len];

                for (int i = 0; i < len; i++)
                {
                    rng.GetBytes(data);
                    uint randomValue = BitConverter.ToUInt32(data, 0);
                    char randomChar = _passwordChars[randomValue % _passwordChars.Length];
                    password.Append(randomChar);
                }

            }

            return password.ToString();
        }
    }
}
