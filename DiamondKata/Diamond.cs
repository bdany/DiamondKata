public class Diamond
{
    private string[] _diamondLines;
    
    public Diamond(char target, char separator = ' ')
    {
        if (!char.IsLetter(target) || !char.IsUpper(target))
        {
            throw new ArgumentException("Input must be an uppercase letter [A - Z].", "target");
        }
        
        _diamondLines = BuildDiamond(target, separator);
    }

    public string[] DiamondLines
    {
        get {

            return _diamondLines;
        }
    }

    public override string ToString()
    {
        return string.Join("\n", _diamondLines);
    }

    private string[] BuildDiamond(char target, char separator)
    {
        int width = target - 'A';
        var lines = Enumerable.Range(0, width + 1).Select(i => {
            char letter = (char)('A' + i);

            string leftHalf = new string(separator, width - i) + letter + new string(separator, i);
            return string.Concat(leftHalf.SkipReverse());
        });

        return lines.SkipReverse().ToArray();
    }
}