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

        private void Get_Btn_Click(object sender, EventArgs e)
        {
            string jsonString = mainLogic.GenericRequest(url.Text, null, HttpMethod.Get);
            data.Text = BeautifiedJson(jsonString);
        }
        private void Post_Btn_Click(object sender, EventArgs e)
        {
            data.Text = mainLogic.GenericRequest(url.Text, data.Text, HttpMethod.Post);
        }
        private void Put_Btn_Click(object sender, EventArgs e)
        {
            data.Text = mainLogic.GenericRequest(url.Text, data.Text, HttpMethod.Put);
        }
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            data.Text = mainLogic.GenericRequest(url.Text, null, HttpMethod.Delete);
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
