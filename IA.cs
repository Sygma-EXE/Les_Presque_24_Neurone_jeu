using Interface_communication;
using Lejeu.IA_taperdefense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAPresque24h
{
    public class IA : IntelligenceArtificielle
    {

        ActionIAtaperDefense strategie = new ActionIAtaperDefense();

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
                messages.Add(new Message("MONSTRES"));
                messages.Add(new Message("PIOCHES"));
                messages.Add(new Message("PIOCHER", ["1"]));
            }
            else 
            {
                strategie.AITaperDefenseBanzai(tour, messages);
            }

            return messages;
        }
    }
}
