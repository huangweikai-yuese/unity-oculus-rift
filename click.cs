using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class click : MonoBehaviour
{
    public void clicked(string name) {
        GameObject canvas;
        GameObject button;
        GameObject Text;

        //根据对象名判断响应哪个点击事件
        switch (name)
        {
            case "Cube":
                //找到Canvas
                 canvas = GameObject.Find("Canvas");
                //找到Canvas下的Button
                button = canvas.transform.Find("Button").gameObject;
                Destroy(button);
                break;
            case "play":
                //找到Canvas
                 canvas = GameObject.Find("Canvas");
                //找到画布下的Text
                Text = canvas.transform.Find("Text").gameObject;
                //获取Text的Text组件
                Text text_play = Text.GetComponent<Text>();
                //修改Text组件的值
                text_play.text = "点击了play";
                break;
            case "pause":
                //找到Canvas
                canvas = GameObject.Find("Canvas");
                //找到画布下的Text
                Text = canvas.transform.Find("Text").gameObject;
                //获取Text的Text组件
                Text  text_pause = Text.GetComponent<Text>();
                //修改Text组件的值
                text_pause.text = "点击了pause";
                break;
            default:
                break;
        }
    }
}
