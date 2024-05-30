using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Aircraft
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }
        private CommandCentre _commandCentre;

        public Aircraft(string name, CommandCentre commandCentre)
        {
            this.Name = name;
            this._commandCentre = commandCentre;
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {this.Name} is landing.");
            _commandCentre.RequestLanding(this);
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {this.Name} is taking off.");
            _commandCentre.RequestTakeOff(this);
        }
    }

    class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public Aircraft IsBusyWithAircraft { get; set; } = null;

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} is free!");
        }
    }

    class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways)
        {
            this._runways.AddRange(runways);
        }

        public void RegisterAircraft(Aircraft aircraft)
        {
            _aircrafts.Add(aircraft);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (runway.IsBusyWithAircraft == null)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
                    runway.IsBusyWithAircraft = aircraft;
                    runway.HighLightRed();
                    return;
                }
            }
            Console.WriteLine("Could not land, all runways are busy.");
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (runway.IsBusyWithAircraft == aircraft)
                {
                    runway.IsBusyWithAircraft = null;
                    runway.HighLightGreen();
                    Console.WriteLine($"Aircraft {aircraft.Name} has took off.");
                    return;
                }
            }
            Console.WriteLine("Aircraft is not on any runway.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Runway[] runways = { new Runway(), new Runway() };
            CommandCentre commandCentre = new CommandCentre(runways);

            Aircraft aircraft1 = new Aircraft("Aircraft 1", commandCentre);
            Aircraft aircraft2 = new Aircraft("Aircraft 2", commandCentre);

            commandCentre.RegisterAircraft(aircraft1);
            commandCentre.RegisterAircraft(aircraft2);

            aircraft1.Land();
            aircraft2.Land();
            aircraft1.TakeOff();
            aircraft2.Land();
        }
    }

}
