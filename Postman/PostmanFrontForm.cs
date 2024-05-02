using System.Text.RegularExpressions;
using BusinessLogic;

namespace Postman
{
    public partial class PostmanFrontForm : Form
    {
        MainLogicMethods mainLogic;
        public PostmanFrontForm()
        {
            InitializeComponent();
            mainLogic = new MainLogicMethods();
        }


        private async void Request(object sender, EventArgs e)
        {
            if(!url.Text.IsValidApiUrl()) 
            {
                body.Text = "Invalid Api Url";
                return;
            }
            body.Text = await mainLogic.GenericRequest(url.Text, body.Text, ((Button)sender).Text);
        }

        private void Clear_Btns(object sender, EventArgs e)
        {
            _ = ((Button)sender).Text.Contains("Url") ? url.Text = "" : body.Text = "";
        }
    }
}
