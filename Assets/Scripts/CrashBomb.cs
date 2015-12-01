using UnityEngine;
using System.Collections;

public class CrashBomb : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (this.gameObject);
	}

	// 他のオブジェクトと衝突した時に呼び出される関数
	void OnCollisionEnter2D(Collision2D coll){
	//	GameObject obj = coll.gameObject;
	//	obj.SendMessage ("Crash");
		Destroy (this.gameObject);
	}

	public void DeleteThis() {
		Destroy (this.gameObject);
	}
}
