using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace CopyEmoticons
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        public void acaoBotao(Button a)
        {
            alteracao.Text = "O emoticon copiado foi: " + a.Text;
            Clipboard.SetText(a.Text);
        }

        private void shrug_Click(object sender, EventArgs e)
        {
            acaoBotao(shrug);
        }

        private void lennyface_Click(object sender, EventArgs e)
        {
            acaoBotao(lennyface);
        }

        private void hugme_Click(object sender, EventArgs e)
        {
            acaoBotao(hugme);
        }

        private void look_Click(object sender, EventArgs e)
        {
            acaoBotao(look);
        }

        private void money_Click(object sender, EventArgs e)
        {
            acaoBotao(money);
        }

        private void why_Click(object sender, EventArgs e)
        {
            acaoBotao(why);
        }

        private void ohHi_Click(object sender, EventArgs e)
        {
            acaoBotao(ohHi);
        }

        private void pigWhy_Click(object sender, EventArgs e)
        {
            acaoBotao(pigWhy);
        }

        private void pigHi_Click(object sender, EventArgs e)
        {
            acaoBotao(pigHi);
        }

        private void creppyHi_Click(object sender, EventArgs e)
        {
            acaoBotao(creppyHi);
        }

        private void nose_Click(object sender, EventArgs e)
        {
            acaoBotao(nose);
        }

        private void closedSmile_Click(object sender, EventArgs e)
        {
            acaoBotao(closedSmile);
        }

        private void whySparckles_Click(object sender, EventArgs e)
        {
            acaoBotao(whySparckles);
        }

        private void fliptable_Click(object sender, EventArgs e)
        {
            acaoBotao(fliptable);
        }

        private void deathstring_Click(object sender, EventArgs e)
        {
            acaoBotao(deathstring);
        }

        private void emoticon14_Click(object sender, EventArgs e)
        {
            acaoBotao(emoticon14);
        }

        private void emoticon15_Click(object sender, EventArgs e)
        {
            acaoBotao(emoticon15);
        }

        private void emoticon16_Click(object sender, EventArgs e)
        {
            acaoBotao(emoticon16);
        }

        private void emoticon17_Click(object sender, EventArgs e)
        {
            acaoBotao(emoticon17);
        }

        private void emoticon18_Click(object sender, EventArgs e)
        {
            acaoBotao(emoticon18);
        }

        private void emoticon19_Click(object sender, EventArgs e)
        {
            acaoBotao(emoticon19);
        }

        private void emoticon20_Click(object sender, EventArgs e)
        {
            acaoBotao(emoticon20);
        }

        private void emoticon21_Click(object sender, EventArgs e)
        {
            acaoBotao(emoticon21);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Uri myUri = new Uri("http://athoscastro.org/versao.txt");
            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(myUri);
            httpRequest.Timeout = 10000;     // 10 secs
            httpRequest.UserAgent = "Jesus";
            HttpWebResponse webResponse = (HttpWebResponse)httpRequest.GetResponse();
            StreamReader responseStream = new StreamReader(webResponse.GetResponseStream());
            string text = responseStream.ReadLine();
            if (!text.Equals(versao.Text)) {
                atualizado.Text = "O Copy Emoticons está desatualizado.";
            }
        }
    }
}
