using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;

public class Movimiento : MonoBehaviour {

	private int NUM_CUBOS = 6;

	public GameObject cubo1;
	public GameObject cubo2;
	public GameObject cubo3;
	public GameObject cubo4;
	public GameObject cubo5;
	public GameObject cubo6;

	private bool space;

	// Use this for initialization
	void Start () {
		initPosiciones ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space"))
			mover ();
	}

	void initPosiciones () {
		double difGrados = 2 * Math.PI / NUM_CUBOS;

		GameObject[] cubos = new GameObject[6];
		cubos[0] = cubo1;
		cubos[1] = cubo2;
		cubos[2] = cubo3;
		cubos[3] = cubo4;
		cubos[4] = cubo5;
		cubos[5] = cubo6;
		for (int i = 0; i < NUM_CUBOS; i++) {
			// X:
			float x = (float)Math.Sin (difGrados * i);
			x *= 2;
			// Z
			float z = (float)Math.Cos (difGrados * i);
			z *= 2;
			cubos[i].transform.position = new Vector3 (x, 1, z);
		}

		
	}

	void mover () {
		Vector3 c1 = cubo1.transform.position;
		Vector3 c2 = cubo2.transform.position;
		Vector3 c3 = cubo3.transform.position;
		Vector3 c4 = cubo4.transform.position;
		Vector3 c5 = cubo5.transform.position;
		Vector3 c6 = cubo6.transform.position;

		cubo1.transform.position = c2;
		cubo2.transform.position = c3;
		cubo3.transform.position = c4;
		cubo4.transform.position = c5;
		cubo5.transform.position = c6;
		cubo6.transform.position = c1;
	}
}
