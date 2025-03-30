using Car.Model;
using Car.Providerl;

namespace Car.Provider
{
    public class CarProvider : ICarProvider
    {
        
        private List<BrandCar> listCar = new List<BrandCar>()
        {
            new BrandCar("Honda","Winner X",1),
            new BrandCar("Honda","CBR1000RRR",4),
            new BrandCar("Honda","Air Blade",5),
            new BrandCar("Honda","Vision",266),
            new BrandCar("Honda","SH 350i",754),
            new BrandCar("Honda","Wave RSX",536),
            new BrandCar("Honda","Lead",76),
            new BrandCar("Honda","Winner V1",54),
            new BrandCar("Honda","CBR150RR",32),
            new BrandCar("Honda","Future",86),
             new BrandCar("Yamaha","Elegant",76),
            new BrandCar("Yamaha","Janus",45),
            new BrandCar("Yamaha","Lexi",73),
            new BrandCar("Yamaha","Grande",64),
            new BrandCar("Yamaha","Freego",86),
            new BrandCar("Yamaha","Latte",45),
            new BrandCar("Yamaha","NVX",75),
            new BrandCar("Yamaha","Exciter",53),
            new BrandCar("Yamaha","R1",643),
            new BrandCar("Yamaha","Sirius",26),
        };

      
        public List<BrandCar> GetCars(string Brand)
        {

            List<BrandCar> br = new List<BrandCar>();
            br = listCar.Where(x => x.Brand == Brand).ToList();
            return br;

        }
    }
}
