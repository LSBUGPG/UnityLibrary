using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class Quoting : MonoBehaviour {

	void Start () {

		using (StreamWriter writer = File.CreateText ("quine.cs")) {

			writer.WriteLine ("using UnityEngine;");
			writer.WriteLine ("using UnityEngine.UI;");
			writer.WriteLine ("using System.Collections;");
			writer.WriteLine ("using System.IO;");
			writer.WriteLine ("");
			writer.WriteLine ("public class Quoting : MonoBehaviour {");
			writer.WriteLine ("");
			writer.WriteLine ("\tvoid Start () {");
			writer.WriteLine ("");
			writer.WriteLine ("\t\tusing (StreamWriter writer = File.CreateText (\"quine.cs\")) {");
			writer.WriteLine ("");
			writer.WriteLine ("\t\t\twriter.WriteLine (\"using UnityEngine;\");");

		}
	}
}
