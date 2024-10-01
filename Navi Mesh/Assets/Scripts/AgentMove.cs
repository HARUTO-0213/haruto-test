using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//�G�[�W�F���g�𓮂���
public class AgentMove : MonoBehaviour
{
    //�ڕW�̃I�u�W�F�N�g
    [SerializeField]
    GameObject destinationObj;
    //�ڕW�̍��W
    Vector3 destinationPotision;

    // Start is called before the first frame update
    void Start()
    {
        //�ڕW�I�u�W�F�N�g������W���擾
        destinationPotision = destinationObj.transform.position;
        //�ړI�n�ƂȂ���W��ݒ肷��
        GetComponent<NavMeshAgent>().destination = destinationPotision;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
