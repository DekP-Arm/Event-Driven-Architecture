using System.Threading.Tasks;
using EDA.Entity;
using EDA.Infra.Interface;
using EDA.Query.Interface;
using EDA.Query;

namespace EDA.QueryHandler
{
    public class GetUserbyIdQueryHandler : IQueryHandler<GetUserbyId, UserDbo>
    {
        private readonly IUserRepository _userRepository;

        public GetUserbyIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDbo> HandleAsync(GetUserbyId query)
        {
            return await _userRepository.GetUserByIdAsync(query.Id);
        }
    }
}
