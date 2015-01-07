using UnityEngine;
using System.Collections;

public class CounterInit : MonoBehaviour
{
		/**
		 * Used this for initialization: 
		 * when the counter was used in a previous scene we need to show the current counter value.
		 **/
		void Start ()
		{
				DontDestroyOnLoad (GameState.Instance );
				GameState gamestate = GameState.Instance; 
				GetComponent<TextMesh> ().text = "Counter: " + gamestate.Counter ();		 
		}
	
}
