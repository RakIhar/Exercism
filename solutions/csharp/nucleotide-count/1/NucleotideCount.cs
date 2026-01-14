public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var keyValuePairs = from c in "ACGT"
        select KeyValuePair.Create(c, sequence.Where(x => x == c).Count());
        return sequence.Except("ACGT").Count() == 0 ? keyValuePairs.ToDictionary() : throw new ArgumentException();        
    }
}