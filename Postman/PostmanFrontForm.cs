using BusinessLogic;

namespace Postman
{
    public partial class PostmanFrontForm : Form
    {
        #region BusinessLogicType
        MainLogicMethods mainLogic;
        #endregion

        #region Initializer
        public PostmanFrontForm()
        {
            InitializeComponent();
            mainLogic = new MainLogicMethods();
        }
        #endregion

        #region Events
        private async void Request(object sender, EventArgs e)
        {
            progressBar.BeginInvoke(Progressing);
            body.Text = await mainLogic.GenericRequest(url.Text, body.Text, ((Button)sender).Text);
            await Finished();
        }

        private void Clear_Btns(object sender, EventArgs e)
        {
            _ = ((Button)sender).Text.Contains("Url") ? url.Text = "" : body.Text = "";
        }
        #endregion

        #region ProgressBarLogic
        private async Task Progressing() 
        {
            progressBar.Enabled = true;
            progressBar.Visible = true;
            progressBar.Value = 0;
            do
            {
                await Task.Delay(50);
                progressBar.Value += 5;
                progressBar.Update();
            } while (progressBar.Value < 100);
        }
        private async Task Finished() 
        {
            await Task.Delay(1000);
            progressBar.Value = 100;
            progressBar.Enabled = false;
            progressBar.Visible = false;
        }
        #endregion
    }
}
