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
        //�ҵ�Canvas
        GameObject canvas = GameObject.Find("Canvas");

        //�ҵ�Canvas�µ�Button
        GameObject button = canvas.transform.Find("Button").gameObject;
        //�ҵ�Button�µ�Text
        GameObject button_Text = button.transform.Find("Text").gameObject;
        Text text = button_Text.GetComponent<Text>();
        text.text = ""+click_number;
        click_number++;

        //�ҵ������µ�Text
        GameObject Text = canvas.transform.Find("Text").gameObject;

        //��ȡText��Text���
        Text text1 = Text.GetComponent<Text>();

        //�޸�Text�����ֵ
        text1.text = "����˰�ť";

        ////SceneManager.LoadScene(1);//1��Ҫ�л��ĳ���������
        ////�õ���ť��textֵ���޸�
        //btn = GameObject.Find("button").GetComponent<Button>(); //-----------(1)
        //Text text = btn.transform.Find("Text").GetComponent<Text>(); //------------(2)
        ////���߰ɣ�1����2���ϲ��ɣ�
        ////Text text = GameObject.Find("��дbutton��/Text").getComponent<Text>();
        //text.text = "����˰�ť"; 
    }
}