namespace ProjectKB8;

public static class SecurityGate
{
    public static void EnterHall(object person, Department dept)
    {
        if (person is IHallAccessible accessible)
        {
            if (dept.HumansInHall.Contains(accessible)) return;

            if (person is IDevRoomAccessible p && dept.HumansInDevRoom.Remove(p))
            {
                Console.WriteLine($"- {GetNameEntrant(p)} moved from DevRoom to Hall");
            }

            accessible.EnterHall();
            dept.HumansInHall.Add(accessible);
        }
        else
        {
            Console.WriteLine($"Access to Hall is prohibited for: {GetNameEntrant(person)}");
        }
    }

    public static void EnterDevRoom(object person, Department dept)
    {
        if (person is IDevRoomAccessible accessible)
        {
            if (dept.HumansInDevRoom.Contains(accessible)) return;

            if (person is IHallAccessible p && dept.HumansInHall.Remove(p))
            {
                Console.WriteLine($"- {GetNameEntrant(p)} moved from Hall to DevRoom");
            }

            accessible.EnterDevRoom();
            dept.HumansInDevRoom.Add(accessible);
        }
        else
        {
            Console.WriteLine($"Access to DevRoom is prohibited for: {GetNameEntrant(person)}");
        }
    }

    public static string GetNameEntrant(object person)
    {
        bool flag = false;
        string name = person?.GetType().Name;
        if (person is IHallAccessible hallPerson && flag == false)
        {
            name += " " + hallPerson.Name;
            flag = true;
        }

        if (person is IDevRoomAccessible devRoomPerson && flag == false)
        {
            name += " " + devRoomPerson.Name;
        }
        
        return name;
    }
}
