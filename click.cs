using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
                //获取Text的TMP_Text组件
                TMP_Text tmp_text_play = Text.GetComponent<TMP_Text>();
                //修改Text组件的值
                tmp_text_play.text = "click play";
                break;

            case "pause":
                //找到Canvas
                canvas = GameObject.Find("Canvas");
                //找到画布下的Text
                Text = canvas.transform.Find("Text").gameObject;
                //获取Text的Text组件
                TMP_Text tmp_text_puase= Text.GetComponent<TMP_Text>();
                //修改Text组件的值
                tmp_text_puase.text = "click pause";
                break;
            default:
                break;
        }
    }
}
