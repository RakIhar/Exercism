abstract class Character
{

    protected Character(string characterType)
    {
        //throw new NotImplementedException("Please implement the Character() constructor");
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
        => false;

    public override string ToString()
        => $"Character is a {this.GetType()}";
}

class Warrior : Character
{
    public Warrior() : base("TODO")
    {

    }

    public override int DamagePoints(Character target)
        => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    private bool _isPrepared = false;
    public Wizard() : base("TODO")
    {

    }

    public override int DamagePoints(Character target)
        => _isPrepared ? 12 : 3;
    public override bool Vulnerable()
        => !_isPrepared;
    public void PrepareSpell()
        => _isPrepared = true;
}