using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch3_34_6_time_desc : MonoBehaviour
{
    /**
    William 小教室:
    Time 常用屬性
        -> time Static variable
        -> 注意: 只要是靜態變數, 就説明不需要實例化, 即可直接呼叫使用, 但要記住 靜態方法只能呼叫靜態屬性, 反知。
            -> time         游戲運行運行了多久時間，單位 秒/s（1.受timeScale影響 2.第一 Frame 開始計算）
            -> realtimeSinceStartup 游戲運行了多久時間 （不受timeScale影響 2.按下 play 開始計算）
            -> deltaTime    每一個 Frame 運行的時間，單位 秒/s
            -> timeScale    可暫停 或 加速 或 緩速 時間

        -> FPS(每秒多少個 Frame)設定方式
            -> Edit> Project Setting> Quality> Other區域> VSync Count
            -> 
            -> 
            -> 
            -> 
    */ 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
    }
}
