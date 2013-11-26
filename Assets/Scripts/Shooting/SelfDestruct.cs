using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

	public float timer = 3.0f;

	void Start () {
		Destroy(gameObject, timer);
	}
}
