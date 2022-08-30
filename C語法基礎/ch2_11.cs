using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch2_11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ch2_11_物件 arm = new ch2_11_物件(); // 現在 arm 就是一個物件
        arm._ark = 1;
        arm._block = 2;
        arm.Lv = 3;

        ch2_11_武器 青龍偃月刀 = new ch2_11_武器(); // 青龍偃月刀 就是一個物件
        青龍偃月刀._攻擊力 = 10;
        青龍偃月刀._磨損耐久度 = 10;
        青龍偃月刀._等級限制 = 10;

        Debug.Log("arm._ark:" + arm._ark);
        Debug.Log("青龍偃月刀:" + 青龍偃月刀._攻擊力);
    }

}
