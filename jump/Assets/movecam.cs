using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecam : MonoBehaviour {
	public float speed;
	Vector3 vec;
	// Use this for initialization
	void Start () {
		vec = new Vector3 (-0.57f, 1.284f, -10.179f);
	}
	public void getcam(Vector3 pos3){
		vec = new Vector3 (pos3.x - 0.554f, pos3.y + 1.2f, pos3.z - 1f);
	}

	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		this.gameObject.transform.position = Vector3.MoveTowards (this.gameObject.transform.position, vec, step);
	}
}
