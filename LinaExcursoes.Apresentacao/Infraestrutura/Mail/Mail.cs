using RestSharp;
using RestSharp.Authenticators;

namespace LinaExcursoes.Apresentacao.Infraestrutura.Mail
{
    public class Mail
    {
        public static RestResponse SendSimpleMessage(string mensagem)
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
            request.AddParameter("to", "Lina Paula <contato@linaexcursoes.com.br>");
            request.AddParameter("subject", "Mensagem - Fale Conosco Lina Excursão");
            request.AddParameter("text", mensagem);
            request.Method = Method.POST;
            return (RestResponse)client.Execute(request);
        }
    }
}