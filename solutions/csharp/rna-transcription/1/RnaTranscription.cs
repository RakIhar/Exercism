public static class RnaTranscription
{
    public static string ToRna(string strand)
    => new String(strand.Select(x => x switch { 'G' => 'C', 'C' => 'G', 'T' => 'A', 'A' => 'U', _ => throw new ArgumentException() }).ToArray());
}