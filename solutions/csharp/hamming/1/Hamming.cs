public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int res = 0;
        if (firstStrand.Length != secondStrand.Length) 
            throw new System.ArgumentException();
        return firstStrand.Where((n, i) => n != secondStrand[i]).Count();
    }
}