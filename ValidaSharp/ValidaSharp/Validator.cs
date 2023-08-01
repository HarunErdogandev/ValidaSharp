using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ValidaSharp
{
    public class Validator<T>
    {
        private List<IRule<T>> _rules;

        public Validator()
        {
            _rules = new List<IRule<T>>();
        }

        public Validator<T> AddRule(Expression<Func<T, bool>> rule, string errorMessage)
        {
            _rules.Add(new Rule<T>(rule.Compile(), errorMessage));
            return this;
        }

        public void ValidateAndThrow(T entity)
        {
            var errors = new List<string>();

            foreach (var rule in _rules)
            {
                if (!rule.IsValid(entity))
                {
                    errors.Add(rule.ErrorMessage);
                }
            }

            if (errors.Count > 0)
            {
                throw new ValidationException(errors);
            }
        }
    }
}
