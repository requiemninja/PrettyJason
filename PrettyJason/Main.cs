using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        }
    }
}
