public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private Allergen _mask;
    public Allergies(int mask)
        => _mask = (Allergen)mask;// > 257 ? throw new ArgumentException() : (Allergen)mask;


    public bool IsAllergicTo(Allergen allergen)
        => _mask.HasFlag(allergen);

    public Allergen[] List()
        => Enum.GetValues(typeof(Allergen)).OfType<Allergen>().Where(x => _mask.HasFlag(x)).ToArray();

}