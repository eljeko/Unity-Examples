using UnityEngine;
using System.Collections;

public class CounterInit : MonoBehaviour
{
		// Use this for initialization
		void Start ()
		{
				DontDestroyOnLoad (GameState.Instance );
				GameState gamestate = GameState.Instance; 
				GetComponent<TextMesh> ().text = "Counter: " + gamestate.Counter ();		 
		}
	
}
