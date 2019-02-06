using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveSanple : MonoBehaviour
{
    bool NowDrag = false;

    [SerializeField]
    public Camera camera_object;

    private RaycastHit hit;
    private Vector3 moveTo;
    private bool beRay = false;

    Camera camera;

    void Start()
    {
        camera = Camera.main;   
    }
    /*
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayCheck();
        }

        if (beRay)
        {
            MovePoisition();
        }

        if (Input.GetMouseButtonUp(0))
        {
            beRay = false;
        }

        








        //マウスがクリックされたら
        if (NowDrag == true)
        {
            //マウスのポジションを取得してRayに代入
            Ray ray = camera_object.ScreenPointToRay(Input.mousePosition);

            //マウスのポジションからRayを投げて何かに当たったらhitに入れる
            if (Physics.Raycast(ray, out hit))
            {
                //オブジェクト名を取得して変数に入れる
                string objectName = hit.collider.gameObject.name;
                switch (objectName)
                {
                    case "Left_koteigu":
                        ;
                        break;

                    case "Right_koteigu":
                        ;
                        break;
                }
            }
        }
    }


    /*
    public void OnDrag()
    {
        Vector3 TapPos = target.Position;
        TapPos.z = 10f;
        transform.position = Camera.main.ScreenToWorldPoint(TapPos);
    }
    */
    /*
    private void RayCheck()
    {
        Ray ray = new Ray();
        RaycastHit hit = new RaycastHit();
        ray 
    }
    */
}