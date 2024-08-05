using Microsoft.Web.WebView2.Core;
using System;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inject
{
    public partial class Form1 : Form
    {
        bool ggh = false;
        public Form1()
        {
            InitializeComponent();
            
            webView21.CoreWebView2InitializationCompleted += WebView2_CoreWebView2InitializationCompleted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webView21.EnsureCoreWebView2Async();
            this.KeyDown += MainForm_KeyDown;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                if (ggh) webView21.CoreWebView2.Navigate("https://google.ru");
            }
        }

        private async void WebView1_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.Handled = true; // Предотвращаем открытие нового окна

            // Загружаем запрошенную страницу в существующее окно
            webView21.CoreWebView2.Navigate(e.Uri);
        }

        private async void WebView2_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs ea)
        {
            ggh = true;

            webView21.CoreWebView2.NewWindowRequested += WebView1_NewWindowRequested;

            // Перехватываем событие загрузки страницы
            webView21.CoreWebView2.DOMContentLoaded += (s, e) =>
            {
                // Вставляем JavaScript для замены текста на картинку
                webView21.CoreWebView2.ExecuteScriptAsync(@"
var elements = document.querySelectorAll('.lnXdpd');
var elementss = document.querySelectorAll('.jfN4p');
var yt = document.querySelectorAll('.ytd-topbar-logo-renderer');

var elementsToRemove = document.querySelectorAll('div.LX3sZb');

elementsToRemove.forEach(function(element) {
    element.remove();
});
var elementsToRemove1 = document.querySelectorAll('div.uU7dJb');

elementsToRemove1.forEach(function(element) {
    element.remove();
});

var elementsToRemove2 = document.querySelectorAll('div[jscontroller=""NzU6V""]');

elementsToRemove2.forEach(function(element) {
    element.remove();
});

var elementsToRemove3 = document.querySelectorAll('.dRYYxd');

elementsToRemove3.forEach(function(element) {
    element.remove();
});



var formElements = document.querySelectorAll('input, textarea');

formElements.forEach(function(element) {
    if (element.value === 'Поиск в Google') {
        element.value = 'Поиск в RosPoisk';
    }
});



// Iterate over each selected element
elements.forEach(function(element) {
    // Create a new img element
    var img = document.createElement('img');
    // Set the src attribute of the img element
    img.src = 'https://i.ibb.co/6vR0G73/section1.png';
    img.style.height = '120px';
    // Replace the element with the new img element
    element.parentNode.replaceChild(img, element);
});

// Iterate over each selected element
elementss.forEach(function(element) {
    // Create a new img element
    var img = document.createElement('img');
    // Set the src attribute of the img element
    img.src = 'https://i.ibb.co/6vR0G73/section1.png';
    img.style.width = '120px';
    // Replace the element with the new img element
    element.parentNode.replaceChild(img, element);
});


// Iterate over each selected element
yt.forEach(function(element) {
window.location.href = ""https://plvideo.ru/"";

});


                ");
            };
            webView21.CoreWebView2.Navigate("https://www.google.ru/");

            // Загружаем веб-страницу
        }

        private void webView21_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            Uri uri = new Uri(e.Uri);
            string path = uri.Host;
            string[] urlBanList = { 
                "www.state.gov",
                "www.whitehouse.gov",
                "ukraine.ua", 
                "www.president.gov.ua",
                "www.nato.int" ,
                "www.nato-pa.int"
            };
        
            if (e.Uri.Contains("%D0%B2%D0%BF%D0%BD") || e.Uri.ToLower().Contains("vpn"))
            {
                string rrr = "";
                rrr = "file:///"+Path.GetDirectoryName(Application.ExecutablePath)+"/vipn.runet.html";

                webView21.CoreWebView2.Navigate(rrr);

            }
            if (path == "www.tiktok.com")
            {

                webView21.CoreWebView2.Navigate("https://plvideo.ru/shorts");
                return;
            }
            if (path == "www.youtube.com")
            {

                webView21.CoreWebView2.Navigate("https://plvideo.ru/");
                return;
            }
            if (path == "www.instagram.com")
            {

                webView21.CoreWebView2.Navigate("https://vk.ru/");
                return;
            }
            if (path == "www.gmail.com")
            {

                webView21.CoreWebView2.Navigate("https://mail.ru/");
                return;
            }
            if (path == "ru-ru.facebook.com" || path == "m.facebook.com")
            {

                webView21.CoreWebView2.Navigate("https://vk.ru/");
                return;
            }
            if (urlBanList.Contains(path))
            {
                webView21.CoreWebView2.Navigate(File.ReadAllText("blocked.runet.data"));
            }
        }

        private void ruNetSearcherToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void росПоискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://google.ru/");
        }

        private void платформаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://plvideo.ru/");
        }

        private void вКонтактеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://vk.ru/");
        }

        private void почтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://mail.ru/");
        }

        private void шортсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://plvideo.ru/shorts");
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(webView21.CoreWebView2.CanGoBack) webView21.CoreWebView2.GoBack();
        }

        private void впередToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webView21.CoreWebView2.CanGoForward) webView21.CoreWebView2.GoForward();

        }

        private void перезагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Reload();
        }

        private void юаньРубльToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://google.ru/search?q=%D0%BA%D1%83%D1%80%D1%81+%D1%8E%D0%B0%D0%BD%D1%8F+%D0%BA+%D1%80%D1%83%D0%B1%D0%BB%D1%8E");
        }
private void рубльЮаньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.google.ru/search?q=%D0%BA%D1%83%D1%80%D1%81%20%D1%80%D1%83%D0%B1%D0%BB%D1%8F%20%D0%BA%20%D1%8E%D0%B0%D0%BD%D1%8E");
        }
        
private void рИАНовостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://ria.ru/");
        }

        private void mAILRUНовостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://news.mail.ru/");
        }

        private void lENTAНовостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://lenta.ru");
        }

        private void первыйКаналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.ivi.ru/tvchannels/watch/1tv");
        }
private void россия1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.ivi.ru/tvchannels/watch/russia1");
        }

        private void россия24ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.ivi.ru/tvchannels/watch/russia24");

        }

        private void нТВToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.ivi.ru/tvchannels/watch/ntv");

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.ivi.ru/tvchannels/watch/5tv");

        }

        private void рЕНТВToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.ivi.ru/tvchannels/watch/ren-tv");

        }

        private void мирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.ivi.ru/tvchannels/watch/friday");

        }

        private void тНТToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.ivi.ru/tvchannels/watch/mir");

        }

        private void тНТToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.ivi.ru/tvchannels/watch/tnt");

        }

        private void webView21_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            MessageBox.Show(e.TryGetWebMessageAsString());
        }

        private void мосХабToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://hub.mos.ru/");
        }

        private void мояШколаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://myschool.edu.ru/");
        }

        private void госуслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://gosuslugi.ru/");
        }

        private void рБКНовостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://rbc.ru/");
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://plvideo.ru/");
        }
    }
}
