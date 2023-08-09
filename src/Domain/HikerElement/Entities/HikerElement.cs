using Domain.Common;
using Domain.HikerElement.Dtos;

namespace Domain.HikerElement.Entities;

public class HikerElement: BaseAuditableEntity
{
    public int Weight { get;set; }
    public int Calories { get;set; }
    
    public static HikerElement FromHikerElementDtoToHikerElement(HikerElementDto hikerElementDto)
    {
        return new HikerElement
        {
            Weight = hikerElementDto.Weight,
            Calories = hikerElementDto.Calories
        };
    }

    public void Update(HikerElementUpdateDto hikerElementUpdateDto)
    {
        Calories = hikerElementUpdateDto.Calories;
        Weight = hikerElementUpdateDto.Weight;
        LastModified = DateTime.Now;
    }
}
