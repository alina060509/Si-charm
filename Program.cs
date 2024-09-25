// See https://aka.ms/new-console-template for more information
using System;

public interface IPart
{
    string GetStatus(); 
    void Build(); 
}

public interface IWorker
{
    void Work();
}
public class Basement : IPart
{
    private bool Built;

    public string GetStatus(){
        if( Built)
        {
            return "Фундамент построен";
        }
        else
        {
            return "Фундамент не построен";
        }

    } 

    public void Build()
    {
        Built = true;
        Console.WriteLine("Фундамент построен.");
    }
}

public class Wall : IPart
{
    private bool Built;

    public string GetStatus()
    {
        if (Built)
        {
            return "Стена построен";
        }
        else
        {
            return "Стена не построен";
        }

    }

    public void Build()
    {
        Built = true;
        Console.WriteLine("Стена построена.");
    }
}

public class Door : IPart
{
    private bool Built;

    public string GetStatus()
    {
        if (Built)
        {
            return "дверь установлена";
        }
        else
        {
            return "дверь не установлена";
        }

    }

    public void Build()
    {
        Built = true;
        Console.WriteLine("Дверь установлена.");
    }
}

public class Window : IPart
{
    private bool Built;

    public string GetStatus()
    {
        if (Built)
        {
            return "окно установлено";
        }
        else
        {
            return "окно не установлено";
        }

    }

    public void Build()
    {
        Built = true;
        Console.WriteLine("Окно установлено.");
    }
}

public class Roof : IPart
{
    private bool Built;

    public string GetStatus()
    {
        if (Built)
        {
            return "крыша установлена";
        }
        else
        {
            return "крыша не установлена";
        }

    }

    public void Build()
    {
        Built = true;
        Console.WriteLine("Крыша установлена.");
    }
}
public class House
{
    public Basement Basement { get; set; } = new Basement();
    public List<Wall> Walls { get; set; } = new List<Wall>();
    public Door Door { get; set; } = new Door();
    public List<Window> Windows { get; set; } = new List<Window>();
    public Roof Roof { get; set; } = new Roof();

    public House()
    {
        for (int i = 0; i < 4; i++)
        {
            Walls.Add(new Wall());
        }

        for (int i = 0; i < 4; i++)
        {
            Windows.Add(new Window());
        }
    }

    public void ShowHouse()
    {
        Console.WriteLine("  _____");
        Console.WriteLine(" /|   |\\");
        Console.WriteLine("/_|___|_\\");
        Console.WriteLine("|  ___  |  ");
        Console.WriteLine("|_|___|_|");
    }
}
public class Worker : IWorker
{
    private IPart _partTBuild;

    public Worker(IPart partToBuild)
    {
        _partTBuild = partToBuild;
    }

    public void Work()
    {
        Console.WriteLine(_partTBuild.GetStatus());
        _partTBuild.Build();
    }

    public class Team : IWorker
    {
        private List<Worker> _workers;

        public Team(List<Worker> workers)
        {
            _workers = workers;
        }

        public void Work()
        {
            foreach (var worker in _workers)
            {
                worker.Work();
            }
        }
    }

    public class TeamLeader
    {
        public void Report(House house)
        {
            Console.WriteLine("Отчет о строит:");
            Console.WriteLine(house.Basement.GetStatus());
            foreach (var wall in house.Walls)
            {
                Console.WriteLine(wall.GetStatus());
            }
            Console.WriteLine(house.Door.GetStatus());
            foreach (var window in house.Windows)
            {
                Console.WriteLine(window.GetStatus());
            }
            Console.WriteLine(house.Roof.GetStatus());
            Console.WriteLine("Строительство завершено!");
            house.ShowHouse();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();

            TeamLeader leader = new TeamLeader();
            List<Worker> workers = new List<Worker>
        {
            new Worker(house.Basement),
            new Worker(house.Walls[0]),
            new Worker(house.Walls[1]),
            new Worker(house.Walls[2]),
            new Worker(house.Walls[3]),
            new Worker(house.Door),
            new Worker(house.Windows[0]),
            new Worker(house.Windows[1]),
            new Worker(house.Windows[2]),
            new Worker(house.Windows[3]),
            new Worker(house.Roof)
        };

            Team team = new Team(workers);

            team.Work();
            leader.Report(house);
        }
    }
}

