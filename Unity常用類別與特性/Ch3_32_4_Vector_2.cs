using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    Vector static
    -> Dot
    -> Cross
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
        // 本地坐標 轉換 成世界坐標
        // transform 是本地
        // Vector3   是世界
        Vector3 forward = this.transform.TransformDirection(Vector3.forward); // 將自身坐標 轉到 世界坐標
        // 計算兩個向量的方向
        Vector3 toOther = taget.position - this.transform.position;

        // 計算 Dot，注意Dot沒有順序性
        // float dot = Vector3.Dot(forward, toOther); // 注意: Dot 算出來是 浮點數
        // Debug.Log("DOT:" + dot);
        // if(dot == 0){
        //     Debug.Log(taget.name + "平行");
        // }else if(dot > 0) {
        //     Debug.Log(taget.name + "前方");
        // }else {
        //     Debug.Log(taget.name + "後方"); 
        // }

        Vector3 cross = Vector3.Cross(forward, toOther); // 注意: Cross 算出來是 Struct 
        // Debug.Log("cross:" + cross.y);
        if(cross.y == 0){
            Debug.Log(taget.name + "重叠");
        }else if(cross.y > 0) {
            Debug.Log(taget.name + "右方");
        }else {
            Debug.Log(taget.name + "左方");
        }

    }
}
