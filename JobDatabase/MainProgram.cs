using System.Text;

namespace JobDatabase {
    internal class MainProgram {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            var start = new InputProcessing();
            start.Start();
        }
        
    }
}