public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    public override bool Equals(object? obj)
    {
        if (obj is FacialFeatures other)
        {
            return other.EyeColor == EyeColor && other.PhiltrumWidth == PhiltrumWidth;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return EyeColor.GetHashCode() + PhiltrumWidth.GetHashCode();
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    public override bool Equals(object? obj)
    {
        if (obj is Identity other)
        {
            return other.Email == Email && other.FacialFeatures.Equals(FacialFeatures);
        }
        return false;
    }
    public override int GetHashCode()
    {
        return Email.GetHashCode() + FacialFeatures.GetHashCode();
    }
}

public class Authenticator
{
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
        => faceA.Equals(faceB);


    public bool IsAdmin(Identity identity)
        => identity.Email == "admin@exerc.ism" && identity.FacialFeatures.Equals(new FacialFeatures("green", 0.9m));

    private HashSet<Identity> identities = new();
    public bool Register(Identity identity)
        => identities.Add(identity);

    public bool IsRegistered(Identity identity)
        => identities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB)
        => identityA == identityB;
}
