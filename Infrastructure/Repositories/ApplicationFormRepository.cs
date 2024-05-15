using CapitalPlacementAPI.Infrastructure.IRepositories;
using CapitalPlacementAPI.Models.Entities;

namespace CapitalPlacementAPI.Infrastructure.Repository;

public class ApplicationFormRepository : GenericRepository<ApplicationForm>, IApplicationFormRepository
{
    public ApplicationFormRepository(IConfiguration configuration) : base(configuration)
    {
    }
}

