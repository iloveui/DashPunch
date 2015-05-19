using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public Vector3 targetVector;

	public float speed=10.0f;
	public bool moveForward;
	public bool moveBackward;

	// Use this for initialization
	void Start () {
	
	}



	// Update is called once per frame
	void Update () {

		if(moveForward){
			//no he llegado al target
			if((targetVector.x-this.transform.localPosition.x)>0.1f){
				Vector3 tempPos=this.transform.localPosition;
				tempPos.x= tempPos.x + speed*Time.deltaTime;
				this.transform.localPosition=tempPos; 

				//SI ME PASE
				if(this.transform.localPosition.x>=targetVector.x){
					Vector3 correctPos=this.transform.localPosition;
					correctPos.x= targetVector.x;
					this.transform.localPosition=correctPos;
					targetVector.x=targetVector.x - 25f;
					moveForward=false;
					moveBackward=true;

				}
			}
		}
		else if(moveBackward){
			//no he llegado al target
			if((this.transform.localPosition.x - targetVector.x)>0.1f){
				Vector3 tempPos=this.transform.localPosition;
				tempPos.x= tempPos.x - speed*Time.deltaTime;
				this.transform.localPosition=tempPos;
				//SI ME PASE
				if(this.transform.localPosition.x<=targetVector.x){
					Vector3 correctPos=this.transform.localPosition;
					correctPos.x= targetVector.x;
					this.transform.localPosition=correctPos;
					moveBackward=false;
				}
			}
		}

	}


	public void OnMoveForward(){
		targetVector=this.transform.localPosition;
		targetVector.x=targetVector.x + 50.0f;
		moveBackward=false;
		moveForward=true;


	}










}