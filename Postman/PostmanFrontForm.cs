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


        private void Request(object sender, EventArgs e)
        {
            body.Text = BeautifiedJson(mainLogic.GenericRequest(url.Text, body.Text, ((Button)sender).Text));
        }
        private string BeautifiedJson(string jsonString)
        {
            try
            {
                JToken parsedJson = JToken.Parse(jsonString);
                var beautifiedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
                return beautifiedJson;
            }
            catch
            {
                return jsonString;
            }
        }

        private void Clear_Btns(object sender, EventArgs e)
        {
            _ = ((Button)sender).Text.Contains("Url") ? url.Text = "" : body.Text = "";
        }
    }
}
