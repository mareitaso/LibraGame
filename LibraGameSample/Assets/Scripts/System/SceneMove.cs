using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    // 
    //private int stageNumber = 10;


    // 
    [SerializeField]
    private int[] easyNumber;
    // 
    [SerializeField]
    private int[] normalNumber;
    // 
    [SerializeField]
    private int[] hardNumber;

    /// <summary>
    /// クリックしたボタンに、
    /// 応じた難易度に移行
    /// </summary>

    public void OnclickTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void OnclickEasy()
    {
        // 
        var rnd = Random.Range(0, easyNumber.Length);
        SceneManager.LoadScene("EasyStage" + easyNumber[rnd]);
    }

    public void OnclickNormal()
    {
        var rnd = Random.Range(0, normalNumber.Length);
        SceneManager.LoadScene("NormalStage" + normalNumber[rnd]);
    }

    public void OnclickHard()
    {
        var rnd = Random.Range(0, hardNumber.Length);
        SceneManager.LoadScene("HardStage" + hardNumber[rnd]);
    }
    
}
