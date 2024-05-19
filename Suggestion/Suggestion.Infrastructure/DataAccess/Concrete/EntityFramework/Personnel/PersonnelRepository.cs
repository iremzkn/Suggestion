using Suggestion.Core.DataAccess.EntityFramework;
using Suggestion.Domain.Entities.PersonnelEntity;
using Suggestion.Infrastructure.Contexts;
using Suggestion.Infrastructure.DataAccess.Abstract.Personnel;

namespace Suggestion.Infrastructure.DataAccess.Concrete.EntityFramework.Personnel;

public class PersonnelRepository : EfEntityRepositoryBase<PersonnelEntity, SuggestionContext>, IPersonnelRepository
{
}