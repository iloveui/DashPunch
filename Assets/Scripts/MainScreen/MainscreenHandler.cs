using UnityEngine;
using System.Collections;

public class MainscreenHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onPlayGame()
	{
		Debug.Log ("On play");
		Application.LoadLevel ("InGame");
	}
}
