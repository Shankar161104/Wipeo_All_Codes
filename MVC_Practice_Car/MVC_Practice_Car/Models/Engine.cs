namespace MVC_Practice_Car.Models
{
    public class Engine
    {
        public string TypeOfEngine { get; set; }
        public int NoOfCylinders { get; set; }
        public int Torque { get; set; }

        public static string ICEngine()
        {
            return "I am Engine, The Heart of your Car";
        }
    }
}
