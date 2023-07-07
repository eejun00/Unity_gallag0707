using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    GameManager gameManager;
    public GameObject bulletPrefab = default;
    public GameObject playerDeathPrefab;
    private Rigidbody playerRigid = default;
    public float speed = default;
    public float attackTime = default;
    public float attackSpeed = 0.2f;
    

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.FindAnyObjectByType<GameManager>();
        playerRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        attackTime += Time.deltaTime;

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigid.velocity = newVelocity;

        if (attackTime > attackSpeed)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                attackTime = 0;
                GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            }
        }

    }

    public void Die()
    {
        gameManager.life -= 1;
        if (gameManager.life <= 0)
        {
            GameObject death = Instantiate(playerDeathPrefab, transform.position, transform.rotation);
            gameObject.SetActive(false);
            Destroy(death, 2f);
        }
    }
}
