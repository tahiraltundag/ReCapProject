using Core.Entities;

namespace Entities.DTOs;

public class CarDetailDto : Dto
{
    public string CarName { get; set; }
    public string BrandName { get; set; }
    public string ColorName { get; set; }
    public double DailyPrice { get; set; }
}