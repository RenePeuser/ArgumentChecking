using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ArgumentChecking.Validation;

namespace ArgumentChecking
{
    public class LazyArgumentRepository : ArgumentRepository
    {
        private readonly Dictionary<Type, Validator> _validatorDictionary = new Dictionary<Type, Validator>();

        public LazyArgumentRepository(IEnumerable<Expression<Func<object>>> expressions) : base(expressions)
        {
        }

        public void AddValidator(Validator validator)
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
}