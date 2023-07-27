public class Diamond
{
    public static string BuildDiamond(char target)
    {
        return BuildDiamond(target, ' ');
    }

    public static string BuildDiamond(char target, char separator)
    {
        if (!char.IsLetter(target) || !char.IsUpper(target))
        {
            throw new ArgumentException("Input must be an uppercase letter [A - Z].");
        }

        int width = target - 'A';
        var lines = Enumerable.Range(0, width + 1).Select(i => {
            char letter = (char)('A' + i);

            string leftHalf = new string(separator, width - i) + letter + new string(separator, i);
            return string.Concat(leftHalf.SkipReverse());
        });
        return string.Join("\n", lines.SkipReverse());
    }
}