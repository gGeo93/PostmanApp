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

        private void Request(object sender, EventArgs e)
        {
            data.Text = BeautifiedJson(mainLogic.GenericRequest(url.Text, data.Text, ((Button)sender).Text));
        }

        private void ClearUrl_Click(object sender, EventArgs e)
        {
            url.Text = string.Empty;
        }

        private void ClearBody_Click(object sender, EventArgs e)
        {
            data.Text = string.Empty;
        }

    }
}
