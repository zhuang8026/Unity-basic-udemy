using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    struct 與 Class 用法基本上一樣
    Class  產生的Object物件，存放在變數内的是 reference(參考)
    Struct 存放在變數内的是 value，當 Struct 使用等號（=）寫入新的變數時，會複製一份新的 Struct 
*/
public class ch2_15_結構使用: MonoBehaviour
{
    void Start(){
        // struct 
        ch2_15_結構 ch15 = new ch2_15_結構();
        // ch2_15_結構 ch15 = new ch2_15_結構(10, 60);
        ch2_15_結構 ch15_2 = ch15; // ch15_2 獲得新的結構

        // class
        ch2_14_類 arms1 = new ch2_14_類(10, 9, 8);
        ch2_14_類 arms2 = arms1; // arms2 獲得新的物件包括地址

        ch15_2._h = 1899;
        arms2.setARK(1899);
        
        Debug.Log("Struct:" + ch15._h); // 60
        Debug.Log("Class:" + arms2.getARK()); // 1899

        // Vector3(); // 這就是一個 struct
        /*
        william 小教室
            -> 為社麽 "ch15_2._h = 1899;", ch15._h 不等於 1899 ?
            -> QA: ch15結構 複製一份到 ch15_2, 所以ch15_2修改參數時候, 對ch15完全沒有影響,
                   當new ch2_14_類 時，會生成一個地址放到arms1物件中,
                   arms1物件複製一份到 arms2, 地址會一并複製過去, 所以修改arms2參數時, 會直接修改到 arms1
        */ 
    }
}
