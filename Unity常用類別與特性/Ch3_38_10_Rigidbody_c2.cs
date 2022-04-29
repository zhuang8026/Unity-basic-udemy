using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch3_38_10_Rigidbody_c2 : MonoBehaviour
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
        -> 爲什麽要將 Collider(碰撞器) 關閉？
            -> 關閉之後，物體與物體之間就不會產生碰撞的效果
        -> 什麽是 isKinematic ?
            -> true >> 不允許自身受到碰撞，但還是會對其他物件造成碰撞，不會受到重力等物理作用力影響
    */

    public float speed = 100;

    // 取得cube原件(自己設定)
    public Rigidbody rigidbody; // 圓球
    public GameObject rigidbody2;

    // 取得發射物件
    private Ch3_38_10_Rigidbody_shot shootObj;

    void Start()
    {
        // 取得cube rigidbody 原件
        rigidbody = this.gameObject.GetComponent<Rigidbody>(); // 
        // rigidbody2.GetComponent<Rigidbody>() === Rigidbody;

        // 取得子物體原件
        shootObj = GetComponentInChildren<Ch3_38_10_Rigidbody_shot>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        // 左右移動
        float x = Input.GetAxis("Horizontal"); // 水平方向
        float y = Input.GetAxis("Vertical");   // 垂直方向

        // 按下滑鼠左鍵
        if(Input.GetMouseButton(0)){
            shootObj.shoot();
        }

        // 設定給力的方向
        Vector3 force = new Vector3(x*speed, 0 ,y*speed); // 因爲y軸是垂直上下
        // 給剛體一個力
        rigidbody.AddForce(force);
        // rigidbody.velocity = force;

        /**
            velocity 和 AddForce 的差別？
            -> AddForce 瞬間給物體一個規定好的力（持續施加速度，會受到物體質量影響）
            -> AddForce 瞬間給物體一個恆定的速度，將物體提升至該速度（有限施加速度）
        */
    }
}
