using System.Collections.Generic;

namespace ACS
{
    public interface IRightable
    {
        IList<IRight> Rights
        {
            get;
        }
    }
}
