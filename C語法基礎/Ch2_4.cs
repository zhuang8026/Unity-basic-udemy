using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch2_4 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int Hp = 10;
        if(Hp > 0) {
            Debug.Log("go live!");
        }else {
            Debug.Log("game over!");
        }

        int Sp = 72;
        if(Sp <=100 && Sp>= 70){
            Debug.Log("一般攻擊");
        }else if(Sp <=69 && Sp>= 40) {
            Debug.Log("强力攻擊");
        }else if(Sp <=1 && Sp>= 39) {
            Debug.Log("强力攻擊");
        }else {
            Debug.Log("無效！");
        }
    }
}
