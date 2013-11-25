using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{

		public Rigidbody projectilePrefab;
		public Transform projectileSource;
		public float projectileSpeed = 30.0f;
		private AudioSource shootingSoundSource;


		// Use this for initialization
		void Start ()
		{
				shootingSoundSource = GetComponent<AudioSource> ();
		}
	
		// Update is called once per frame
		void Update ()
		{

		}

		public void Shoot ()
		{
				shootingSoundSource.Play ();

				Rigidbody c = Instantiate (projectilePrefab, projectileSource.position, projectileSource.rotation) as Rigidbody;
				c.velocity = projectileSource.TransformDirection (Vector3.forward * projectileSpeed);
		}
}
