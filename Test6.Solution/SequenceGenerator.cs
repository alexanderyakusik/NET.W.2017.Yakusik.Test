using System;
using System.Collections.Generic;
using System.Linq;

namespace Test6.Solution
{
    public static class SequenceGenerator
    {
        public static IEnumerable<T> FunctionSequence<T>(
            T firstElement, 
            T secondElement, 
            Func<T, T, T> function, 
            int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(amount)} cannot be less than one.");
            }

            if (function == null)
            {
                throw new ArgumentNullException($"{nameof(function)} cannot be null.");
            }

            return FunctionSequenceCore<T>(firstElement, secondElement, function, amount);
        }

        private static IEnumerable<T> FunctionSequenceCore<T>(
            T firstElement, 
            T secondElement, 
            Func<T, T, T> function,
            int amount)
        {
            T prePrevious = firstElement;
            T previous = secondElement;

            yield return firstElement;

            if (amount > 1)
            {
                yield return secondElement;
            }

            for (long i = 2; i < amount; i++)
            {
                T current = function(previous, prePrevious);

                yield return current;

                prePrevious = previous;
                previous = current;
            }
        }
    }
}
