using Car.Model;
using Car.Providerl;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Car.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarProvider _carProvider;

        public CarController(ICarProvider carProvider)
        {
            _carProvider = carProvider;
        }

        [HttpGet("honda")]
        public IEnumerable<BrandCar> GetHondaCar()
        {
            throw new Exception("This is a test exception");
        }

        [HttpGet("yamaha")]
        public IEnumerable<BrandCar> GetYamahaCar()
        {
            Task.Delay(6000).Wait();
            return _carProvider.GetCars("Yamaha");
        }

    }
}
