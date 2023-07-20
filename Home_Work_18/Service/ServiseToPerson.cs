using Home_Work_18.DataBases;
using Home_Work_18.Moduls;


namespace Home_Work_18.Service
{
    public static class ServiceToPerson
    {
        public static void AddToPerson(string name, long passportId, IList<Car> cars)
        {
            var db = new CRUDDB();
            db.children.Add(new Person()
            {
                Name = name,
                PassportId = passportId,
                Cars = cars
            });
            db.SaveChanges();
        }

        public static void UpdatePersonName(long id, string name)
        {
            var db = new CRUDDB();
            var children = db.children.FirstOrDefault(user => user.Id == id);
            children.Name = name;
            db.children.Update(children);
            db.SaveChanges();
        }

        public static void DeletePerson(long id)
        {
            var db = new CRUDDB();
            var user = db.children.FirstOrDefault(user => user.Id == id);
            if (user == null)
            {
                Console.WriteLine("Bunda user yuq");
            }
            else
            {
                db.children.Remove(user);
                Console.WriteLine("deleted");
                db.SaveChanges();
            }
        }
    }
}
