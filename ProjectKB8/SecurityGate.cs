namespace ProjectKB8;

public static class SecurityGate
{
    public static void CheckHallAccess(object person)
    {
        if (person is IHallAccessible accessible)
        {
            accessible.EnterHall();
        }
        else
        {
            Console.WriteLine($"Access to Hall is prohibited for: {person?.GetType().Name ?? "null"}");
        }
    }

    public static void CheckDevRoomAccess(object person)
    {
        if (person is IDevRoomAccessible accessible)
        {
            accessible.EnterDevRoom();
        }
        else
        {
            Console.WriteLine($"Access to DevRoom is prohibited for: {person?.GetType().Name ?? "null"}");
        }
    }
}