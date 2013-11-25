using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour
{

		public Gun leftGun;
		public Gun rightGun;
		public float fireRate = 1.0F;
		private float nextFire = 0.0F;
		private Gun activeGun;	


		// Use this for initialization
		void Start ()
		{
				activeGun = leftGun;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetButton ("Fire1") && Time.time > nextFire) {
						nextFire = Time.time + fireRate;
						activeGun.Shoot ();

						activeGun = activeGun == leftGun ? rightGun : leftGun;
				}
		}
}
