public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
        => (firstStrand.Length != secondStrand.Length) ? throw new System.ArgumentException() : firstStrand.Zip(secondStrand).Where(x => x.First != x.Second).Count();
    
}