using API_Practice.Models;
using API_Practice.Models.ViewModels;
using API_Practice.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace API_Practice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly JokeAPIClient _client;

        public HomeController(ILogger<HomeController> logger, JokeAPIClient client)
        {
            _logger = logger;
            _client = client;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetRandomJoke()
        {
            var response = await _client.GetRandomJoke();

            var viewModel = new RandomJokeVM();
            viewModel.Type = response.type;
            viewModel.Setup = response.setup;
            viewModel.Punchline = response.punchline;

            return View(viewModel);
        }
        //TODO- figure out how to convert int to enum
        public async Task<IActionResult> GetTenRandomJokes()
        {
            var response = await _client.GetTenRandomJokes();
            var tenJokes = response.Property1[0];

            var viewModel = new TenRandomJokesVM();
            viewModel.Number = tenJokes.id;
            viewModel.Type = tenJokes.type;
            viewModel.Setup = tenJokes.setup;
            viewModel.Punchline = tenJokes.punchline;

            return View(viewModel);

        }

    }
}
