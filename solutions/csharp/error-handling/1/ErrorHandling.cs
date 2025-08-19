public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
        => throw new Exception();
    

    public static int? HandleErrorByReturningNullableType(string input)
        => Int32.TryParse(input, out int res) ? res : null;
    

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        int? res = HandleErrorByReturningNullableType(input);
        if (res != null)
        {
            result = res.Value;
            return true;
        }
        result = -1;
        return false;
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        try
        {
            throw new Exception();
        }
        finally
        {
            disposableObject.Dispose();
        }
    }
}
