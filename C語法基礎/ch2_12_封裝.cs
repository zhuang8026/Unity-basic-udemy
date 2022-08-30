using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    什麽是 封裝？
    QA: 一個或多個方法打包在一個物理的包中
        根據訪問需求，設置權限，并通過訪問對象實現
*/ 
public class ch2_12_封裝: MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        ch2_12_類 arms1 = new ch2_12_類();

        arms1.setARK(90); // 爲了能設定更多限制，例如攻擊力不可為0
        Debug.Log(arms1.getARK());

        ch2_12_武器 嘴炮 = new ch2_12_武器();

        嘴炮.set攻擊力(90); // 封裝攻擊力並設定
        Debug.Log(嘴炮.get攻擊力()); // 取得攻擊力
    }


}
