using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0
{
    public class DownMovingLinkState
    {
        private Link link;

        public DownMovingLinkState(Link link)
        {
            this.link = link;
        }

        public void GoDirectionLeft()
        {
            this.link = new LeftNonMovingLinkState(link);
        }

        public void GoDirectionRight()
        {
            this.link = new RightNonMovingLinkState(link);
        }

        public void GoDirectionUp()
        {
            this.link = new UpNonMovingLinkState(link);
        }

        public void GoDirectionDown()
        {

        }

        public void Update()
        {
            link.MoveDown();
        }
    }
}
