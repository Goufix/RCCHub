using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCCHub
{
    class Config
    {
        public void SetCfg(string nick, string TAG, string patente)
        {
            // Eu to tentando fazer isso.
            Properties.Settings.Default.Nick = nick;
            Properties.Settings.Default.TAG = TAG;
            Properties.Settings.Default.Patente = patente;
            Properties.Settings.Default.Save();
        }   
    }
}
