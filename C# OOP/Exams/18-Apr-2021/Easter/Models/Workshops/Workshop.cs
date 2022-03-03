using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Models.Workshops
{
    public class Workshop : IWorkshop
    {
        public Workshop()
        {
        }

        public void Color(IEgg egg, IBunny bunny)
        {
            while (bunny.Energy > 0 && bunny.Dyes.Any())
            {

                IDye currentDye = bunny.Dyes.First();

                while (!egg.IsDone() && bunny.Energy > 0 && !currentDye.IsFinished())
                {
                    egg.GetColored();
                    bunny.Work();
                    currentDye.Use();

                }

                if (currentDye.IsFinished())
                {
                    bunny.Dyes.Remove(currentDye);
                }

                if (egg.IsDone())
                {
                    break;
                }

                
            }
        }
    }
}
