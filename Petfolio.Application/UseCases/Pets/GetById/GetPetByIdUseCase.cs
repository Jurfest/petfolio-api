using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = 1,
            Name = "Doguito",
            Birthday = new DateTime(year: 2023, month: 01, day: 18),
            Type = PetType.Dog
        };
    }
}