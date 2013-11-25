using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
		public float destroyDistance = 200.0f;
		private Vector3 startPosition;

		void Start ()
		{
				startPosition = transform.position;
		}

		void Update ()
		{
				if (Vector3.Distance (startPosition, transform.position) > destroyDistance) {
						Destroy (gameObject);
				}
		}

		void OnCollisionEnter (Collision collision)
		{
				if (collision.gameObject.tag == "Asteroid") {
						Destroy (gameObject);
				}
		}
}
