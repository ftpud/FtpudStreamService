using System.Net;

namespace FtpudStreamService.Extensions.WebUi.Auth
{
    public abstract class ResponseExtension
    {
        public abstract WebServerResponse intercept(HttpListenerRequest request);
    }
}