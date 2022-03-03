using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    public class FirePotion : Item
    {
        private const int initialWeight = 5;
        private const int characterHealthDecreasePoints = 20;

        public FirePotion() : base(initialWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            if (character.IsAlive)
            {
                character.Health -= characterHealthDecreasePoints;

                if (character.Health <= 0)
                {
                    character.Health = 0;
                    character.IsAlive = false;
                }
            }
        }
    }
}
