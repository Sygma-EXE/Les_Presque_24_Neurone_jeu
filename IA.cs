using Interface_communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lejeu
{
    internal class IA : IntelligenceArtificielle
    {
        public IA() : base() { }
        public override List<Message> PhaseTour(int tour, int phase, List<ReponseServeur> reponsesServeur)
        {
            List<Message> res = new List<Message>();
            Random action = new Random();
            Random cible = new Random();
            if (phase % 4 == 3 || action.NextDouble() < 0.5) 
            {
                
            }
            
        private int equipe;
        public override int Equipe
        {
            get => equipe;
            set => equipe = value;
        }

        public override string NomIA => "24 NEURONES";

        }
    }
}
