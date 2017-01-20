//Change Time Speed in the inspector to (100) to see it working

using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour
{
	public float timeSpeed;

	float amplitude = 0.25f;
	float index;

	void Update()
	{
		index += Time.deltaTime / 100;

		var camera = GetComponent<Camera>();
		var colorAmount = Mathf.Abs(amplitude * Mathf.Sin(index * timeSpeed));
		var targetColor = new Color(colorAmount, colorAmount, colorAmount, 1);

		camera.backgroundColor = targetColor;
	}
}