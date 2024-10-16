namespace Task_16._10_
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Vehicle1 vehicle = new Vehicle1("Hyundai","Elantra",15000);

            Gallery1 gallery = new Gallery1();


            Car1 car1 = new Car1("Hyundai", "Elantra", 15000,4);
            Car1 car2 = new Car1("Ronaldo", "Messi", 10, 4);
            gallery.AddCar(car1);
            gallery.AddCar(car2);

            car1.ShowFullInfo();
           

            /*  gallery.FilterCar(10);*/

            Bicycle bicycle = new Bicycle("Kawasaki","Ninja 650",10000,2);

            bicycle.ShowFullInfo();

            
        }
    }
}
