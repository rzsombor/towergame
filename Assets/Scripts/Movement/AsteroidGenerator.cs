using UnityEngine;
using System.Collections;

public class AsteroidGenerator : MonoBehaviour {

	public Rigidbody asteroidPrefab;
	public float asteroidSpeed = 20.0f;
	public float asteroidDistance = 60.0f;
	public float generationDelta = 2.0F;
	private float nextInstance = 0.0F;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextInstance) {
			nextInstance = Time.time + generationDelta;

			float rotationX = Random.Range(0.0f, 40.0f);
			float rotationY = Random.Range(0.0f, 360.0f);

			Vector3 source = Quaternion.Euler(-rotationX, rotationY, 0) * Vector3.forward;
			source *= asteroidDistance;
			source = transform.TransformPoint(source);

			Rigidbody asteroid = Instantiate (asteroidPrefab, source, Random.rotation) as Rigidbody;

			Vector3 velocityVector = transform.position - source;
			velocityVector = Vector3.Normalize(velocityVector);
			velocityVector *= asteroidSpeed;
			asteroid.velocity = velocityVector;
		}
	}
}
