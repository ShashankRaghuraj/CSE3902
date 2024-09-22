using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint0
{
    // TODO: Do methods inside need to be public?
    public class Link : ILink
    {
        ILinkState state;
        private Viewport viewport;
        int x;
        int y;

        public Link()
        {
            
        }

        //public void ChangeDirection()
        //{
        //    state.ChangeDirection();
        //}

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

        public void MoveLeft()
        {
            if (x > 0)
            {
                x = x - 1;
            }
        }

        public void MoveRight()
        {

        }

        public void MoveUp()
        {

        }

        public void MoveDown()
        {

        }
    }
}
