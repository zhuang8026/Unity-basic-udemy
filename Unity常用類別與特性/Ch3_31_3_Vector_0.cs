using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
WILLIAM小教室：
    Vector 和 transform 有什麽區別？
    -> Vector3.forward 只是一個定值，它只是 Vector3(0,0,1) 的縮寫
    -> Vector3 是按照世界坐標的方向移動
    -> transform 是按照自身的物體的坐標移動，也就是做，如果物體只要旋轉，和世界坐標方向不一樣，那麽，移動的方向就會不一樣

*/
public class Ch3_31_3_Vector_0 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Vector3.forward); // 按照世界坐標
        Debug.Log(this.transform.forward); // 按照自己的十字坐標
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
