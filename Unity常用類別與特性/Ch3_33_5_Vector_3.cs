using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch3_33_5_Vector_3 : MonoBehaviour
{
    // 未來到達的坐標點
    public Vector3 tagerPoint; // Vector3向量(Struct/ x y z)
                               // 由外部控制
    public int speed = 3;
    void Update()
    {
        Vector3 currentPoint = transform.position;  // 本地坐標
        float maxDistance = Time.deltaTime * speed; // 每次要移動的距離（每一幀(秒)要跑多少個單位）
                                                    // Time.deltaTime 是每一幀的時間
        transform.position = Vector3.MoveTowards(currentPoint, tagerPoint, maxDistance);// Vector3.MoveTowards(目前的點, 移動的點, 每一次要移動多少距離)
    }
}
