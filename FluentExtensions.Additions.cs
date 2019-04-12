using System.Linq.Expressions;

namespace Mono.Linq.Expressions
{
    public static partial class FluentExtensions
    {
        public static BinaryExpression ArrayIndex(this Expression array, int index)
        {
            return Expression.ArrayIndex(array, index.Constant());
        }
    }
}