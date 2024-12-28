using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvents04
{
    public class CompareProduct : IComparer<Product>
    {
        #region IComparer<Product> Members

        public int Compare(Product x, Product y)
        {
            return x.Name.CompareTo(y.Name);
        }
        #endregion
    }
}
