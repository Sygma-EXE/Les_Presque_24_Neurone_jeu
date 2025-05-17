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
        private int equipe;
        public override int Equipe
        {
            get => equipe;
            set => equipe = value;
        }

        public override string NomIA => "24 NEURONES";
        public override List<Message> PhaseTour(int tour, int phase, List<ReponseServeur> reponsesServeur)
        {
            List<Message> messages = new List<Message>();

            if (phase == 0)
            {
                // Récupérer les informations
                messages.Add(new Message("PIOCHES"));
            }
            else if (phase == 1)
            {
                // Analyser les informations et faire les actions
                messages.Add(new Message("PIOCHER", ["0"]));
            }

            return messages;
        }
    }
}
