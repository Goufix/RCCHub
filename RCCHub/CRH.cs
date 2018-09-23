using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace RCCHub
{
    class CRH
    {
        /*public string[] BBCode(string nick, string position, string TAG, string reciever, string refweak, string medals)
        {
        }*/
        public string Link()
        {
            string link = "";
            WebClient client = new WebClient();
            link = client.DownloadString("http://www.policiarcc.com/f185-requerimentos-promocoes-rebaixamentos-desligamentos-e-gratificacoes");
            link = link.Substring(link.IndexOf("formulario-gratificacoes-efetivas") - 14, 40);
            link = "http://policiarcc.com" + link.Substring(link.IndexOf("=") + 2);
            return link;
        }
        public void Dialog()
        {
            string cp = "BBCode copiado para a área de tranferência, deseja abrir os requerimentos do CRH?";
            DialogResult req = MessageBox.Show(cp, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (req == DialogResult.Yes)
            Link();
            string reqLink = Link();
            System.Diagnostics.Process.Start(reqLink);
        }
    }
}
