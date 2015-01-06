using UnityEngine;
using System.Collections;

/**
 * 
 * You can get this error at Runtime:
 * 
 * Level 'Level1' (-1) couldn't be loaded because it has not been added to the build settings.
 * To add a level to the build settings use the menu File->Build Settings...
 * UnityEngine.Application:LoadLevel(String)
 * GoToScene:OnMouseDown() (at Assets/Scripts/GoToScene.cs:25)
 * UnityEngine.SendMouseEvents:DoSendMouseEvents(Int32, Int32)
 * 
 * This because you need to add the scene you wanto to load to the build settings, so go to:
 * 
 * File->Build Settings
 * 
 * and add all the scenes you need in your runtime.
 * 
 */
public class GoToScene : MonoBehaviour
{
		private bool loadingScene = false;
		public string sceneToLoad = "";
		
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnMouseDown ()
		{
				if (!loadingScene) {
						loadingScene = true;
						Application.LoadLevel (sceneToLoad);
						
				}
		}
}
