using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch3_37_9_Rigidbody_c1 : MonoBehaviour
{
    /**
    william 小教室:
        -> Rigidbody 剛體
        -> 注意: 剛體的運算必須放在 FixedUpdate 中 (只要是有物理特性,都需要放在FixedUpdate)
        -> 
        -> 取得 component
            -> GetComponent
            -> GetComponentInChildren
            -> 
    */

    public Vector3 tagerPoint; // Vector3向量(Struct/ x y z)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        // 到達某一個位置
        Vector3 currentPoint = transform.position;
        float maxDistance = Time.deltaTime * 3;
        // Vector3.MoveTowards(現在位置, 未來位置, 完成一次的時間(速度));
        transform.position = Vector3.MoveTowards(currentPoint, tagerPoint, maxDistance);
        // Debug.Log(tagerPoint.y);

        // 匀速上升
        // transform.position += Vector3.up * Time.deltaTime;

        // print(Vector3.up);
        // print(transform.position);
        // print(transform.GetChild(0).transform.position);
        // print(transform.GetChild(0).transform.localPosition);
        // transform.position = new Vector3(0, 10, 0);
    }
}
