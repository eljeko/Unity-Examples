using UnityEngine;
using System.Collections;

//we decleare the GameState as MonoBehaviour
public class GameState : MonoBehaviour
{

		// the instance is declared as private static to maintain the object state.
		private static GameState instance;
		private static int counter;

		/**
		 * this is the singleton pattern main method
		 * Wiki: http://en.wikipedia.org/wiki/Singleton_pattern
		 * MSDN: http://msdn.microsoft.com/en-us/library/ff650316.aspx
		 **/

		public static GameState Instance {
				get {
						if (instance == null) {
								//if instance is null we create a new GameObject and we add it to the loaded Scene.
								instance = new GameObject ("gamestate").AddComponent<GameState> ();
								instance.startState ();			
						} 
						
						return instance;
				
				} 
		}

		// On application quit sets the instance to null
		public void OnApplicationQuit ()
		{
				instance = null;
		}

		public void Increase ()
		{
				counter++;
		}

		public int Counter ()
		{
				return counter;
		}

		private void startState ()
		{
				print ("Creating a new state");
		}
}

