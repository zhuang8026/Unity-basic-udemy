using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    struct 結構體
    struct 與 Class 用法基本上一樣
    Class  產生的Object物件，存放在變數内的是 reference
    Struct 存放在變數内的是 value，當 Struct 使用等號（=）寫入新的變數時，會複製一份新的 Struct 

    使用原理：
        1. 不想改變原來的數值用 struct，想改變原來的數值用class
        2. struct 是深拷貝，class是淺拷貝
*/
public struct ch2_15_結構 {
    public float _w;
    public float _h;

    // public ch2_15_結構(){}
    public ch2_15_結構(float w, float h){
        _w=w;
        _h=h;
    }

    public float getW(){
        return _w;
    }
}
