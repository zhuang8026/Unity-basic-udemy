using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch2_6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int hp = Random.Range(1, 101); // 1 -> 100
        Debug.Log("Hp:" + hp);
        int count = 0; // 圈數
        while(hp > 0){
            count++;
            Debug.Log("run:" + count + "圈");
            hp--; // 一直到 Hp < 0
        }
    }
}
