using GoFPatterns.Shared;
using System;

namespace GoFPatterns.Memento {

	public class MementoDemo : IGoFPatternDemo {

		private Caretaker caretaker;
		private Originator originator;

		public MementoDemo(){
			caretaker = new Caretaker();
			originator = new Originator();
		}

		public void Run() {
			string gameName = "Crash Bandicoot";

			Game game = new Game();
			game.Name = gameName;
			game.Checkpoint = 1;

			game.Name = gameName;
			game.Checkpoint = 2;
			originator.State = game;

			game.Name = gameName;
			game.Checkpoint = 3;
			originator.State = game;

			caretaker.AddMemento(originator.Save()); // ESTADO POSICION 0

			game.Name = gameName;
			game.Checkpoint = 4;

			originator.State = game;
			caretaker.AddMemento(originator.Save()); // ESTADO POSICION 1

			game.Name = gameName;
			game.Checkpoint = 5;
			originator.State = game;
			caretaker.AddMemento(originator.Save()); // ESTADO POSICION 2


			game.Name = gameName;
			game.Checkpoint = 6;
			originator.State = game;
			Console.WriteLine($"Reaching checkpoint: {game.Checkpoint}");

			originator.State = game;
			Console.WriteLine("About to load second memento saved");
			originator.Load(caretaker.GetMemento(1));

			game = originator.State;
			Console.WriteLine($"Final state after loading: {game}");
		}
    }
}