//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Sprint0
//{
//    public class DownNonMovingLinkState : ILinkState
//    {
//        private Link link;

//        public DownNonMovingLinkState(Link link)
//        {
//            this.link = link;
//        }

//        public void GoDirectionLeft()
//        {
//            this.link = new LeftNonMovingLinkState(link);
//        }

//        public void GoDirectionRight()
//        {
//            this.link = new RightNonMovingLinkState(link);
//        }

//        public void GoDirectionUp()
//        {
//            this.link = new UpNonMovingLinkState(link);
//        }

//        public void GoDirectionDown()
//        {
//            this.link = new DownMovingLinkState(link);
//        }
//    }
//}
