using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    這是一個class(類)
    將由ch2_10去extend(繼承)
*/
public class ch2_14_類 {
    private float _ark;
    private float _block;
    private int _Lv;


    // constructor
    public ch2_14_類() {}
    public ch2_14_類(float ark, float block, int Lv) {
        _ark = ark;
        _block = block;
        _Lv = Lv;
    }

    // 封裝    
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

}
