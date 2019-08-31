using System;
using System.Runtime.InteropServices;

namespace Kassenautomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Kassenautomat automat = new Kassenautomat();

            WriteHeader();
            GeldEinwerfenRoutine geldEinwerfen = new GeldEinwerfenRoutine(automat, new []{10,20,50,100,200,500});
            geldEinwerfen.Run();


            Console.ReadLine();
        }

        private static void WriteHeader()
        {
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*********************** KASSENAUTOMAT 1 ************************");
            Console.WriteLine("****************************************************************");
        }
    }

    internal class GeldEinwerfenRoutine
    {
        private readonly IKassenautomat _automat;
        private readonly int[] _acceptedValuesForCoin;

        public GeldEinwerfenRoutine(IKassenautomat automat, int[] acceptedValuesForCoin)
        {
            _automat = automat;
            _acceptedValuesForCoin = acceptedValuesForCoin;
        }
        public void Run()
        {
            WriteHeader();
            string input = string.Empty;

            while (input?.ToLower() != "zahlen")
            {
                input = Console.ReadLine();
                InputEvaluationResult result = InputEvaluator.Evaluate(input, _acceptedValuesForCoin);

                if (result.IsValidNumber && result.Number.HasValue)
                {
                    _automat.InsertCoin(result.Number.Value);
                }
                else
                {
                    Console.WriteLine("Sie haben einen ungueltigen Wert eingegeben.");
                    this.WriteHeader();
                }
            }
        }

        private void WriteHeader()
        {
            Console.WriteLine("Bitte geben sie die Münzen in Rappen ein...");
            Console.WriteLine(
                $"Der Automat akzeptiert nur Muenzen in folgenden Rappenstuecken: {string.Join(", ", _acceptedValuesForCoin)})");
            Console.WriteLine($"Um zu bezahlen, schreiben sie \"zahlen\"");
        }
    }
}
