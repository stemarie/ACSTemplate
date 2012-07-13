using System.Collections.Generic;

namespace ACS
{
    public interface ISecureable : IIdentifiable
    {

        IList<ISecureable> Children
        {
            get;
        }

        ISecureable Parent
        {
            get;
            set;
        }
    }
}
