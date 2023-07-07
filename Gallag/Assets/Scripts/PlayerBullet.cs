using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = default;
    private Rigidbody rigid = default;



    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * speed;

        Destroy(gameObject, 5f);
        //5초뒤 사라짐
    }

    private void OnTriggerEnter(Collider other) //플레이어 총알이 적에게 닿았을때 트리거 함수
    {
        if (other.tag == "Fighter") //적 기체에 닿았을 경우
        {
            //적 기체 코드 추가 시 주석 해제
            FighterController fighterController = other.GetComponent<FighterController>();
            fighterController.Die();

            Destroy(gameObject); //닿았을때 사라지게함
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
