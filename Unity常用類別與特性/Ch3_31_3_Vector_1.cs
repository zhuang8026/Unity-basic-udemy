using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
WILLIAM小教室：
    Vector  是一種建構子 (Struct)
    Struct  中文叫做結構，結構的特性是 不會複製地址，存放的是value，
            所以如果賦值一份全新的Struct並對他修改變數，原始的Struct并不會改變
    使用方法：
        public Vector3(float x, float y, float z);

        -> forward  (前) Vector3(0,0,1)
        -> back     (前) Vector3(0,0,-1)
        -> up       (前) Vector3(0,1,0)
        -> down     (前) Vector3(0,-1,0)
        -> right    (前) Vector3(1,0,0)
        -> left     (前) Vector3(-1,0,0)
*/
public class Ch3_31_3_Vector_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Vector3.forward);
        Debug.Log(this.transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
