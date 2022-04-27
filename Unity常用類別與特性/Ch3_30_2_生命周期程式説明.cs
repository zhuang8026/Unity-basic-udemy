using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch3_30_2_生命周期程式説明 : MonoBehaviour
{
    public bool isDestory = false;

    void Awake()
    {
        Debug.Log("Awake");
    }
    void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
        onSelectDestory();
    }

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    void OnDestory()
    {
        Debug.Log("OnDestory");
    }

    void onSelectDestory() {
        if(isDestory) {
            Destroy(this); // this 是指整個script文件
        }
    }
}
