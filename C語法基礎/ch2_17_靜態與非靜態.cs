using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    William小教室：
    口訣： 靜態屬於 類別（class） -> 因爲不需要宣告，可直接 XXX物件.參數名稱 = XXX;
           非靜態屬於 物件
*/
public class ch2_17_靜態與非靜態: MonoBehaviour
{
    public static int _Lv = 1; // 靜態變數
    public int atk = 0; // 非靜態變數

    void Start(){
        ch2_17_靜態與非靜態._Lv = 2; // 靜態變數可直接呼叫
        // ch2_17_靜態與非靜態.atk = 2; // 一般變數不能直接呼叫，必須實例化才能呼叫

        ch2_17_靜態與非靜態 demo = new ch2_17_靜態與非靜態();
        demo.atk = 20;  // 非靜態變數必須實例化才能呼叫
        // demo._Lv = 20; // 注意！實例化不能呼叫 靜態變數

        attack(); // 非靜態方法 可以呼叫 靜態方法
    }

    // 靜態方法不能使用 非靜態變數！只能使用 靜態變數
    // 非靜態變數和方法 沒有任何限制
    public static void attack () {
        // 不能呼叫 非 靜態的變數（只能呼叫靜態變數）
        // atk = 90; //錯誤！無法執行！
        attack2();
    }
    public static void attack2 () {
        ch2_17_靜態與非靜態._Lv = 123; // 靜態方法只能使用靜態變數
    }
}
