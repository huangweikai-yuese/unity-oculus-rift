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
                //��ȡText��Text���
                Text text_play = Text.GetComponent<Text>();
                //�޸�Text�����ֵ
                text_play.text = "�����play";
                break;
            case "pause":
                //�ҵ�Canvas
                canvas = GameObject.Find("Canvas");
                //�ҵ������µ�Text
                Text = canvas.transform.Find("Text").gameObject;
                //��ȡText��Text���
                Text  text_pause = Text.GetComponent<Text>();
                //�޸�Text�����ֵ
                text_pause.text = "�����pause";
                break;
            default:
                break;
        }
    }
}
