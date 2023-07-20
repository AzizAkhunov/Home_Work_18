using Home_Work_18.DataBases;
using Home_Work_18.Moduls;
using Home_Work_18.Service;
using Microsoft.EntityFrameworkCore;

var db = new CRUDDB();
IList<Person> children = new List<Person>();
IList<Car> cars = new List<Car>();

//ServiceToPassport.AddPassport(1, "AB456456");
//ServiceToCar.AddToCar("Merc", children);
//ServiceToPerson.AddToPerson("Jakbar",1,cars);

ServiceToPerson.UpdatePersonName(2,"Akbar");

//foreach (var item in db.cars.ToList())
//{
//    cars.Add(item);
//}


//var results = db.children.Include(u => u.Cars).ToList();

//foreach (var item in results)
//{
//    Console.WriteLine($"{item.Id} {item.Name} ");
//    foreach (var car in cars)
//    {
//        Console.WriteLine(car.Name);
//    }
//}
