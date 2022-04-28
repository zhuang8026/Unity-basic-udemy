using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch3_35_7_time_code_c1 : MonoBehaviour
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
                -> Edit> Project Setting> Quality> Other區域> VSync Count> Don't Sync
                -> 
                -> 
                -> 
                -> 
    */

    public float timeScale = 0; // 設定 Time.timeScale 數值
    public bool changeScale = false; // 是否可設定 Time.timeScale

    void Awake()
    {
        // 要先去 Unity3d 設定給定 FPS 才有效果
        Application.targetFrameRate = 30; // 
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(changeScale) {
            Time.timeScale = timeScale; // 可控制物件速度
                                        // 注意: timeScale 控制的是整個游戲的時間，并不是挂載的物件
            // changeScale = false;
        }else{
            Time.timeScale = 1f; // 回復正常速度
        } 
        // Debug.Log("Time:" + Time.time); // 第一幀開始計算
        // Debug.Log("RealtimeSinceStartup:" + Time.realtimeSinceStartup); // 按下play開始計算
    
        // Debug.Log("Update DeltaTime:" + Time.deltaTime); // 每一幀運行的時間: 0.0333..
                                                         // 計算公式: 1/30 => Application.targetFrameRate=30; 設定
    }

    void FixedUpdate()
    {
        // FixedUpdate 是固定更新頻率
        Debug.Log("FixedUpdate DeltaTime" + Time.deltaTime); // 全部都是0.2, 爲什麽？因爲 fixedupdate 會影響更新頻率，會讓每一幀更新時間都一樣
    }
}
