using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch2_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int val_1 = 10;
        int val_2 = 20;

        bool val_3 = val_1 == val_2;
        Debug.Log("bool == :" + val_3);

        val_3 = val_1 != val_2;
        Debug.Log("bool != :" + val_3);

        val_3 = val_1 > val_2;
        Debug.Log("bool > :" + val_3);

        val_3 = val_1 < val_2;
        Debug.Log("bool < :" + val_3);

        val_3 = val_1 >= val_2;
        Debug.Log("bool >= :" + val_3);

        val_3 = val_1 <= val_2;
        Debug.Log("bool <= :" + val_3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
