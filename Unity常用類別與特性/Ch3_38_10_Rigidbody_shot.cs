using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch3_38_10_Rigidbody_shot : MonoBehaviour
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

    public Vector3 shootSpeed;
    private Rigidbody shootRigidbody; // 宣告

    // Start is called before the first frame update
    void Start()
    {
        // 取得
        shootRigidbody = GetComponent<Rigidbody>(); // 賦值
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

    }

    public void shoot() {
        shootRigidbody.isKinematic = false; // true -> isKinematic 不允許自身受到碰撞，但還是會對其他物件造成碰撞
        shootRigidbody.AddForce(shootSpeed); // 外部設置射擊距離
    }
}
