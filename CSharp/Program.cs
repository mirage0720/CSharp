using System.Numerics;
using System.Xml.Serialization;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           Game game = new Game();

            while (true)
            {
                game.Process();
            }
        }
    }
}
