namespace EmbeddedWebBrowserApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            webViewMain = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel1 = new Panel();
            txtUrl = new TextBox();
            label1 = new Label();
            btnGo = new Button();
            btnNext = new Button();
            btnPrev = new Button();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)webViewMain).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // webViewMain
            // 
            webViewMain.AllowExternalDrop = true;
            webViewMain.CreationProperties = null;
            webViewMain.DefaultBackgroundColor = Color.White;
            webViewMain.Dock = DockStyle.Fill;
            webViewMain.Location = new Point(0, 51);
            webViewMain.Name = "webViewMain";
            webViewMain.Size = new Size(800, 399);
            webViewMain.TabIndex = 0;
            webViewMain.ZoomFactor = 1D;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtUrl);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGo);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnPrev);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 51);
            panel1.TabIndex = 1;
            // 
            // txtUrl
            // 
            txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUrl.BorderStyle = BorderStyle.FixedSingle;
            txtUrl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUrl.Location = new Point(196, 13);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(564, 29);
            txtUrl.TabIndex = 2;
            txtUrl.KeyDown += txtUrl_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(158, 16);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 1;
            label1.Text = "URL";
            // 
            // btnGo
            // 
            btnGo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGo.FlatStyle = FlatStyle.Flat;
            btnGo.Image = Properties.Resources.next__1_;
            btnGo.Location = new Point(759, 13);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(26, 29);
            btnGo.TabIndex = 0;
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // btnNext
            // 
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = Properties.Resources.next;
            btnNext.Location = new Point(104, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(48, 44);
            btnNext.TabIndex = 0;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Image = Properties.Resources.previous;
            btnPrev.Location = new Point(57, 3);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(48, 44);
            btnPrev.TabIndex = 0;
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnHome
            // 
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Image = Properties.Resources.house_black_silhouette_without_door;
            btnHome.Location = new Point(3, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(48, 44);
            btnHome.TabIndex = 0;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webViewMain);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "WebView2 Test";
            ((System.ComponentModel.ISupportInitialize)webViewMain).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewMain;
        private Panel panel1;
        private Button btnHome;
        private TextBox txtUrl;
        private Label label1;
        private Button btnGo;
        private Button btnNext;
        private Button btnPrev;
    }
}
