public static class DiamondExtensions
{
    internal static IEnumerable<T> SkipReverse<T>(this IEnumerable<T> ie, int skipStep = 1) => ie.Concat(Enumerable.Reverse(ie).Skip(skipStep));
}
