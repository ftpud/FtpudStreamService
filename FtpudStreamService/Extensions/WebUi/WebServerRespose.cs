using System.Net;

namespace FtpudStreamService.Extensions.WebUi
{
    public class WebServerResponse
    {
        public WebServerResponse(string body)
        {
            payload = body;
            cookies = new CookieCollection();
        }

        public WebServerResponse()
        {
        }

        public string payload { get; set; }
        public CookieCollection cookies { get; set; }
    }
}