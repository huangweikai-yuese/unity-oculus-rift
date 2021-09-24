using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    public void myclick()
    {
        SceneManager.LoadScene(1);//1是要切换的场景的索引  
    }
}