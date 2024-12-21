namespace EmbeddedWebBrowserApp
{
    public partial class Form1 : Form
    {
        static string mainPageUrl = "https://www.google.com";
        public Form1()
        {
            InitializeComponent();

            webViewMain.SourceChanged += WebViewMain_SourceChanged;

            GoHome();
        }

        private void WebViewMain_SourceChanged(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            txtUrl.Text = webViewMain.Source.ToString();

            Text = "WebView2 Test - " + webViewMain.Source.Host;
        }

        void Go(string url)
        {
            try
            {
                webViewMain.Source = new Uri(url);
            }
            catch (UriFormatException ex)
            {
                Search(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GoHome()
        {
            Go(mainPageUrl);
        }
        void GoPrev()
        {
            webViewMain.GoBack();
        }

        void GoNext()
        {
            webViewMain.GoForward();
        }

        void Search(string text)
        {
            Go("https://www.google.com/search?q=" + text);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Go(txtUrl.Text);
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Go(txtUrl.Text);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            GoHome();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            GoPrev();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GoNext();
        }
    }
}
