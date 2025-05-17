using Interface_communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lejeu.IA_taperdefense
{
    public class ActionIAtaperDefense
    {

        public ActionIAtaperDefense() 
        {

        }

        public List<Message> AITaperDefenseBanzai(int tour, List<Message> messages)
        {
           
            int tourmod = tour % 4;
            switch (tourmod)
            {
                default: messages.Add(new Message("UTILISER", ["ATTAQUE"]));
                    messages.Add(new Message("ATTAQUER",["0"]));

                    break;

                case 1:messages.Add(new Message("PIOCHER", ["1"])); break;
                case 2: messages.Add(new Message("PIOCHER", ["0"])); break;
                case 3: messages.Add(new Message("PIOCHER", ["0"])); break;
            }
            return messages;
        }

    }
}
