using UnityEngine;
using System.Collections;

public class PronamaChan : MonoBehaviour {
	int step; // 0:STOP  1-19:WALK
	int direct; // 0:R 1:D 2:L 3:U
	float[] dX = { 1, 0, -1, 0 };
	float[] dY = { 0, -1, 0, 1 };
	public Sprite[] stopRDLU;
	public Sprite[] walkR;
	public Sprite[] walkD;
	public Sprite[] walkL;
	public Sprite[] walkU;
	public Sprite[] Rock;

	// Use this for initialization
	void Start () {
		step = 0;     // 0:停止  !0:移動中
		direct = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (step == 0) { // STOP
			GetComponent<SpriteRenderer> ().sprite = stopRDLU [direct];

			if (Input.GetKey (KeyCode.RightArrow)) {
				direct = 0;
				step = 1;
			} else if (Input.GetKey (KeyCode.DownArrow)) {
				direct = 1;
				step = 1;
			} else if (Input.GetKey (KeyCode.LeftArrow)) {
				direct = 2;
				step = 1;
			} else if (Input.GetKey (KeyCode.UpArrow)) {
				direct = 3;
				step = 1;
			}
		}
		else { // WALK
			//transform.Translate(dX * Time.deltaTime, dY * Time.deltaTime, 0);
			//transform.Translate(dX[direct] / 15.0f * 32.0f, dY[direct] / 15.0f * 32.0f, 0.0f);
			Vector3 vector =  transform.position;
			vector.x += (int)dX[direct];
			vector.y += (int)dY[direct];
			transform.position = vector;

			int walkIndex = (step % 8) / 4;
			if (direct == 0) { //Right
				GetComponent<SpriteRenderer> ().sprite = walkR [walkIndex];
			}
			else if (direct == 1) { //Down
				GetComponent<SpriteRenderer> ().sprite = walkD [walkIndex];
			}
			else if (direct == 2) { //Left
				GetComponent<SpriteRenderer> ().sprite = walkL [walkIndex];
			}
			else if (direct == 3) { //Up
				GetComponent<SpriteRenderer> ().sprite = walkU [walkIndex];
			}

			++step;
			if (step >  16) {   
				step = 0;
				Vector3 v =  transform.position;
				v.x = ((int)Mathf.Round(v.x / 16)) * 16;
				v.y = ((int)Mathf.Round(v.y / 16)) * 16;
				transform.position = v;
			}
		}
	}
}
