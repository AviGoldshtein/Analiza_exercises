using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandoExercise.Factorys
{
    internal class CommandoFactory
    {
        List<Commando> commandos = new List<Commando>();

        Random rnd = new Random();

        /// <summary>
        /// aaaaaaaaaa
        /// </summary>
        /// <param name="type">x</param>
        /// <param name="name">y</param>
        /// <param name="codeName">z</param>
        public void FactoyCommando(string type, string name, string codeName)
        {
            switch (type.ToLower())
            {
                case "commando":
                    commandos.Add(new Commando(name, codeName));
                    break;
                case "sea commando":
                    commandos.Add(new SeaCommando(name, codeName));
                    break;
                case "air commando":
                    commandos.Add(new AirCommando(name, codeName));
                    break;
                default:
                    break;
            }
        }


        public void AddNewCommandos(int howMuch)
        {
            for (int i = 0; i < howMuch; i++)
            {
                commandos.Add(CreateCommando());
            }
        }
        public Commando CreateCommando()
        {
            string[] commandosType = {"Commando", "SeaCommando", "AirCommando" };
            string chosenType = commandosType[rnd.Next(commandosType.Length)];

            var details = CreatedetailesCommando();
            string name = details.Name;
            string codeName = details.ConeName;

            switch (chosenType)
            {
                case "Commando":
                    return new Commando(name, codeName);
                case "SeaCommando":
                    return new SeaCommando(name, codeName);
                case "AirCommando":
                    return new AirCommando(name, codeName);
                default:
                    break;
            }
            return new Commando(name, codeName);

        }

        public (string Name, string ConeName) CreatedetailesCommando()
        {
            string[] names = {"avi", "moshe", "nachum" };
            string[] codeNames = {"kodkod", "secret code", "tuktuk" };

            string name = names[rnd.Next(names.Length)];
            string codeName = codeNames[rnd.Next(codeNames.Length)];

            return (name, codeName);
        }
    }
}
