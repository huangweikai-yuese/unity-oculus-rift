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

        //���ݶ������ж���Ӧ�ĸ�����¼�
        switch (name)
        {
            case "Cube":
                //�ҵ�Canvas
                 canvas = GameObject.Find("Canvas");
                //�ҵ�Canvas�µ�Button
                button = canvas.transform.Find("Button").gameObject;
                Destroy(button);
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
                TMP_Text tmp_text_puase= Text.GetComponent<TMP_Text>();
                //�޸�Text�����ֵ
                tmp_text_puase.text = "click pause";
                break;
            default:
                break;
        }
    }
}
