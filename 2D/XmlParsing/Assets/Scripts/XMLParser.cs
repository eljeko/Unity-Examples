using UnityEngine;
using System.Xml;
using System;
using System.Collections;
using System.Collections.Generic;

public class XMLParser : MonoBehaviour
{

		void OnMouseDown ()
		{
				string xmldata = System.IO.File.ReadAllText (Application.streamingAssetsPath + "/xml/demo.xml");
		
				//Debug.Log ("Loaded following XML " + xmldata);
		
				//Create a new XML document out of the loaded data
				XmlDocument xmlDoc = new XmlDocument ();
				xmlDoc.LoadXml (xmldata);

				string books = ParseBooks (xmlDoc.SelectNodes ("//book"));


				TextMesh label = null;

				foreach (GameObject counterLabel  in GameObject.FindGameObjectsWithTag("CounterLabel")) {
						label = counterLabel.GetComponent<TextMesh> ();
			
				}
		
				label.text = books;
        
	 
		}

		private string ParseBooks (XmlNodeList nodes)
		{
				string result = "";
		
				foreach (XmlNode node in nodes) {
						 
						var title = node.SelectSingleNode ("title");
						result += " Title: [" + title.InnerText+"]";
						result += " Category: [" + (node.Attributes.GetNamedItem ("category").InnerText)+"]";						 
						result += "\n";
				}
				return result;
		}
}
        