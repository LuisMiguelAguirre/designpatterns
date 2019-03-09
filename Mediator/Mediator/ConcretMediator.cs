using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcretMediator: Mediator
    {
        private Friend1 friend1;
        private Friend2 friend2;
        private Boss boss;

        public Boss setBoss
        {
            get { return boss; }
            set { boss = value; }
        }
        

        public Friend setFriend2
        {
            get { return friend2; }
            set { friend2 = (Friend2)value; }
        }
        


        public Friend SetFriend1
        {
            get { return friend1; }
            set { friend1 = (Friend1)value; }
        }
        

        public override void Send(Friend frd, string msg)
        {
            if (frd == friend1) {
                friend2.Notify(msg);
                boss.Notify(friend1.name + " sends message to " + friend2.name);
            }

            if (frd == friend2)
            {
                friend1.Notify(msg);
                boss.Notify(friend2.name + " sends message to " + friend1.name);
            }

            if (frd == boss)
            {
                friend2.Notify(msg);
                friend1.Notify(msg);
            }
        }


    }
}
