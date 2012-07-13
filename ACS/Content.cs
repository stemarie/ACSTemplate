using System.Collections.Generic;

namespace ACS
{
    public class Content : Secureable, ISecured
    {

        public Content()
        {
            Rights = new List<IRight>();
        }

        public IList<IRight> Rights { get; private set; }
    }
}
