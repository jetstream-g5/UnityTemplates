using UnityEngine;
using System.Collections;

public class Sceneswitch : MonoBehaviour {

	IEnumerator Start () {
		yield return new WaitForSeconds (5f);
		Application.LoadLevel ("Menu");
	}
}
