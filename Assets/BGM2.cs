using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM2 : MonoBehaviour {

	public GameObject CubePrefab;

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource> ().volume = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "cubetag" || col.gameObject.tag == "groundtag") {
			GetComponent<AudioSource> ().Play();
		}
	}
}