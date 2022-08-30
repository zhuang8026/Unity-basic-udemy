using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch2_9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 80;
        int b;

        setA(a); // call by value 
                 // 因爲我們只是把80放入，但并沒有把a的位置放入
        Debug.Log(a); // 80

        setB(ref a); // call by reference(參考)，初始值不能為空，必須要有值
        Debug.Log(a); // 20

        setC(out b); // 因爲是反向輸出，所以不需要初始值
        Debug.Log(b); // 20
    }

    void setA(int a ) {
        a=20;

    }
    void setB(ref int a ) {
        a = 20;
    }
    void setC(out int a) { // 反向輸出，輸出類型為 int
        a = 20;
    }
}
