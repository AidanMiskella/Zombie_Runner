using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour {

    [SerializeField] int ammoAmount = 5;
    [SerializeField] float rotationsPerMinute = 10.0f;
    [SerializeField] AmmoType ammoType;

    private void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "Player") {

            FindObjectOfType<Ammo>().IncreaseCurrentAmmo(ammoType, ammoAmount);
            Destroy(gameObject);
        }
    }

    private void Update() {

        transform.Rotate(0, 6.0f * rotationsPerMinute * Time.deltaTime, 0);
    }
}
