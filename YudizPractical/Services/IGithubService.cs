using YudizPractical.Domain;

namespace YudizPractical.Services
{
    public interface IGithubService
    {
        public Task<Github> GetAccountDetails(string gitUsername);
    }
}
