using System.Text.Json;
using YudizPractical.Domain;
using YudizPractical.Repositories;

namespace YudizPractical.Services
{
    public class GithubService : IGithubService
    {
        private readonly IGithubRepository _githubRepository;

        //private readonly HttpClient _client;

        public GithubService(IGithubRepository githubRepository)
        {
            _githubRepository = githubRepository;
            //_client = new HttpClient()
            //{
            //    BaseAddress = new Uri("https://api.github.com")
            //};
        }

        public async Task<Github> GetAccountDetails(string gitUsername)
        {
            gitUsername = "octocat";
            HttpClient _client = new HttpClient();
            _client = new HttpClient()
            {
                BaseAddress = new Uri("https://api.github.com")
            };
            var url = string.Format("/Users/{0}", gitUsername);
            //var result = new List<HolidayModel>();
            var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                //result = JsonSerializer.Deserialize<List<HolidayModel>>(stringResponse,
                //    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            return await _githubRepository.GetAccountDetails(gitUsername);
        }
    }
}
