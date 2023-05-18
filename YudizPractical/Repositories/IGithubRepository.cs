using YudizPractical.Domain;

namespace YudizPractical.Repositories
{
    public interface IGithubRepository : IRepository<Github>
    {
        public Task<Github> GetAccountDetails(string gitUsername);
    }
}
