using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
	int StageNumber;
	public Transform RockTr, BlueRockTr, BlockTr;

	// Use this for initialization
	void Start () {
		StageNumber = 1;

		GameMain ();
/*
		Vector3 pos1 = new Vector3 ();
		pos1.x = -96;
		pos1.y = -0;
		Instantiate (RockTr, pos1, transform.rotation);  
*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void GameMain() {
		InitStage ();
	}

	void InitStage() {
		CreateGameFieldWall ();
		CreateGameFieldStage ();
	}

	void CreateGameFieldWall() {
		// 周りの壁(1) 上と下
		Vector3 v = new Vector3 ();
		for (int x = -320; x <= 320; x += 32) {
			v.x = x;
			//v.y = -192;
			//Instantiate (BlockTr, v, transform.rotation);  
			v.y = 192;
			Instantiate (BlockTr, v, transform.rotation);  
		}
		// 周りの壁(2) 左右の端
		for (int y = -192; y <= 160; y += 32) {
			v.x = -320;
			v.y = y;
			Instantiate (BlockTr, v, transform.rotation);  
			v.x = 320;
			Instantiate (BlockTr, v, transform.rotation);  
		}
	}

	void CreateGameFieldStage() {

	}
}
