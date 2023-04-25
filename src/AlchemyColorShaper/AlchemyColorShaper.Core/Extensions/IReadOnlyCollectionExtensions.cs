using System.Collections.Generic;
using System.Linq;

namespace AlchemyColorShaper.Core.Extensions;

internal static class IReadOnlyCollectionExtensions
{
    public static IReadOnlyCollection<T> Reverse<T>(this IReadOnlyCollection<T> collection)
    {
        return collection.AsEnumerable().Reverse().ToList().AsReadOnly();
    }
}
