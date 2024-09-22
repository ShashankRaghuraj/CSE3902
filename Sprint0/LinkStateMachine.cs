using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0
{
    public class LinkStateMachine
    {
        private enum LinkDirection { Left, Right, Up, Down };
        private enum LinkItem { NoItem, Item1, Item2, Item3 };
        private enum LinkAttack { NoAttack, SwordAttack };
        private enum LinkDamage { NoDamage, TakingDamage };

        private LinkDirection currentDirection = LinkDirection.Down;
    }
}
