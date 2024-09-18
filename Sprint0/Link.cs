using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0
{
    // TODO: Do methods inside need to be public?
    public class Link : ILink
    {
        ILinkState state;

        public void ChangeDirection()
        {
            state.changeDirection();
        }

        public void TakeDamage()
        {
            state.takeDamage();
        }

        public void UseItem()
        {
            state.useItem();
        }

        public void AttackSword()
        {
            state.attackSword();
        }

        public void Update()
        {
            state.Update();
        }
    }
}
