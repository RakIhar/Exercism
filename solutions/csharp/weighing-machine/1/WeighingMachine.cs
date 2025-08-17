class WeighingMachine
{
    public WeighingMachine(int precision) => Precision = precision;
    public int Precision { get; set; }

    private double weight;
    public double Weight {
                             get {return weight;} 
                             set
                             {
                                 if (value < 0)
                                 {
                                     throw new ArgumentOutOfRangeException();
                                 }
                                 else
                                 {
                                     weight = value;
                                 }
                                 
                             }
                        }
    public string DisplayWeight
    {
        get
        {
            var num = String.Format("{0:F" + Precision + "}", Weight - TareAdjustment);
            return $"{num} kg";
        }
    }
    public double TareAdjustment {set; private get;} = 5;
}
