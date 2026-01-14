public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
        => strand
        .Chunk(3)
        .Select(x => x switch
        {
            ['A', 'U', 'G'] => "Methionine",
            ['U', 'U', 'U'] or ['U', 'U', 'C'] => "Phenylalanine",
            ['U', 'U', 'A'] or ['U', 'U', 'G'] => "Leucine",
            ['U', 'C', 'U'] or ['U', 'C', 'C'] or ['U', 'C', 'A'] or ['U', 'C', 'G'] => "Serine",
            ['U', 'A', 'U'] or ['U', 'A', 'C'] => "Tyrosine",
            ['U', 'G', 'U'] or ['U', 'G', 'C'] => "Cysteine",
            ['U', 'G', 'G'] => "Tryptophan",
            ['U', 'A', 'A'] or ['U', 'A', 'G'] or ['U', 'G', 'A'] => "STOP",
            _ => throw new ArgumentException()
        })
        .TakeWhile(str => str != "STOP")
        .ToArray();
}