using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 類別
public class ch2_10: MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        ch2_10_類 arms1 = new ch2_10_類();
        arms1._ark = 10;
        arms1._block = 9;
        arms1.Lv = 8;


        ch2_10_類 arms2 = new ch2_10_類();
        arms2._ark = 10;
        arms2._block = 9;
        arms2.Lv = 8;

        Debug.Log(arms1._ark);
        Debug.Log(arms2._ark);

    }


}
