using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GrammarbotWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        public void ShowTypo(Label label,string message)
        {
            ToolTip ttp = new ToolTip();            

            ttp.ToolTipIcon = ToolTipIcon.Info;
            
            ttp.Show(message, label,0,0,3000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                int i = 0;
                GrammarBot gBot = new GrammarBot();
                gBot.API_Key = txtAPI_Key.Text;
                gBot.language = txtLanguage.Text;
                gBot.CheckGrammar(txtSentense.Text);

                while (gBot.GResponse == null&& i<10)
                {
                    i++;
                    lblStatus.Text = "Checking Grammar";
                }
                if (i >= 10)
                    MessageBox.Show("Time out ...");
                if (gBot.GResponse != null)
                {
                    if (gBot.GResponse.matches.Count > 0)
                    {
                        ShowTypo(lblSentense, gBot.GResponse.matches[0].message);
                    }
                }
            }
            finally
            {
                this.Enabled = true;
            }
        }
    }
}

