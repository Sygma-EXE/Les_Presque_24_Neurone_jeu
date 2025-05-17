using Interface_communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAPresque24h
{
    public class IA : IntelligenceArtificielle
    {
        public override List<Message> PhaseTour(int tour, int phase, List<ReponseServeur> reponsesServeur)
        {
            List<Message> messages = new List<Message>();

            if (phase == 0)
            {
                // Récupérer les informations
            }
            else if (phase == 1)
            {
                // Analyser les informations et faire les actions
            }

            return messages;
        }
    }
}
