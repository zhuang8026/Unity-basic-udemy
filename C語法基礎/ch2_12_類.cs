using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    這是一個class(類)
    將由ch2_10去extend(繼承)
*/
public class ch2_12_類 {
    private float _ark;
    private float _block;
    private int Lv;


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
