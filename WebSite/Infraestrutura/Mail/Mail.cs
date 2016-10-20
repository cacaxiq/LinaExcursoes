using RestSharp;
using RestSharp.Authenticators;

namespace WebSite.Infraestrutura.Mail
{
    public class Mail
    {
        public static RestResponse SendSimpleMessage()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new System.Uri("https://api.mailgun.net/v3");
            client.Authenticator =
                   new HttpBasicAuthenticator("api",
                                              "key-33b01822b7fb1cd46d267dd02c90eb54");
            RestRequest request = new RestRequest();
            request.AddParameter("domain",
                                "sandboxde0b4e64c37440a9bd426a1b9a1ea280.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "Mailgun Sandbox <postmaster@sandboxde0b4e64c37440a9bd426a1b9a1ea280.mailgun.org>");
            request.AddParameter("to", "Carlos Henrique Rocha Gabriel <carloshenriquerg@gmail.com>");
            request.AddParameter("subject", "Hello Carlos Henrique Rocha Gabriel");
            request.AddParameter("text", "Congratulations Carlos Henrique Rocha Gabriel, you just sent an email with Mailgun!  You are truly awesome!  You can see a record of this email in your logs: https://mailgun.com/cp/log .  You can send up to 300 emails/day from this sandbox server.  Next, you should add your own domain so you can send 10,000 emails/month for free.");
            request.Method = Method.POST;
            return (RestResponse)client.Execute(request);
        }
    }
}