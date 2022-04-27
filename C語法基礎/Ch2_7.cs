using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch2_7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] foods = new string[3];
        foods[0] = "AA";
        foods[1] = "BB";
        foods[2] = "CC";

        for(int i=0;i<foods.Length; i++){
            Debug.Log(foods[i]);
        }

        foreach(string value in foods){
            Debug.Log(value);
        }
    }
}
