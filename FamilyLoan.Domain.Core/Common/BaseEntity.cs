using System;

namespace FamilyLoan.Domain.Core.Common
{
    public abstract  class BaseEntity
    {
        public DateTime CreatededDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public bool IsDirty { get; set; }
    }
}
