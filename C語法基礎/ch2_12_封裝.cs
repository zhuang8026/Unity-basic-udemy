using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch2_12_封裝: MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        ch2_12_類 arms1 = new ch2_12_類();
        arms1.setARK(90);

        Debug.Log(arms1.getARK());

    }


}
