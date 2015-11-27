using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour {
	int counter;

	// Use this for initialization
	void Start () {
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (counter > 30) {
			Vector3 v = transform.position;
			//v.x = ((int)Mathf.Round(v.x / 16)) * 16;
			//v.y = ((int)Mathf.Round(v.y / 16)) * 16;
			v.x = ((int)Mathf.Round (v.x / 4)) * 4;
			v.y = ((int)Mathf.Round (v.y / 4)) * 4;
			transform.position = v;

			counter = 0;
		}
		++counter;
	}

	public void Crash() {
		Destroy (this.gameObject);
	}

	/*
	// 他のオブジェクトと衝突した時に呼び出される関数
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.name == "CrashBomb") { // ぶつかった相手がCrashBombなら
			Destroy (this.gameObject);  // 自分自身を消滅させる
		}
	}
	*/
}
