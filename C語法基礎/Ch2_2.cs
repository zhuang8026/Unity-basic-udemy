using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch2_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
/*  --------- 基本運算 --------- */ 
        int val_1 = 1;
        int val_2 = 2;
        int val_3 = 3;
        float val_5 = 4.0f;
        float val_6 = val_5 + val_3; // 請注意，在計算時中，只要有一個是浮點數，賦值的參數類型就必須是float

        int val_4 = val_1 + val_2;
        Debug.Log("int 測試 1" + val_4);
        val_4 = val_3 - val_1;
        Debug.Log("int 測試 2" + val_4);
        val_4 = val_3 * val_2;
        Debug.Log("int 測試 3" + val_4);
        val_4 = val_3 / val_2;
        Debug.Log("int 測試 4" + val_4);
        Debug.Log("float 測試 5" + val_6);

        int count = 0;
        count += 2; // count = count + 2
        count += 5; // count = count + 5
        Debug.Log("int 測試 count" + count); // 7

        count ++; // count = count + 1
        Debug.Log("int 測試 count" + count); // 8

/* --------- 布林運算 --------- */  
        bool bool_1 = true;
        bool bool_2 = false;

        bool bool_3 = bool_1 && bool_2;
        Debug.Log("bool測試 1" + bool_3);
        bool_3 = bool_1 || bool_2;
        Debug.Log("bool測試 2" + bool_3);
        bool_3 = !bool_2;
        Debug.Log("bool測試 3" + bool_3);

/* --------- 布林運算 --------- */  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
