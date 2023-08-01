using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaSharp
{
    public class Rule<T> : IRule<T>
    {
        private Func<T, bool> _rule;
        public string ErrorMessage { get; }

        public Rule(Func<T, bool> rule, string errorMessage)
        {
            _rule = rule;
            ErrorMessage = errorMessage;
        }

        public bool IsValid(T entity) => _rule(entity);
    }
}
