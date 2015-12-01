using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
	int StageNumber;
	public Transform RockTr;

	// Use this for initialization
	void Start () {
		StageNumber = 1;

		Vector3 pos1 = new Vector3 ();
		pos1.x = -96;
		pos1.y = -0;
		Instantiate (RockTr, pos1, transform.rotation);  
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
