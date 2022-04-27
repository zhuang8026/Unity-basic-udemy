using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    這是一個class(類)
    將由ch2_10去extend(繼承)
*/
public class ch2_13_類 {
    private float _ark;
    private float _block;
    private int _Lv;


    // 一般封裝
    public float getARK() {
        return _ark;
    }
    public void setARK(float ark) {
        if(ark < 0){
            Debug.Log("ARK不可小於0");
            ark=0;
        }
        _ark = ark;
    }

    // get&set 封裝
    public int Lv{
        get{
            return _Lv;
        }

        set{
            if(value < 0){
                Debug.Log("ARK不可小於0");
                _ark=0;
            }
            _Lv = value;
        }
    }
}
