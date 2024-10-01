using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//エージェントを動かす
public class AgentMove : MonoBehaviour
{
    //目標のオブジェクト
    [SerializeField]
    GameObject destinationObj;
    //目標の座標
    Vector3 destinationPotision;

    // Start is called before the first frame update
    void Start()
    {
        //目標オブジェクトから座標を取得
        destinationPotision = destinationObj.transform.position;
        //目的地となる座標を設定する
        GetComponent<NavMeshAgent>().destination = destinationPotision;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
