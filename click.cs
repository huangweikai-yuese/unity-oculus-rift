using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class click : MonoBehaviour
{
    public void GameObject_clicked(string name) {
        GameObject canvas;
        GameObject Text;

        //���ݶ������ж���Ӧ�ĸ�����¼�
        switch (name)
        {
            case "Cube":
                //�ҵ�Canvas
                canvas = GameObject.Find("Canvas");
                //�ҵ������µ�Text
                Text = canvas.transform.Find("Text").gameObject;
                //��ȡText��TMP_Text���
                TMP_Text tmp_text_cube = Text.GetComponent<TMP_Text>();
                //�޸�Text�����ֵ
                tmp_text_cube.text = "click cube";
                break;
            case "play":
                //�ҵ�Canvas
                canvas = GameObject.Find("Canvas");
                //�ҵ������µ�Text
                Text = canvas.transform.Find("Text").gameObject;
                //��ȡText��TMP_Text���
                TMP_Text tmp_text_play = Text.GetComponent<TMP_Text>();
                //�޸�Text�����ֵ
                tmp_text_play.text = "click play";
                break;

            case "pause":
                //�ҵ�Canvas
                canvas = GameObject.Find("Canvas");
                //�ҵ������µ�Text
                Text = canvas.transform.Find("Text").gameObject;
                //��ȡText��Text���
                TMP_Text tmp_text_puase = Text.GetComponent<TMP_Text>();
                //�޸�Text�����ֵ
                tmp_text_puase.text = "click pause";
                break;
            default:
                break;
        }
    }

    public void Canvas1_button_clicked(){
        //�ҵ�Canvas
        GameObject canvas = GameObject.Find("Canvas");
        //�ҵ������µ�Text
        GameObject  Text = canvas.transform.Find("Text").gameObject;
        //��ȡText��Text���
        TMP_Text tmp_text_puase = Text.GetComponent<TMP_Text>();
        //�޸�Text�����ֵ
        tmp_text_puase.text = "click Button";
    }

    public void Canvas1_Slider_clicked()
    {
        //�ҵ�Canvas1����
        GameObject canvas1 = GameObject.Find("Canvas1");
        //�ҵ�Canvas1�µ�Panel����
        GameObject Panel = canvas1.transform.Find("Panel").gameObject;
        //�ҵ�Panel�µ�Slider����
        GameObject Slider = Panel.transform.Find("Slider").gameObject;
        //��ȡSlider��Slider���
        Slider Canvas1_Panel_Slider = Slider.GetComponent<Slider>();


        //�ҵ�Canvas����
        GameObject canvas = GameObject.Find("Canvas");
        //�ҵ������µ�Text����
        GameObject Text = canvas.transform.Find("Text").gameObject;
        //��ȡText��Text���
        TMP_Text tmp_text_puase = Text.GetComponent<TMP_Text>();
        //�޸�Text�����ֵ
        tmp_text_puase.text = ""+Canvas1_Panel_Slider.value;
    }
}
