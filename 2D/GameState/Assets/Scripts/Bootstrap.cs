 
using UnityEngine; 
using System.Collections;

/**
 * This script boots the gamestate instance. 
 */ 
public class Bootstrap : MonoBehaviour
{	    
		void Start ()
		{
				Debug.Log ("Scene Started");	
				DontDestroyOnLoad (GameState.Instance);
				GameState gamestate = GameState.Instance;
		}
}