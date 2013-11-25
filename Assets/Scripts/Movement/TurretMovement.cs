using UnityEngine;
using System.Collections;

public class TurretMovement : MonoBehaviour {

	public float xSpeed = 250.0f;
	public float ySpeed = 250.0f;

	public float yMinLimit = -20.0f;
	public float yMaxLimit = 20.0f;

	private float x = 0.0f;
	private float y = 0.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		x += Input.GetAxis("Horizontal") * xSpeed * 0.02f;
		y -= Input.GetAxis("Vertical") * ySpeed * 0.02f;
		
		x = x % 360.0f;
		y = ClampAngle(y, yMinLimit, yMaxLimit);
		
		var rotation = Quaternion.Euler(y, x, 0);
		
		transform.rotation = rotation;
	}

	float ClampAngle (float angle, float min, float max) {
		if (angle < -360.0f)
			angle += 360.0f;
		if (angle > 360.0f)
			angle -= 360.0f;

		return Mathf.Clamp (angle, min, max);
	}

}
