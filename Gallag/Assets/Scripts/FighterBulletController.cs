using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterBulletController : MonoBehaviour
{
    public float speed = 3000f;
    private Rigidbody fighterBulletRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        fighterBulletRigidbody = GetComponent<Rigidbody>();

        fighterBulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            // 병합시 활성화
            //PlayerController playerController = other.GetComponent<PlayerController>();

            //if(playerController != null)
            //{
            //    playerController.Die();
            //}
        }
    }
}
