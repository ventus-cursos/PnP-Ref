namespace Ventus
{
    internal class Program
    {
        private static void Main()
        {
            Test1A();
            Test1B();
        }

        //NO
        private static void Test1A()
        {
            DAC.User.Save(123, "areyes", "Alejandro", "Reyes Ramos", "YWJjZGVmZ2hpamtsbW5vCg==", true);
        }

        //YES
        private static void Test1B()
        {
            DAC.User.Save(new BE.User
            {
                ID = 123,
                UserName = "areyes",
                FirstName = "Alejandro",
                LastName = "Reyes Ramos",
                Password = "YWJjZGVmZ2hpamtsbW5vCg==",
                Active = true
            });
        }
    }

    namespace DAC
    {
        public class User
        {
            public static void Save(int id, string UserName, string FirstName, string LastName, string Password, bool Active)
            {
                //TODO: actually
            }
            
            internal static void Save(BE.User user)
            {
                //TODO: actually
            }
        }
    }

    namespace BE
    {
        public class User
        {
            public int ID { get; set; }
            public string UserName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Password { get; set; }
            public bool Active { get; set; }
        }
    }
}
