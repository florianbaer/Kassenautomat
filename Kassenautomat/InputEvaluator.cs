using System.Linq;

namespace Kassenautomat
{
    internal class InputEvaluator
    {
        public static InputEvaluationResult Evaluate(string input, int[] acceptedValuesForCoin)
        {
            InputEvaluationResult result = new InputEvaluationResult();
            if (int.TryParse(input, out int number))
            {
                result.Number = number;
                if (acceptedValuesForCoin.Any(x => x == number))
                {
                    result.IsValidNumber = true;
                }
            }
            else
            {
                result.Number = null;
                result.IsValidNumber = false;
            }

            return result;
        }
    }
}