using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch2_14_建構子: MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        ch2_14_類 arms1 = new ch2_14_類();
        ch2_14_類 arms2 = new ch2_14_類(10, 9, 8);

        Debug.Log("等級限制:" + arms2.getARK());

}


}
