namespace Postman
{
    partial class PostmanFrontForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            url = new TextBox();
            urlLabel = new Label();
            Get_Btn = new Button();
            Post_Btn = new Button();
            data = new TextBox();
            Put_Btn = new Button();
            Delete_Btn = new Button();
            ClearUrl = new Button();
            ClearBody = new Button();
            SuspendLayout();
            // 
            // url
            // 
            url.Location = new Point(12, 35);
            url.Name = "url";
            url.Size = new Size(300, 23);
            url.TabIndex = 1;
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            urlLabel.Location = new Point(138, 9);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(29, 19);
            urlLabel.TabIndex = 2;
            urlLabel.Text = "Url";
            // 
            // Get_Btn
            // 
            Get_Btn.BackColor = SystemColors.ActiveCaption;
            Get_Btn.FlatAppearance.BorderColor = Color.Black;
            Get_Btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Get_Btn.Location = new Point(345, 35);
            Get_Btn.Name = "Get_Btn";
            Get_Btn.Size = new Size(75, 27);
            Get_Btn.TabIndex = 3;
            Get_Btn.Text = "GET";
            Get_Btn.UseVisualStyleBackColor = false;
            Get_Btn.Click += Get_Btn_Click;
            // 
            // Post_Btn
            // 
            Post_Btn.BackColor = Color.LightGreen;
            Post_Btn.FlatAppearance.BorderColor = Color.Black;
            Post_Btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Post_Btn.Location = new Point(426, 35);
            Post_Btn.Name = "Post_Btn";
            Post_Btn.Size = new Size(75, 27);
            Post_Btn.TabIndex = 4;
            Post_Btn.Text = "POST";
            Post_Btn.UseVisualStyleBackColor = false;
            Post_Btn.Click += Post_Btn_Click;
            // 
            // output
            // 
            data.Location = new Point(12, 78);
            data.Multiline = true;
            data.Name = "output";
            data.ScrollBars = ScrollBars.Vertical;
            data.Size = new Size(776, 280);
            data.TabIndex = 5;
            // 
            // Put_Btn
            // 
            Put_Btn.BackColor = Color.Gold;
            Put_Btn.FlatAppearance.BorderColor = Color.Black;
            Put_Btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Put_Btn.Location = new Point(507, 35);
            Put_Btn.Name = "Put_Btn";
            Put_Btn.Size = new Size(75, 27);
            Put_Btn.TabIndex = 6;
            Put_Btn.Text = "PUT";
            Put_Btn.UseVisualStyleBackColor = false;
            Put_Btn.Click += Put_Btn_Click;
            // 
            // Delete_Btn
            // 
            Delete_Btn.BackColor = Color.Red;
            Delete_Btn.FlatAppearance.BorderColor = Color.Black;
            Delete_Btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Delete_Btn.Location = new Point(588, 35);
            Delete_Btn.Name = "Delete_Btn";
            Delete_Btn.Size = new Size(75, 27);
            Delete_Btn.TabIndex = 7;
            Delete_Btn.Text = "DELETE";
            Delete_Btn.UseVisualStyleBackColor = false;
            Delete_Btn.Click += Delete_Btn_Click;
            // 
            // ClearUrl
            // 
            ClearUrl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ClearUrl.Location = new Point(17, 379);
            ClearUrl.Name = "ClearUrl";
            ClearUrl.Size = new Size(97, 28);
            ClearUrl.TabIndex = 8;
            ClearUrl.Text = "Clear Url";
            ClearUrl.UseVisualStyleBackColor = true;
            ClearUrl.Click += ClearUrl_Click;
            // 
            // ClearBody
            // 
            ClearBody.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ClearBody.Location = new Point(138, 379);
            ClearBody.Name = "ClearBody";
            ClearBody.Size = new Size(97, 28);
            ClearBody.TabIndex = 9;
            ClearBody.Text = "Clear Body";
            ClearBody.UseVisualStyleBackColor = true;
            ClearBody.Click += ClearBody_Click;
            // 
            // PostmanFrontForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearBody);
            Controls.Add(ClearUrl);
            Controls.Add(Delete_Btn);
            Controls.Add(Put_Btn);
            Controls.Add(data);
            Controls.Add(Post_Btn);
            Controls.Add(Get_Btn);
            Controls.Add(urlLabel);
            Controls.Add(url);
            Name = "PostmanFrontForm";
            Text = "PostmanFrontForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox url;
        private Label urlLabel;
        private Button Get_Btn;
        private Button Post_Btn;
        private TextBox data;
        private Button Put_Btn;
        private Button Delete_Btn;
        private Button ClearUrl;
        private Button ClearBody;
    }
}