using Home_Work_18.DataBases;
using Home_Work_18.Moduls;


namespace Home_Work_18.Service
{
    public static class ServiceToCar
    {
        public static void AddToCar(string name, IList<Person> persons)
        {
            var db = new CRUDDB();
            db.cars.Add(new Car()
            {
                Name = name,
                Children = persons
            });
            db.SaveChanges();
        }
    }
}
