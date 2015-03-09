using UnityEngine;
using System.Collections;

public class PianoKey : MonoBehaviour {

	// public float semitone_offset = 0;

	// Use this for initialization
	void Start () {
		GameObject.Find("black_key").GetComponent<Renderer>().material.color = Color.black;
		// GetComponent<Renderer>().material.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		// audio.pitch = Mathf.Pow( 2f, semitone_offset/12.0f );
		GetComponent<AudioSource>().Play ();
		// GetComponent<Rigidbody>().RotateAround (Vector3.zero, Vector3.up, 20 * Time.deltaTime);
		GetComponent<Transform>().rotation = Quaternion.Euler ( -5.0f, 0.0f, 0.0f);
	}

	void OnMouseUp () {
		GetComponent<Transform>().rotation = Quaternion.Euler ( 0.0f, 0.0f, 0.0f);
	}
}