using System.Collections.Generic;

namespace ACS
{
    public class User : Secureable, IAccess
    {
        public User()
        {
            Rights = new List<IRight>();
        }

        public IList<IRight> Rights { get; private set; }
    }
}
