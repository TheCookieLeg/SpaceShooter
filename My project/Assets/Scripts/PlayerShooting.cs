using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    private bool readyToShoot = false;

    void Start()
    {
        readyToShoot = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && readyToShoot)
        {
            //shoot stuff here
            readyToShoot = false;
            StartCoroutine(shootCooldown());
        }
    }


    IEnumerator shootCooldown()
    {
        yield return new WaitForSeconds(0.8f);
        readyToShoot = true;
    }
}
