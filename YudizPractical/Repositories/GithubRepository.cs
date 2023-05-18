using YudizPractical.Domain;

namespace YudizPractical.Repositories
{
    public class GithubRepository : BaseRepository,IGithubRepository
    {

        public GithubRepository(IConfiguration configuration) : base(configuration) { }

        public Task<int> CreateAsync(Github entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Github> GetAccountDetails(string gitUsername)
        {
            throw new NotImplementedException();
        }

        public Task<List<Github>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Github> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Github entity)
        {
            throw new NotImplementedException();
        }
    }
}
