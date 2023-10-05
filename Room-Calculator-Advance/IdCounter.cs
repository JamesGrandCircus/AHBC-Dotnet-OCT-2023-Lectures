
public static class IdCounter
{
	private static int _id = 0;

    internal static int GetNextId()
    {
		return ++_id;
    }
}