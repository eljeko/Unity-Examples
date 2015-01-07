using UnityEngine;
using System.Collections;

public class HttpClient : MonoBehaviour
{
	public string url = "http://eljeko.github.io/Unity-Examples/hello.txt";

		void OnMouseDown ()
		{
				TextMesh label = null;

				foreach (GameObject counterLabel  in GameObject.FindGameObjectsWithTag("CounterLabel")) {
						label = counterLabel.GetComponent<TextMesh> ();
			 
				}

				label.text = ".";

				//API link: http://docs.unity3d.com/ScriptReference/WWW.html		 		

				WWW www = new WWW (url);

				while (!www.isDone) {					
						label.text = label.text + ".";		
				}
				foreach (GameObject counterLabel  in GameObject.FindGameObjectsWithTag("CounterLabel")) {
						counterLabel.GetComponent<TextMesh> ().text = "TEXT: " + www.text;
			Debug.Log( www.text);
				}
		}
    
}
