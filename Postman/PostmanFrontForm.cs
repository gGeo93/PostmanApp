using BusinessLogic;
using Newtonsoft.Json.Linq;

namespace Postman
{
    public partial class PostmanFrontForm : Form
    {
        MainLogicMethods mainLogic;
        public PostmanFrontForm()
        {
            InitializeComponent();
            mainLogic = new MainLogicMethods();
            url.Text = "https://";
        }
        private string BeautifiedJson(string jsonString)
        {
            if (jsonString[0] != '[')
                return jsonString;
            JToken parsedJson = JToken.Parse(jsonString);
            var beautifiedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return beautifiedJson;
        }

        private void Get_Btn_Click(object sender, EventArgs e)
        {
            string jsonString = mainLogic.GenericRequest(url.Text, null, HttpMethod.Get);
            output.Text = BeautifiedJson(jsonString);
        }
        private void Post_Btn_Click(object sender, EventArgs e)
        {
            output.Text = mainLogic.GenericRequest(url.Text, output.Text, HttpMethod.Post);
        }
        private void Put_Btn_Click(object sender, EventArgs e)
        {
            output.Text = mainLogic.GenericRequest(url.Text, output.Text, HttpMethod.Put);
        }
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            output.Text = mainLogic.GenericRequest(url.Text, null, HttpMethod.Delete);
        }

        private void ClearUrl_Click(object sender, EventArgs e)
        {
            url.Text = string.Empty;
        }

        private void ClearBody_Click(object sender, EventArgs e)
        {
            output.Text = string.Empty;
        }
    }
}
