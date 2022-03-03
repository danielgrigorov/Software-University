using System;
using System.Collections.Generic;
using System.Text;

namespace P05.FootballTeamGenerator
{
    public class Stats
    {
        private int enduranceSkill;
        private int sprintSkill;
        private int dribbleSkill;
        private int passingSkill;
        private int shootingSkill;

        public Stats(int enduranceSkill, int sprintSkill, int dribbleSkill, int passingSkill, int shootingSkill)
        {
            this.EnduranceSkill = enduranceSkill;
            this.SprintSkill = sprintSkill;
            this.DribbleSkill = dribbleSkill;
            this.PassingSkill = passingSkill;
            this.ShootingSkill = shootingSkill;
        }


        public int EnduranceSkill
        {
            get => this.enduranceSkill;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new InvalidOperationException($"Endurance should be between 0 and 100.");
                }

                this.enduranceSkill = value;
            }
        }

        public int SprintSkill
        {
            get => this.sprintSkill;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new InvalidOperationException($"Sprint should be between 0 and 100.");
                }

                this.sprintSkill = value;
            }
        }

        public int DribbleSkill
        {
            get => this.dribbleSkill;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new InvalidOperationException($"Dribble should be between 0 and 100.");
                }

                this.dribbleSkill = value;
            }
        }

        public int PassingSkill
        {
            get => this.passingSkill;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new InvalidOperationException($"Passing should be between 0 and 100.");
                }
                this.passingSkill = value;
            }
        }

        public int ShootingSkill
        {
            get => this.shootingSkill;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new InvalidOperationException($"Shooting should be between 0 and 100.");
                }

                this.shootingSkill = value;
            }
        }

        public double AverageStats => (this.enduranceSkill + this.sprintSkill + this.passingSkill + this.shootingSkill + this.dribbleSkill)/ 5.00;

    }
}
