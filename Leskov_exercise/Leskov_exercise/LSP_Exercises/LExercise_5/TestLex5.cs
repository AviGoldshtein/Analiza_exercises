using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.Exercise_5
{
    internal class TestLex5 : Itest
    {
        public void Run()
        {
            List<Validator> validators = new List<Validator>();
            for (int i = 0; i < 10; i++)
            {
                Validator validator = new Validator();
                validators.Add(validator);
            }

            StrictValidator strictValidator = new StrictValidator();
            strictValidator.RunValidation(validators);
        }
    }
}
