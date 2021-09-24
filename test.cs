using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;


public class test : MonoBehaviour
{
    public Button btn;
    public Text txt;

    public int click_number=1;

    public void myclick()
    {
        //找到Canvas
        GameObject canvas = GameObject.Find("Canvas");

        //找到Canvas下的Button
        GameObject button = canvas.transform.Find("Button").gameObject;
        //找到Button下的Text
        GameObject button_Text = button.transform.Find("Text").gameObject;
        Text text = button_Text.GetComponent<Text>();
        text.text = ""+click_number;
        click_number++;

        //找到画布下的Text
        GameObject Text = canvas.transform.Find("Text").gameObject;

        //获取Text的Text组件
        Text text1 = Text.GetComponent<Text>();

        //修改Text组件的值
        text1.text = "点击了按钮";

        ////SceneManager.LoadScene(1);//1是要切换的场景的索引
        ////得到按钮的text值并修改
        //btn = GameObject.Find("button").GetComponent<Button>(); //-----------(1)
        //Text text = btn.transform.Find("Text").GetComponent<Text>(); //------------(2)
        ////或者吧（1）（2）合并成：
        ////Text text = GameObject.Find("填写button名/Text").getComponent<Text>();
        //text.text = "点击了按钮"; 
    }
}