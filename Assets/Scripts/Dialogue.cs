using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text;
using System.IO;
using UnityEditor;

public class Dialogue : MonoBehaviour {
	public Text title; //The title refers to the character talking. -Tobias Persson
	public Text dialogueText; //This is what they are saying. -Tobias Persson
	public TextAsset asset;//The file that contains the text from which it reads from. -Tobias Persson

	public string[] line;
	string totalText;

	int level = 0;
	bool hasStopped = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		StreamReader reader = new StreamReader (AssetDatabase.GetAssetPath(asset), Encoding.Default); //Loads the file into a streamreader. -Tobias Persson
		totalText = reader.ReadToEnd (); //Reads the whole file and saves it into string. -Tobias Persson
		line = totalText.Split(','); //Splits the string into lines and saves it to an array. -Tobias Persson

		if (level < line.Length) { //Will go through each line and act depending on what it contains. -Tobias Persson
			if (line [level].Contains ("<title>")) { //if the line contains "<title>" it will change the displayed title to the current character talking. -Tobias Persson
				title.text = line[level].Substring (7);
			}
			if (line[level].Contains ("<body>")) { //if the line contains "<body>" it will change the displayed text to what is currently being said. -Tobias Persson
				dialogueText.text = line [level].Substring(6);
			}
			if (hasStopped == false) { //if it hasn't stopped then it will move onto the next line. -Tobias Persson
				level++;
			}
			if (line[level].Contains ("<stop>") == true) { //Stops if the line contains "<stop>". -Tobias Persson
				hasStopped = true;
			}
		}
		if (Input.GetButtonDown("Fire1")) { //Pressing the left mouse button will make the script move onto next character talking in the text file. -Tobias Persson
			hasStopped = false;
		}

	}
}

/* Example of how to write a dialogue file.
 * <title>Character A,<body>Character A's text and dialogue.,<stop>,<title>Character B,<body>Character B's text and dialogue.,<stop>
 * 
 *Notes:
 *Keep everything on one line.
 *Don't mispell the tags (<title><body><stop>)
 *Use commas as a seperator.
 *Don't use unnecessary spaces.
 */