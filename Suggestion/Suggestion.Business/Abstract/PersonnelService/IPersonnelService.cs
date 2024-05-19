using Suggestion.Core.Utilities.Results.Abstract;
using Suggestion.Domain.Entities.PersonnelEntity;

namespace Suggestion.Business.Abstract.PersonnelService;

public interface IPersonnelService
{
    IDataResult<PersonnelEntity> Login(string email, string password);
    public void Add(PersonnelEntity personnelEntity);
}
