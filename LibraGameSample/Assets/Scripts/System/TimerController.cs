using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimerController : MonoBehaviour
{
    [SerializeField]
    private TimeImageView _timeImageView;

    [SerializeField]
    public float countTime = 60;
    [HideInInspector]
    public float nowTime;
    [SerializeField]
    GameObject time;
    [SerializeField]
    GameObject answer;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        nowTime = countTime - Time.deltaTime;  

        countTime -= Time.deltaTime;
        GetComponent<Text>().text = countTime.ToString("F0");

        //this.time.GetComponent<Image>().fillAmount = nowTime;

        if (countTime < 20)
        {
            time.GetComponent<Image>().color = new Color(255, 255, 0);
        }
        if (countTime < 10)
        {
            time.GetComponent<Image>().color = new Color(255, 0, 0);
        }
        if (countTime < 0)
        {
            countTime = 0;
            this.answer.SetActive(true);
            //0秒になってから答えが出るまでの間を作る


        }
        _timeImageView.SizeChange(countTime);

        if (countTime == 0 && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("result");
        }
        
    }


    
}
