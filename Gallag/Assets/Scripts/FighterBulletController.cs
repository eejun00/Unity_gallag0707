using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterBulletController : MonoBehaviour
{
    public float speed = 40f;
    private Rigidbody fighterBulletRigidbody;
    public GameObject bulletDeathPrefab;

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
            PlayerControler playerController = other.GetComponent<PlayerControler>();
            GameObject bulletDeath = Instantiate(bulletDeathPrefab, transform.position, transform.rotation);

            if (playerController != null)
            {
                Debug.Log("총알에 맞았다");
                playerController.Die();
                Destroy(gameObject);
                Destroy(bulletDeath, 2f);
            }
        }
    }
}
