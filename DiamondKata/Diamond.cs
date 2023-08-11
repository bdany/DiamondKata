public class Diamond
{
    private readonly char target;
    private readonly char separator;

    public Diamond(char target, char separator = ' ')
    {
        this.target = target;
        this.separator = separator; 
        DiamondLines = BuildDiamond();
    }
    
    public string[] DiamondLines { get; set; }

    public override string ToString()
    {
        return string.Join("\n", DiamondLines);
    }

    private string[] BuildDiamond()
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

        return lines.SkipReverse().ToArray();
    }
}