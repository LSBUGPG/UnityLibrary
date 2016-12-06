using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class Quoting : MonoBehaviour {

	void Start () {

		using (StreamWriter writer = File.CreateText ("quine.cs")) {

			writer.WriteLine ("using UnityEngine;");
