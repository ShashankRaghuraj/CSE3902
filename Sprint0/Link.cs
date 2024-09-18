using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0
{
    public class Link : ILink
    {
        ILinkState state;

        void ChangeDirection()
        {
            state.changeDirection();
        }

        void TakeDamage()
        {
            state.takeDamage();
        }

        void UseItem()
        {
            state.useItem();
        }

        void AttackSword()
        {
            state.attackSword();
        }

        void Update()
        {
            state.Update();
        }
    }
}
