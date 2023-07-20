using Home_Work_18.DataBases;
using Home_Work_18.Moduls;

namespace Home_Work_18.Service
{
    public static class ServiceToPassport
    {
        public static void AddPassport(long id, string code)
        {
            var db = new CRUDDB();
            db.passports.Add(new Passport()
            {
                Id = id,
                Code = code
            });
        }

    }
}
