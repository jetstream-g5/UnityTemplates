using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class EditorSkip : MonoBehaviour {


	#if UNITY_EDITOR
	void Start () {
		Application.LoadLevel ("Level");
	}
	#endif
}
