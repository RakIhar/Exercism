public static class Triangle
{
    public static bool IsTriangle(double a, double b, double c)
    {
        bool isCorrect = true;
        if (a == 0 || b == 0 || c == 0) isCorrect = false;
        if (!(a + b >= c)) isCorrect = false;
        if (!(a + c >= b)) isCorrect = false;
        if (!(b + c >= a)) isCorrect = false;
        return isCorrect;
    }
    public static bool IsScalene(double side1, double side2, double side3)    
        => IsTriangle(side1, side2, side3) ? !IsIsosceles(side1, side2, side3) : false;   
    
    
    public static bool IsIsosceles(double side1, double side2, double side3) 
        => IsTriangle(side1, side2, side3) ? ( side1 == side2) || (side1 == side3) || (side2 == side3) : false; 
    
    
    public static bool IsEquilateral(double side1, double side2, double side3) 
        => IsTriangle(side1, side2, side3) ? (side1 == side2) && (side1 == side3) : false;
    
}