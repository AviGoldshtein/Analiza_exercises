using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.Exercise_5
{
    internal class StrictValidator
    {
        public void RunValidation(List<Validator> validators)
        {
            foreach (Validator validator in validators)
            {
                Console.WriteLine($"IsValid: {validator.IsValid("abc")}");
            }
        }
    }
}
