using Microsoft.AspNetCore.Mvc;
using YudizPractical.Services;

namespace YudizPractical.Controllers
{
    public class GithubController : Controller
    {
        private readonly IGithubService _githubService;

        public GithubController(IGithubService githubService)
        {
            _githubService = githubService;
        }
        public IActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> Details(string gitRepoName)
        {
            //if (string.IsNullOrWhiteSpace(gitRepoName))
            //{
            //    return NotFound();
            //}

            return View(await _githubService.GetAccountDetails(gitRepoName));

        }
    }
}
