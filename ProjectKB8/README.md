# ProjectKB8 — Система разграничения доступа на интерфейсах

Простая демонстрация принципов ООП и безопасного доступа с использованием интерфейсов и единой точки проверки (`SecurityGate`).  
Учебный проект для отработки интерфейсов и принципов ООП.

## UML-диаграмма классов
![class diagram](/images/img.png)

## Основные возможности

- Три роли: `Client`, `Developer`, `Manager`
- Разные уровни доступа:
    - Холл → только клиенты и менеджеры
    - Комната разработки → только разработчики и менеджеры
- Проверка доступа через интерфейсы (`IHallAccessible`, `IDevRoomAccessible`)
- Централизованная логика в классе `SecurityGate`

## Демонстрация работы

```csharp
Developer dev = new Developer("Сильный", "C#", 21, "Steve", 90000);
Manager manager = new Manager(10, "AI проект", 24, "Alex", 150000);
Client client = new Client("Jon", "Т-банк");

SecurityGate.CheckDevRoomAccess(dev);     // → Developer Steve entered the dev room.
SecurityGate.CheckHallAccess(dev);        // → Access to Hall is prohibited for: Developer

SecurityGate.CheckDevRoomAccess(manager); // → Manager Alex entered the dev room.
SecurityGate.CheckHallAccess(manager);    // → Manager Alex entered the hall.

SecurityGate.CheckDevRoomAccess(client);  // → Access to DevRoom is prohibited for: Client
SecurityGate.CheckHallAccess(client);     // → Client Jon entered the hall.
```

## Установка и запуск
### Требования
* .NET 7.0 / 8.0 / 9.00 / 10.0
```bash
  git clone https://github.com/Wwerry/ProjectKB8.git
  cd ProjectKB8
  dotnet restore
  dotnet build
  dotnet run
```

## Технологии
* C#
* .NET (7.0+)
* Объектно-ориентированное программирование
* Интерфейсы

## Авторы
* Wwerry
* BogdanSmile
* Другие участники курса