using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordChanger
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();


        }

        public void Form3_Load(object sender, EventArgs e)
        {
            ConfigurationManager.RefreshSection("appSettings");
            text_Username.Text = GetSetting("Username");
            text_Passwd.Text = GetSetting("Password");
            text_Path.Text = GetSetting("pathCSV");
            text_API.Text = GetSetting("APIURL");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {

            // Get the path to the DLL
            string dllPath = Assembly.GetExecutingAssembly().Location;

            Configuration config = ConfigurationManager.OpenExeConfiguration(dllPath);

            config.AppSettings.Settings.Remove("Username");
            config.AppSettings.Settings.Add("Username", text_Username.Text);

            config.AppSettings.Settings.Remove("Password");
            config.AppSettings.Settings.Add("Password", text_Passwd.Text);

            config.AppSettings.Settings.Remove("pathCSV");
            config.AppSettings.Settings.Add("pathCSV", text_Path.Text);

            config.AppSettings.Settings.Remove("APIURL");
            config.AppSettings.Settings.Add("APIURL", text_API.Text);

            config.Save(ConfigurationSaveMode.Modified, true);
            this.Close();

        }

        private static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        private static void SetSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void btn_Discard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_Passwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
