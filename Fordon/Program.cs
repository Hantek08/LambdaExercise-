// See https://aka.ms/new-console-template for more information
internal class Program
{
    public enum Cars{Renault, Toyota, Mercedes, Tesla };

  public static List<Cars> cars = new List<Cars>();
 
   public static void RandomInit(int nrRandomCars)
    {
        Random rnd = new Random();
        for (int i = 0; i <nrRandomCars ; i++)
        {
            cars.Add((Cars)rnd.Next((int)Cars.Renault, (int)Cars.Tesla + 1));
        }

    }
    public static void NrOfEatchCars(Cars searchCar)
    {
        var counter = 0;
        cars.ForEach(n =>
          {
              if (n == searchCar)

                  counter++;
          });
        Console.WriteLine($"This has {counter} elements of {searchCar}");
    }
  
    
    static void Main(string[] args)
    {
        RandomInit(100);
        for (var i = Cars.Renault; i < Cars.Tesla + 1; i++)
        {
            NrOfEatchCars(i);
        }
      

    }
}
