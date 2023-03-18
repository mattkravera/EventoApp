using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento.Tests.EndToEnd.Controllers
{
    public class EventsControllerTests
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public EventsControllerTests()
        {
            _server = new TestServer(new WebHostBuilder());
            _client = _server.CreateClient();
        }
    }
}
