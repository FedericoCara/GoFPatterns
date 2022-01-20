using System;

namespace GoFPatterns.Memento {

	public class Game : ICloneable{

		public string Name { get; set; }
		public int Checkpoint { get; set; }

        public object Clone() {
			return new Game {
				Name = this.Name, 
				Checkpoint = this.Checkpoint
			};
        }

		public Game CloneGame() {
			return (Game)Clone();
		}

        public override string ToString() {
			return $"Game [nombre={Name}, checkpoint={Checkpoint}]";
		}

	}
}