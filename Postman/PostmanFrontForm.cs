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
            string httpMethodBtnTxt = ((Button)sender).Text;
            
            DisableOtherHttpCalls(httpMethodBtnTxt);
            
            progressBar.BeginInvoke(Progressing);
            
            body.Text = await mainLogic.GenericRequest(url.Text, body.Text, httpMethodBtnTxt);
            
            await Finished();
            
            ReEnableAllHttpCalls();
        }

        private void Clear_Btns(object sender, EventArgs e)
        {
            _ = ((Button)sender).Text.ToLower().Contains("url") ? url.Text = "" : body.Text = "";
        }
        #endregion

        #region ProgressBarLogic
        private async Task Progressing() 
        {
            perCent.Text = "0%";
            perCent.Enabled = true;
            perCent.Visible = true;
            progressBar.Enabled = true;
            progressBar.Visible = true;
            progressBar.Value = 0;
            do
            {
                await Task.Delay(50);
                progressBar.Value += 5;
                perCent.Text = progressBar.Value + "%";
                progressBar.Update();
            } while (progressBar.Value < 100);
        }
        private async Task Finished() 
        {
            progressBar.Value = 100;
            perCent.Text = progressBar.Value.ToString() + "%";
            await Task.Delay(1000);
            perCent.Enabled = false;
            perCent.Visible = false;
            progressBar.Enabled = false;
            progressBar.Visible = false;
        }
        #endregion

        #region HttpCallsBtnsHandling
        private void DisableOtherHttpCalls(string currentHttpCall) 
        {
            if (currentHttpCall == "GET")
            {
                Post_Btn.Enabled = false;
                Put_Btn.Enabled = false;
                Patch_Btn.Enabled = false;
                Delete_Btn.Enabled = false;
            }
            else if (currentHttpCall == "POST")
            {
                Get_Btn.Enabled = false;

                Put_Btn.Enabled = false;
                Patch_Btn.Enabled = false;
                Delete_Btn.Enabled = false;
            }
            else if (currentHttpCall == "PUT")
            {
                Get_Btn.Enabled = false;
                Post_Btn.Enabled = false;

                Patch_Btn.Enabled = false;
                Delete_Btn.Enabled = false;
            }
            else if (currentHttpCall == "PATCH")
            {
                Get_Btn.Enabled = false;
                Post_Btn.Enabled = false;
                Put_Btn.Enabled = false;

                Delete_Btn.Enabled = false;
            }
            else if (currentHttpCall == "DELETE")
            {
                Get_Btn.Enabled = false;
                Post_Btn.Enabled = false;
                Put_Btn.Enabled = false;
                Patch_Btn.Enabled = false;
            }
        }
        private void ReEnableAllHttpCalls()
        {
            Get_Btn.Enabled = true;
            Post_Btn.Enabled = true;
            Put_Btn.Enabled = true;
            Patch_Btn.Enabled = true;
            Delete_Btn.Enabled = true;
        }
        #endregion
    }
}
