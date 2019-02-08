using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSaraController : MonoBehaviour
{
    [SerializeField]
    GameObject right_sara;

    //右皿の総量
    [SerializeField]
    public int right_total_weight = 0;

    private bool check = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //当たり判定を使い、重さをプラス
    private void OnTriggerEnter(Collider collider)
    {
        //分銅のタグで重さ判定
        switch (collider.gameObject.tag)
        {
            case "weight1":
                if (check == false)
                {
                    right_total_weight += 1;
                    Debug.Log("R+1");
                    Debug.Log("R ="+right_total_weight);
                    check = true;
                }
                break;

            case "weight2":
                if (check == false)
                {
                    right_total_weight += 2;
                    Debug.Log("R+2");
                    Debug.Log("R =" + right_total_weight);
                    check = true;
                }
                
                break;

            case "weight3":
                if (check == false)
                {
                    right_total_weight += 3;
                    Debug.Log("R+3");
                    Debug.Log("R =" + right_total_weight);
                    check = true;
                }
                break;

            case "weight4":
                if (check == false)
                {
                    right_total_weight += 4;
                    Debug.Log("R+4");
                    Debug.Log(right_total_weight);
                    check = true;
                }
                break;

            case "weight5":
                if (check == false)
                {
                    right_total_weight += 5;
                    Debug.Log("+5");
                    Debug.Log(right_total_weight);
                    check = true;
                }
                break;

            case "weight6":
                if (check == false)
                {
                    right_total_weight += 6;
                    Debug.Log("+6");
                    Debug.Log(right_total_weight);
                    check = true;
                }
                break;

            case "weight7":
                if (check == false)
                {
                    right_total_weight += 7;
                    Debug.Log("+7");
                    Debug.Log(right_total_weight);
                    check = true;
                }
                break;

            case "weight8":
                if (check == false)
                {
                    right_total_weight += 8;
                    Debug.Log("+8");
                    Debug.Log(right_total_weight);
                    check = true;
                }
                break;

            case "weight9":
                if (check == false)
                {
                    right_total_weight += 9;
                    Debug.Log("+9");
                    Debug.Log(right_total_weight);
                    check = true;
                }
                break;
        }
    }

    //当たり判定を使い、重さをマイナス
    private void OnTriggerExit(Collider collider)
    {
        //分銅のタグで重さ判定
        switch (collider.gameObject.tag)
        {
            case "weight1":
                if (check == true)
                {
                    right_total_weight -= 1;
                    Debug.Log("R-1");
                    Debug.Log("R =" + right_total_weight);
                    check = false;
                }
                break;

            case "weight2":
                if (check == true)
                {
                    right_total_weight -= 2;
                    Debug.Log("R-2");
                    Debug.Log("R =" + right_total_weight);
                    check = false;
                }
                break;

            case "weight3":
                if (check == true)
                {
                    right_total_weight -= 3;
                    Debug.Log("R-3");
                    Debug.Log("R =" + right_total_weight);
                    check = false;
                }
                break;

            case "weight4":
                if (check == true)
                {
                    right_total_weight -= 4;
                    Debug.Log("-4");
                    Debug.Log(right_total_weight);
                    check = false;
                }
                break;

            case "weight5":
                if (check == true)
                {
                    right_total_weight -= 5;
                    Debug.Log("-5");
                    Debug.Log(right_total_weight);
                    check = false;
                }
                break;

            case "weight6":
                if (check == true)
                {
                    right_total_weight -= 6;
                    Debug.Log("-6");
                    Debug.Log(right_total_weight);
                    check = false;
                }
                break;

            case "weight7":
                if (check == true)
                {
                    right_total_weight -= 7;
                    Debug.Log("-7");
                    Debug.Log(right_total_weight);
                    check = false;
                }
                break;

            case "weight8":
                if (check == true)
                {
                    right_total_weight -= 8;
                    Debug.Log("-8");
                    Debug.Log(right_total_weight);
                    check = false;
                }
                break;

            case "weight9":
                if (check == true)
                {
                    right_total_weight -= 9;
                    Debug.Log("-9");
                    Debug.Log(right_total_weight);
                    check = false;
                }
                break;
        }
    }
}