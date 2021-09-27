using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using TMPro;

public class test : MonoBehaviour
{
    public Button btn;
    public Text txt;
    public int click_number=1;

    public void button_click()
    {
        //找到Canvas
        GameObject canvas = GameObject.Find("Canvas");

        //找到Canvas下的Button
        GameObject button = canvas.transform.Find("Button").gameObject;
        //找到Button下的Text
        GameObject button_Text = button.transform.Find("Text").gameObject;
        TMP_Text text = button_Text.GetComponent<TMP_Text>();
        text.text = ""+click_number;
        click_number++;

        //找到画布下的Text对象
        GameObject Text = canvas.transform.Find("Text").gameObject;

        //获取Text的Text组件
        TMP_Text text1 = Text.GetComponent<TMP_Text>();

        //修改Text组件的值
        text1.text = "点击了按钮";


    }

    //按钮举例
    public void control_button()
    {
        //OVRInput.Controller controller = OVRInput.Controller.RTouch;//右控制器

        //OVRInput.GetDown(OVRInput.Button.One, controller);//A键

        //OVRInput.GetDown(OVRInput.Button.Two, controller);//B键

        //OVRInput.GetDown(OVRInput.Button.Start, controller);//启动键

        //OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, controller);//食指键

        //OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, controller);//中指键

    }
}