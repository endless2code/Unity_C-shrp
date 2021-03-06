﻿using System;
using UnityEngine;
//註解:用來說明紀錄等等.. 只會在此腳本內看到
//摘要 summary : 描述此內容，會在其他腳本上看到-提高維護性與擴充性
/// <summary>
/// 定義汽車物件
/// </summary>

//新增的C#放在專案內為藍圖
//放在場景物件上為實體物件


public class Cars : MonoBehaviour
{
    //認識第一個成員 : 欄位 field - 儲存物件資料
    //資料類型:
    //CC數 - 2000(整數-int)
    //重量 - 100.9(浮點數-float)
    //品牌 - BMW(字串-string)
    //煞車 - 是否開啟(布林值-bool)

    //定義欄位語法:
    //修飾詞 資料類型 欄位名稱(指定 值);

    //修飾詞 :
    //公開 public : 允許其他類別存取，顯示在屬性面板(Inspector)上
    //私人 private (預設) : 不允許、不顯示

    //預設值 :
    //int、float為0
    //string為""
    //bool為false

    //欄位屬性 Attribute : Unity 提供用於輔助欄位的功能
    //語法:[屬性名稱(值)]
    //標題 [Header("字串")]
    //提示[Tooltip("字串")]
    //範圍[Range(最小值,最大值)] - 僅限於數值類型資料int、float


    /// <summary>
    /// 汽車的CC數
    /// </summary>
    [Header("汽車的CC數"),Range(200,2000)]
    public int cc = 2000;
    /// <summary>
    /// 汽車的重量
    /// </summary>
    [Tooltip("這個欄位是用來存放汽車的重量")]
    public float weight = 100.9f;
    /// <summary>
    /// 汽車的品牌
    /// </summary>
    [Header("品牌")]
    [Tooltip("代表這台車子的品牌")]
    public string brand = "BMW";
    /// <summary>
    /// 汽車剎車
    /// </summary>
    [Header("是否剎車"),Tooltip("用來儲存這台車子目前的剎車狀態")]
    public  bool brake =false;


    
    public void Start()
    {
        transform.Translate(1, 10, 10);

    }
}
