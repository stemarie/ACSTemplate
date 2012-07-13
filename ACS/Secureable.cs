using System;
using System.Collections.Generic;

namespace ACS
{
    public abstract class Secureable : ISecureable
    {
        protected Secureable()
        {
            Id = Guid.NewGuid().ToString();
            Parent = null;
            Children = new List<ISecureable>();
        }

        public IList<ISecureable> Children { get; private set; }

        public ISecureable Parent { get; set; }

        public string Id { get; private set; }
    }
}