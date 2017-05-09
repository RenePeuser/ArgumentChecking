using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ArgumentChecking.Validation;

namespace ArgumentChecking
{
    public class LazyArgumentRepository : ArgumentRepository
    {
        readonly Dictionary<Type, Validator> _validatorDictionary = new Dictionary<Type, Validator>();

        public LazyArgumentRepository(Expression<Func<object>>[] expressions) : base(expressions)
        {
        }

        public void Add(Validator validator)
        {
            var type = validator.GetType();
            if (!_validatorDictionary.ContainsKey(type))
            {
                _validatorDictionary.Add(type, validator);
            }
        }

        public IEnumerable<Validator> Validators()
        {
            return _validatorDictionary.Values;
        }
    }

    public class ArgumentRepository
    {
        public ArgumentRepository(Expression<Func<object>>[] expressions)
        {
            Arguments = expressions.Select(item => new Argument(item)).ToArray();
        }

        public Argument[] Arguments { get; }
    }
}