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
        //5�ʵ� �����
    }

    private void OnTriggerEnter(Collider other) //�÷��̾� �Ѿ��� ������ ������� Ʈ���� �Լ�
    {
        if (other.tag == "Fighter") //�� ��ü�� ����� ���
        {
            //�� ��ü �ڵ� �߰� �� �ּ� ����
            FighterController fighterController = other.GetComponent<FighterController>();
            fighterController.Die();

            Destroy(gameObject); //������� ���������
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
