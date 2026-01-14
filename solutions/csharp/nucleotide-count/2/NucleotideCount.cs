public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
        => sequence.Except("ACGT").Count() == 0 ? "ACGT".Select(c => KeyValuePair.Create(c, sequence.Where(x => x == c).Count())).ToDictionary() : throw new ArgumentException();     
}