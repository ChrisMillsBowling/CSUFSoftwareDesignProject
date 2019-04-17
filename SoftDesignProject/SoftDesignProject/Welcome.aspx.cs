using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftDesignProject
{
    public partial class Welcome : System.Web.UI.Page
    {
        public static string USERNAME = "Initial_USER";
        protected void Page_Load(object sender, EventArgs e)
        {
            WelcomeLabel.Text = "Welcome, " + USERNAME;

        }

        protected void ClassButton_Click(object sender, EventArgs e)
        {

        }

        protected void BookButton_Click(object sender, EventArgs e)
        {

        }

        protected void ItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InfoLabel.Text = "Information: " + ItemListBox.SelectedItem.Value;
        }

        protected void ItemListBox_Load(object sender, EventArgs e)
        {
            ItemListBox.Items.Add(new ListItem("Bob's Holy Book", "This is the ledgend of Bob."));
            ItemListBox.Items.Add(new ListItem("Stan's Devilish Tome", "This is the enemy of Bob."));
        }
    }
}