using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using demo.ch16.Alex;

public class ch2_16_命名空間_namespace: MonoBehaviour
{
    void Start(){
        Move move1 = new Move(); // 因爲上面已經特別 引入（using）, 已經變成默認值
        demo.ch16.Ken.Move move2 = new  demo.ch16.Ken.Move(); // 如需特別引入，可以使用 demo.ch16.Ken.Move
        demo.ch16.Alex.Move move3 = new  demo.ch16.Alex.Move(); // 如需特別引入，可以使用 demo.ch16.Ken.Move


        Debug.Log(move1.ToMove());
        Debug.Log(move2.ToMove());
        Debug.Log(move3.ToMove());
    }
}
