using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLegacy.BSL
{
    public class UnknownDiscountMethodException : Exception
    {
        public UnknownDiscountMethodException()
        {

        }

        public UnknownDiscountMethodException(string message) : base(message)
        {

        }

        public UnknownDiscountMethodException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
