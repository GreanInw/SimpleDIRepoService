using SimpleDI.Training.Repositories.Identities;

namespace SimpleDI.Training.Services.Identities.Memberships
{
    internal class RegisterService : IRegisterService
    {
        private readonly IMembershipRepository _membershipRepository;

        public RegisterService(IMembershipRepository membershipRepository)
        {
            _membershipRepository = membershipRepository;
        }

        public Task RegisterAsync(string username, string password)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IRegisterService
    {
        Task RegisterAsync(string username, string password);
    }
}
