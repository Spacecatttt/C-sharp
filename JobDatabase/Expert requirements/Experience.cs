using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public class Experience : IExpertRequirements {
        public string Name { get { return $"посада {Position} - час {Duration}" ; } }
        public string Position { get; set; }
        public string Duration { get; set; }
        public Experience(string name, string duration) {
            Position = name;
            Duration = duration;
        }
        public static Experience Create() {
            Console.Write("Введіть посаду: ");
            string name = Console.ReadLine();
            Console.Write("Введіть дані досвіду(час): ");
            string duration = Console.ReadLine();

            return new Experience(name, duration);
        }
    }
}
