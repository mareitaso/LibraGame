using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDirector : MonoBehaviour
{
    [SerializeField]
    GameObject mouse;

    public GameObject choice_Weight = null;

    [SerializeField]
    GameObject weight01;
    [SerializeField]
    GameObject weight02;
    [SerializeField]
    GameObject weight03;
    [SerializeField]
    GameObject weight04;
    [SerializeField]
    GameObject weight05;
    [SerializeField]
    GameObject weight06;
    [SerializeField]
    GameObject weight07;
    [SerializeField]
    GameObject weight08;
    [SerializeField]
    GameObject weight09;



    //カメラを取得
    [SerializeField]
    public Camera camera_object;
    //レイキャストが当たったものを取得する入れ物
    private RaycastHit hit;


    // Use this for initialization
    void Start()
    {
        AllSetActive();
    }

    // Update is called once per frame
    void Update()
    {
        //マウスがクリックされたら
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("joystick button 0"))
        {
            UIChange();
        }
    }

    private void UIChange()
    {
        //マウスのポジションを取得してRayに代入
        Ray subray = new Ray(mouse.transform.position, mouse.transform.position);
        Ray ray = camera_object.ScreenPointToRay(Input.mousePosition);

        //マウスのポジションからRayを投げて何かに当たったらhitに入れる
        if (Physics.Raycast(ray, out hit) || Physics.Raycast(subray, out hit))
        {
            choice_Weight = hit.collider.gameObject;
            Debug.Log(choice_Weight);

            //オブジェクト名を取得して変数に入れる
            string objectName = hit.collider.gameObject.name;
            switch (objectName)
            {
                case "weight01":
                    AllSetActive();
                    weight01.SetActive(true);
                    break;

                case "weight02":
                    AllSetActive();
                    weight02.SetActive(true);
                    break;

                case "weight03":
                    AllSetActive();
                    weight03.SetActive(true);
                    break;

                case "weight04":
                    AllSetActive();
                    weight04.SetActive(true);
                    break;

                case "weight05":
                    AllSetActive();
                    weight05.SetActive(true);
                    break;

                case "weight06":
                    AllSetActive();
                    weight06.SetActive(true);
                    break;

                case "weight07":
                    AllSetActive();
                    weight07.SetActive(true);
                    break;

                case "weight08":
                    AllSetActive();
                    weight08.SetActive(true);
                    break;

                case "weight09":
                    AllSetActive();
                    weight09.SetActive(true);
                    break;
            }
        }
    }


    private void AllSetActive()
    {
        weight01.SetActive(false);
        weight02.SetActive(false);
        weight03.SetActive(false);
        weight04.SetActive(false);
        weight05.SetActive(false);
        weight06.SetActive(false);
        weight07.SetActive(false);
        weight08.SetActive(false);
        weight09.SetActive(false);
    }

}
