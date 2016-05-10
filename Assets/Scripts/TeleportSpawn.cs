using UnityEngine;
using System.Collections;

public class TeleportSpawn : MonoBehaviour {
	public int code;
	float disableTimer=0;

	void Update(){
		if (disableTimer > 0)
						disableTimer -= Time.deltaTime;
	}

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "FPSController" && disableTimer<=0) {

			foreach(TeleportSpawn tp in FindObjectsOfType<TeleportSpawn>()){	

				if(tp.code==code && tp !=this){
					tp.disableTimer=10;
					Vector3 position=tp.gameObject.transform.position;
					position.y+=2;
					collider.gameObject.transform.position=position;
				
				}


			}


				}
	}

}
