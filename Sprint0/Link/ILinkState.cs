using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0
{
    public interface ILinkState
    {
        void changeDirection();

        void attackSword();

        void takeDamage();

        void useItem();

        void Update();
    }
}
