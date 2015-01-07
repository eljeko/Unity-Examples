using UnityEngine;
using System.Collections;

public class IncreaseCounter : MonoBehaviour
{

		void OnMouseDown ()
		{
				DontDestroyOnLoad (GameState.Instance);
				GameState gamestate = GameState.Instance; 
				gamestate.Increase ();
				// we tagged out Label GameObject as "CounterLabel" to easily retrive it
				foreach (GameObject counterLabel  in GameObject.FindGameObjectsWithTag("CounterLabel")) {
						counterLabel.GetComponent<TextMesh> ().text = "Counter: " + gamestate.Counter ();
				}
		}
    
}
