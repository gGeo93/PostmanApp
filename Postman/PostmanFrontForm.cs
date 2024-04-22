using BusinessLogic;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;

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
            body.Text = await mainLogic.GenericRequest(url.Text, body.Text, ((Button)sender).Text);
        }

        private void Clear_Btns(object sender, EventArgs e)
        {
            _ = ((Button)sender).Text.Contains("Url") ? url.Text = "" : body.Text = "";
        }
    }
}
