using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
出生 -> Awake()       -> 只會呼叫一次
    -> OnEnable()     -> 當脚本被啓動時呼叫，物件或相機顯示開關

    -> Start()        -> 必須要在Enable狀態下。在呼叫Update前會呼叫Start，只會呼叫一次
    -> FixedUpdate()  -> 每次更新時間相同，常用於物理特性與網路傳遞功能，呼叫多次
    -> 
    -> Update()       -> 每次更新時間不相同，執行frame侯呼叫，常用於移動和旋轉...等GameObject，呼叫多次
    -> 
    -> LateUpdate()   -> 所有更新結束後執行，常用於跟隨某個目標，必須等到目標移動完后計算，呼叫多次
    -> 
    -> OnDisable()    -> 當脚本被啓動時呼叫，物件或相機顯示開關
    -> 
    -> OnDestory()    -> GameObject 被銷毀或游戲結束時呼叫， 只會呼叫一次
    -> 
*/ 
public class Ch3_29_1_生命周期 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
