using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LibraControl : MonoBehaviour
{
    [HideInInspector]
    public bool answer = false;

    [SerializeField]
    GameObject ude;

    [SerializeField]
    GameObject director;

    //ステージにあるおもりの合計数
    [SerializeField]
    private int stageTotalWeight;

    [SerializeField]
    GameObject Rsara;

    [SerializeField]
    GameObject Lsara;
    

    [HideInInspector]
    public bool RightSaraHeavyMoveCheck = true;
    [HideInInspector]
    public bool RightSaraLightMoveCheck = true;
    //private bool

    void Start()
    {

    }

    void Update()
    {
        /*
        switch (gameObject.tag)
        {
            case "Sara3":
                
                break;

                /*
                //タッチされた皿の上にオブジェクトの移動をする
                if (choiceObject == true&&Input.GetMouseButton(0))
                {
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                    {
                        float x = Mathf.RoundToInt(hit.point.x);
                        float z = Mathf.RoundToInt(hit.point.z);
                        libra.transform.position = new Vector3(x, hit.transform.position.y + 1.5f, z);
                    }
                }
                */

        /*

        //Debug.Log(righttotalweight);

        if (righttotalweight == lefttotalweight)
        {
            //クリアした後の処理
            //丸を出して、リザルト画面へ
        }

    }



    */
    }
    /*
    private void unko()
    {
 
        if (right_total_weight == left_total_weight)
        {
            this.director.GetComponent<LibraMove>().RightSaraLightMove();
        }
        else if (right_total_weight == left_total_weight)
        {
            this.director.GetComponent<LibraMove>().RightSaraHeavyMove();
        }
        else if (right_total_weight == left_total_weight)
        {
            this.director.GetComponent<LibraMove>().Even();
        }
    }
    */
}
