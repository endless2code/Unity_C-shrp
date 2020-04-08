﻿using UnityEngine;      //引用Unity API (函式庫:Unity屬性、功能...)



//類別 class 定義一個物件
//語法:class 類別名稱
// : MonoBegaviour 可以將此腳本掛在Unity物件上
//類別必須放在物件上才會執行

public class Class1 : MonoBehaviour
{
    //定義類別成員
    //C#
    //1. 大小寫不同
    //2. 括號成對出現

    //事件:在特定時間會依指定次數執行的方法(名稱為藍色)
    //開始事件:撥放遊戲時執行一次 - 初始設定

    private void Start()
    {
        //輸出("文字訊息");
        //C#結尾為分號
        print("Hello World");
    }
}
