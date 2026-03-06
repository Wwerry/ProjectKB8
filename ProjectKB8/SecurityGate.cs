namespace ProjectKB8;

public class SecurityGate
{
    public static void CheckHallAccess(object person)
    {
        if (person is IManagerAccessible man)
        {
            man.EnterHall();
        }
        else if (person is Client cli)
        {
            cli.EnterHall();
        }
        else
        {
            Console.WriteLine("Доступ запрещен: В холл могут входить только менеджеры и клиенты.");
        }
    }

    public static void CheckDevRoomAccess(object person)
    {
        if (person is IManagerAccessible man)
        {
            man.EnterDevRoom();
        }
        else if (person is IDeveloperAccessible dev)
        {
            dev.EnterDevRoom();
        }
        else
        {
            Console.WriteLine("Доступ запрещен: В комнату разработки могут входить только программисты менеджеры.");
        }
    }
}