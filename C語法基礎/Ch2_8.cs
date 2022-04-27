using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch2_8 : MonoBehaviour
{
    public int _hp = 10;
    public int hp = 10;
    private int _hp3 = 10; // private 可不寫，就是"私有的"
    [HideInInspector] public int _hp2 = 10; // 公開數據，但隱藏"HideInInspector"
    // Start is called before the first frame update
    void Start()
    {
        jump();
        setHp(65);
        int myHp = getHp2();
        Debug.Log("my Hp:" + myHp);
    }

    void getHp1() {
        // void 是沒有回傳值
    }

    public int getHp2() {
        // 如果有回傳值，int 就是回傳的類型

        return _hp;
    }

    public void getHp3(int num) {
        _hp = num;
        _hp3 = num;
    } 

    void setHp(int hp) {
        _hp = hp;
        this.hp = hp; // 如果名字一樣，可以前面加一個this
    } 

    void jump() {
        Debug.Log("跳起來");
    }
}
