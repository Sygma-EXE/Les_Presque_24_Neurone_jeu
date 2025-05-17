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
        Connexion Connexions = Connexion.Instance;
        public ActionIAtaperDefense()
        {
            Console.WriteLine(Connexions.RecevoirMessage());
        }
    }
}
