<h3>GrammarBOT</h3>
GRammarBOT API <a href="https://www.grammarbot.io/">https://www.grammarbot.io/</a>

Hello there, this project is part of a teamwork there are aimed to show all levels of programmers how to use GrammarBot API from 
the common used languages nowadays all around the word, im glad to make part of this team and hope it is only the beginning.
If you have any idea or suggestion to make it better, plz let us know.

special thanks for <a href="https://jsonutils.com/">https://jsonutils.com/</a> that i use to generate the class needed, from a simple JSON string response.

<h3>This Poject</h3>
This project is a simple example of how to use this API working with C#, on the exmaple i used Visual Studio Community 2017.

<h3>Applicability</h3>
This is a useful tool to develop grammar check functions on all kinds of applications, in less words is a easy way to prevend typo mistakes from the user, or help you to implement educational applications.

<h3>Get Start</h3>
To get Start with that project you need to have a basic knowledge about C# and Nuget, and also create an account on https://www.grammarbot.io/quickstart to acquire your API_KEY wich is essential to make that project works.

<h3>HELP</h3>
If you have any question or any kind of difficult, plz left a message.

<h3>Maintain</h3>
This project is maintained by the management team of api grammarbot

<h1>STEP BY STEP</h1>
<p></p>
<ul>
<li>Visual Studio Community 2017</li>
<p>First of all you need to have installed Visual Studio 2017 Community(Free)
<a href="https://visualstudio.microsoft.com/pt-br/downloads/">(https://visualstudio.microsoft.com/pt-br/downloads/)</a> on your computer.</p>

<li>Registration</li>
<p>Then you need to subimit your email on https://www.grammarbot.io/signup to receive your API_KEY wich one will be used for all the calls
from your application to the API.</p>

<li>Create Project</li>
<p>After install Visual Studio 2017 Community you will need to create a new project , you can choose what Platform to work, on that example
i used a simple Windows Form Application.</p>

<li>Understanding JSON</li> 
<p>All the API calls that we are going to make use a simple text format to transport all that information, that format is called JSON,
but we cannot simply get that response from the server and show to the user, we have to process and make that information useful to
the program, so after create a class from that response, i used Newtonsoft.Json to transform that text response on the object that i need
to work, you just need to go on Nuget Package managment and search for Newtonsoft.Json install and start to use it after declare 
using Newtonsoft.Json on your C# file header;</p>

<li>Source Code</li>
<p>The project that im going to share with you guys have a class with a simple way to implement that calls using an async task and that 
Package, fell free to download it and make it better.</p>

<li>Using<lli>
<p>To call that API you just need to have three parameters:</p>
<ol>
<li>First one is the API_KEY that you get from the SIGNUP https://www.grammarbot.io/signup</li>
<li>Second one is the sentence that you want to check</li>
<li>And Third is the language you are going to check: "en-US"</li>
<ol>
</ul>
<h1>Example</h1>
<p>After declare the class provided, on your cs file header you just need to instanciate the object and use it as you can see on the code below</p>
  <br />  
  // declare and instanciate the object from the class provided<br />
  GrammarBot gBot = new GrammarBot();<br />
  
  // setup you API key <br />
  gBot.API_Key = txtAPI_Key.Text;<br />
  
  // setup you language , it an be en-US or another one you want <br />
  gBot.language = txtLanguage.Text;<br />
  
  //call the function that will call the API itself <br />
  gBot.CheckGrammar(txtSentense.Text);<br />
  
  <br />
  <p>After that you just need to check about the response on the "Matches" Array </p>
  
  //Check if there are any response from the server<br />
  if (gBot.GResponse != null)<br />
  {<br />
      //Check it there are any mistakes on the sentense to alert the user<br />
      if (gBot.GResponse.matches.Count > 0)<br />
      {<br />
          //Show the first suggestion to the user, it could also be a loop and 
          the suggestions listed on a multiline textbox<br />
          MessageBox.Show( gBot.GResponse.matches[0].message);<br />
      }<br />
  }<br />

<p>To avoid the program to freeze, the function that calls the API is Asynchronous, so the response will not come immediately
 after you call the function "CheckGrammar", because of that,before you check the response, you can use a loop just to give some time to the api to return the information, as you can see below<p/>
 <br />
 <p>REMEBER THAT LOOP HAVE TO COME BEFORE YOU CHECK THE THE RESPONSE</p> 
 
 //give 10 seconds to the API return something<br />
 while (gBot.GResponse == null&& i<10)<br />
{<br />
    i++;<br />
    lblStatus.Text = "Checking Grammar";<br />
}<br />
if (i >= 10)<br />
//if there are nothing on the response so we got a TimeOut<br />
    MessageBox.Show("Time out ...");<br />
    <br />
    
 <p>THE ENTIRE CODE WILL BE THIS</p> 
 <br />  
  // declare and instanciate the object from the class provided<br />
  GrammarBot gBot = new GrammarBot();<br />
  
  // setup you API key <br />
  gBot.API_Key = txtAPI_Key.Text;<br />
  
  // setup you language , it an be en-US or another one you want <br />
  gBot.language = txtLanguage.Text;<br />
  
  //call the function that will call the API itself <br />
  gBot.CheckGrammar(txtSentense.Text);<br />
  
   <br />
 //give 10 seconds to the API return something<br />
 while (gBot.GResponse == null&& i<10)<br />
{<br />
    i++;<br />
    lblStatus.Text = "Checking Grammar";<br />
}<br />
if (i >= 10)<br />
//if there are nothing on the response so we got a TimeOut<br />
    MessageBox.Show("Time out ...");<br />
    
  <p>//After that you just need to checK about the response on the "Matches" Array </p>  
  //Check if there are any response from the server<br />
  if (gBot.GResponse != null)<br />
  {<br />
      //Check it there are any mistakes on the sentense to alert the user<br />
      if (gBot.GResponse.matches.Count > 0)<br />
      {<br />
          //Show the first suggestion to the user, it could also be a loop and 
          the suggestions listed on a multiline textbox<br />
          MessageBox.Show( gBot.GResponse.matches[0].message);<br />
      }<br />
  }<br />
    

<h3>Conclusion</h3>
  
<p>After call the Web service you will get a lot of info on the response, but, the Typos suggestions will come on "Matchs" arrays
as you guys can see on the example.</p>
