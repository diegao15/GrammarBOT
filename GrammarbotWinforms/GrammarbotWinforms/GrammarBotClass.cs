using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GrammarbotWinforms
{   
    public class Software
    {
        public string name { get; set; }
        public string version { get; set; }
        public int apiVersion { get; set; }
        public bool premium { get; set; }
        public string premiumHint { get; set; }
        public string status { get; set; }
    }

    public class Warnings
    {
        public bool incompleteResults { get; set; }
    }

    public class DetectedLanguage
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Language
    {
        public string name { get; set; }
        public string code { get; set; }
        public DetectedLanguage detectedLanguage { get; set; }
    }

    public class Replacement
    {
        public string value { get; set; }
    }

    public class Context
    {
        public string text { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
    }

    public class Type
    {
        public string typeName { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Rule
    {
        public string id { get; set; }
        public string subId { get; set; }
        public string description { get; set; }
        public string issueType { get; set; }
        public Category category { get; set; }
    }

    public class Match
    {
        public string message { get; set; }
        public string shortMessage { get; set; }
        public IList<Replacement> replacements { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
        public Context context { get; set; }
        public string sentence { get; set; }
        public Type type { get; set; }
        public Rule rule { get; set; }
    }

    public class GrammarResponse
    {
        public Software software { get; set; }
        public Warnings warnings { get; set; }
        public Language language { get; set; }
        public IList<Match> matches { get; set; }
    }
    public class GrammarBot
    {
        public string API_Key { get; set; }
        public string language { get; set; }
        public GrammarResponse GResponse { get => gResponse;  }       

        private GrammarResponse gResponse;


        public async void CheckGrammar(string sentense)
        {
            gResponse = null;
            
            WebClient webClient = new WebClient();
            webClient.QueryString.Add("api_key", API_Key);
            webClient.QueryString.Add("text", sentense);
            webClient.QueryString.Add("language", language);

            string respjson = webClient.DownloadString("http://api.grammarbot.io/v2/check");
            
            gResponse= JsonConvert.DeserializeObject<GrammarResponse>(respjson);
        }
    }
}
