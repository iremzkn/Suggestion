using Suggestion.Business.Abstract.PersonnelService;
using Suggestion.Core.Utilities.Results.Abstract;
using Suggestion.Core.Utilities.Results.Concrete;
using Suggestion.Domain.Entities.PersonnelEntity;
using Suggestion.Infrastructure.DataAccess.Abstract.Personnel;

namespace Suggestion.Business.Concrete.PersonnelService;

public class PersonnelService : IPersonnelService
{
    private readonly IPersonnelRepository _personnelRepository;

    public PersonnelService(IPersonnelRepository personnelRepository)
    {
        _personnelRepository = personnelRepository;
    }

    public void Add(PersonnelEntity personnelEntity)
    {
        _personnelRepository.Add(personnelEntity);
    }

    public IDataResult<PersonnelEntity> Login(string email, string password)
    {
        return new SuccessDataResult<PersonnelEntity>(_personnelRepository.Get(x => x.Email == email && x.Password == password));
    }
}
