using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch2_13_封裝: MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        ch2_13_類 arms1 = new ch2_13_類();

        arms1.Lv=50; // 傳入ch2_13_類 => Lv set{}
        Debug.Log(arms1.Lv); //呼叫ch2_13_類 => Lv get{}
    }


}
