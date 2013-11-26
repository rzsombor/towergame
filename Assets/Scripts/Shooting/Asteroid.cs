using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour
{

		public Transform explosionPrefab;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnCollisionEnter (Collision collision)
		{
				if (collision.gameObject.tag == "Projectile") {
						Instantiate (explosionPrefab, transform.position, transform.rotation);
						Destroy (gameObject);
				} else if (collision.gameObject.tag == "Player") {
						Debug.Log ("Player damage!");
						Destroy (gameObject);
				}
		}
}
