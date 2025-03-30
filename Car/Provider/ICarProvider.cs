using Car.Model;

namespace Car.Providerl;

public interface ICarProvider
{
    List<BrandCar> GetCars(string Brand);
}
