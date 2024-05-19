using Suggestion.Core.DataAccess.EntityFramework;
using Suggestion.Domain.Entities.PersonnelEntity;

namespace Suggestion.Infrastructure.DataAccess.Abstract.Personnel;

public interface IPersonnelRepository : IEntityRepository<PersonnelEntity>
{
}
