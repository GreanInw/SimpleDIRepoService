using SimpleDI.Training.DbContexts;
using SimpleDI.Training.Models.Identities;
using SimpleDI.Training.Repositories.Bases;

namespace SimpleDI.Training.Repositories.Identities
{
    internal class MembershipRepository : BaseRepository<IIdentityDbContext, Membership>, IMembershipRepository
    {
        public MembershipRepository(IIdentityDbContext dbContext) : base(dbContext) { }
    }

    internal interface IMembershipRepository : IRepository<Membership> { }
}
