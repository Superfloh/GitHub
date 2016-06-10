using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(Random.Range(10f,90f), Random.Range(10f, 90f), Random.Range(10f, 90f)) * Time.deltaTime);
	}
}
