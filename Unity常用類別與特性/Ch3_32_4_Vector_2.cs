using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    Vector static
    -> 
*/ 
public class Ch3_32_4_Vector_2 : MonoBehaviour
{
    public Transform taget;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 本地坐標轉換成世界坐標
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        // 計算兩個向量的方向
        Vector3 toOther = taget.position - transform.position;

        // 計算 Dot，注意Dot沒有順序性
        float dot = Vector3.Dot(forward, toOther);
        // Debug.Log("DOT:" + dot);

        if(dot == 0){
            Debug.Log(taget.name + "平行");
        }else if(dot > 0) {
            Debug.Log(taget.name + "前方");
        }else {
            Debug.Log(taget.name + "後方"); 
        }
    }
}
