using System.ComponentModel.DataAnnotations;

namespace Automarket.Domain.Enum
{
    public enum TypeCar
    {
        [Display(Name = "Легковой автомобиль")]
        PassengerCar,

        [Display(Name = "Седан")]
        Sedan,

        [Display(Name = "Хетчбек")]
        HatchBack,

        [Display(Name = "Минивен")]
        MiniVan,

        [Display(Name = "Спорткар")]
        SportCar,

        [Display(Name = "Внедорожник")]
        Suv,
    }
}
