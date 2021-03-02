using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class reload : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void replay(){
		SceneManager.LoadScene ("jump");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
