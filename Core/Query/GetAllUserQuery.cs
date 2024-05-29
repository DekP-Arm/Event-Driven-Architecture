using System.Threading.Tasks;
using EDA.Entity;
using EDA.Infra.Interface;
using EDA.Query.Interface;
using EDA.Query;

namespace EDA.QueryHandler
{
    public class GetAllUserQueryHandler : IQueryHandler<GetAllUserQuery, UserDbo>
    {
        private readonly IUserRepository _userRepository;

        public GetAllUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDbo> HandleAsync(GetAllUserQuery query)
        {
            return await _userRepository.GetUserByIdAsync(query.Id);
        }
    }
}
