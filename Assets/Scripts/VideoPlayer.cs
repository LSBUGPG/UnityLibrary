using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(AudioSource))]
public class VideoPlayer : MonoBehaviour {

	public MovieTexture videoFile; //The file that will be shown. -Tobias Persson
	AudioSource audioFile; //The audio file that will be played. -Tobias Persson
	// Use this for initialization
	void Start () {
		GetComponent<RawImage> ().texture = videoFile as MovieTexture; //Sets the video file as a texture of the raw image object. -Tobias Persson
		audioFile = gameObject.GetComponent<AudioSource> ();
		audioFile.clip = videoFile.audioClip; //Sets the audio from the video into the audio source. -Tobias Persson
		videoFile.Play (); //Starts the video and sound. -Tobias Persson
		audioFile.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) { //Pressing space will pause/resume the video and audio. -Tobias Persson.
			if (videoFile.isPlaying) {
				videoFile.Pause ();
			} else {
				videoFile.Play ();
			}
		}
	}
}
