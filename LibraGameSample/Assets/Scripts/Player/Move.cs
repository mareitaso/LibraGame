using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    UIDirector choice_Weight;

    GameObject A;

    GameObject HitSara;


    //カメラを取得
    [SerializeField]
    public Camera camera_object;
    //レイキャストが当たったものを取得する入れ物
    private RaycastHit hit;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AAA();
        weightMove();
    }

    void AAA()
    {
        if (choice_Weight == null)
        {
            //choice_Weight.transform.Translate(0, 0, 0);
            //Debug.Log(choice_Weight);
        }
    }

    private void weightMove()
    {
        //マウスのポジションを取得してRayに代入
        Ray ray = camera_object.ScreenPointToRay(Input.mousePosition);

        //マウスのポジションからRayを投げて何かに当たったらhitに入れる
        if (Physics.Raycast(ray, out hit))
        {



            //オブジェクト名を取得して変数に入れる
            HitSara = hit.collider.gameObject;
            switch (HitSara.tag)
            {
                case "Sara1":

                    break;

                case "Sara2":

                    break;

                case "Sara3":

                    Debug.Log("a");
                    break;

                case "Sara4":

                    break;

                case "Sara5":

                    break;

                case "Sara6":

                    break;
            }
        }
    }
}