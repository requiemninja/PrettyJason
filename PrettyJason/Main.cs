using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using EasyScintilla.Stylers;

namespace PrettyJason
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void prettyButton_Click(object sender, EventArgs e)
        {
            JToken uglyStuff = JToken.Parse(uglyTextBox.Text);
            string prettified = uglyStuff.ToString(Newtonsoft.Json.Formatting.Indented);
            prettyTextBox.Text = prettified;
            this.prettyTextBox.Styler = new JsonStyler();
        }

        private void openJson_Click(object sender, EventArgs e)
        {
            DialogResult result = openJson.ShowDialog();
            if (result == DialogResult.OK)
            {
                string jsonFileName = openJson.FileName;
                try
                {
                    string jsonFile = File.ReadAllText(jsonFileName);
                    uglyTextBox.Text = jsonFile;
                }
                catch (IOException)
                {

                }
            }
        }

        private void saveJson_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveJson = new SaveFileDialog();
            saveJson.Title = "Save prettified json file";
            saveJson.Filter = "Json Files|*.json";
            saveJson.DefaultExt = "json";
            if (saveJson.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveJson.FileName, prettyTextBox.Text);
            }
            
        }
    }
}
