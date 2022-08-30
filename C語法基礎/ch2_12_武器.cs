using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch2_12_武器
{
    
    private float _攻擊力;
    private float _殺傷範圍;
    private int _等級限制;

    public float get攻擊力(){
        return _攻擊力;
    }
    public void set攻擊力(float ark){
        if(ark > 0) {
            _攻擊力 = ark;
        } else {
            ark = 0;
            _攻擊力 = ark;
            Debug.Log("ARK不可小於0");
        }
    }
}
