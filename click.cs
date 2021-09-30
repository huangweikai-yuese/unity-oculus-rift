using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class click : MonoBehaviour
{
    public void GameObject_clicked(string name) {
        GameObject canvas;
        GameObject Text;

        //根据对象名判断响应哪个点击事件
        switch (name)
        {
            case "Cube":
                //找到Canvas
                canvas = GameObject.Find("Canvas");
                //找到画布下的Text
                Text = canvas.transform.Find("Text").gameObject;
                //获取Text的TMP_Text组件
                TMP_Text tmp_text_cube = Text.GetComponent<TMP_Text>();
                //修改Text组件的值
                tmp_text_cube.text = "click cube";
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
                TMP_Text tmp_text_puase = Text.GetComponent<TMP_Text>();
                //修改Text组件的值
                tmp_text_puase.text = "click pause";
                break;
            default:
                break;
        }
    }

    public void Canvas1_button_clicked(){
        //找到Canvas
        GameObject canvas = GameObject.Find("Canvas");
        //找到画布下的Text
        GameObject  Text = canvas.transform.Find("Text").gameObject;
        //获取Text的Text组件
        TMP_Text tmp_text_puase = Text.GetComponent<TMP_Text>();
        //修改Text组件的值
        tmp_text_puase.text = "click Button";
    }

    public void Canvas1_Slider_clicked()
    {
        //找到Canvas1对象
        GameObject canvas1 = GameObject.Find("Canvas1");
        //找到Canvas1下的Panel对象
        GameObject Panel = canvas1.transform.Find("Panel").gameObject;
        //找到Panel下的Slider对象
        GameObject Slider = Panel.transform.Find("Slider").gameObject;
        //获取Slider的Slider组件
        Slider Canvas1_Panel_Slider = Slider.GetComponent<Slider>();


        //找到Canvas对象
        GameObject canvas = GameObject.Find("Canvas");
        //找到画布下的Text对象
        GameObject Text = canvas.transform.Find("Text").gameObject;
        //获取Text的Text组件
        TMP_Text tmp_text_puase = Text.GetComponent<TMP_Text>();
        //修改Text组件的值
        tmp_text_puase.text = ""+Canvas1_Panel_Slider.value;
    }
}
