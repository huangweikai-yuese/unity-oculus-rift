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

    public void button_click()
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
        text1.text = "�����ť";

      GameObject pauseimg = GameObject.Find("pause");
      Destroy(pauseimg);

    }
    public void PauseImage_click(){

        //�ҵ�Canvas
        GameObject canvas = GameObject.Find("Canvas");

        //�ҵ������µ�Text
        GameObject Text = canvas.transform.Find("Text").gameObject;

        //��ȡText��Text���
        Text text1 = Text.GetComponent<Text>();

        //�޸�Text�����ֵ
        text1.text = "��ť��";

    }

    //��ť����
    public void control_button()
    {
        OVRInput.Controller controller = OVRInput.Controller.RTouch;//�ҿ�����

        OVRInput.GetDown(OVRInput.Button.One, controller);//A��

        OVRInput.GetDown(OVRInput.Button.Two, controller);//B��

        OVRInput.GetDown(OVRInput.Button.Start, controller);//������

        OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, controller);//ʳָ��

        OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, controller);//��ָ��

    }
}