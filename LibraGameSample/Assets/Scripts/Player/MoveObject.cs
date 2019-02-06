using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    bool Nowdrag = false;

    //カメラを取得
    public Camera camera_object;
    //レイキャストが当たったものを取得する入れ物
    private RaycastHit hit; 

    
    void OnMouseDrag()
    {
        if (Nowdrag == true)
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 objectPointInScreen
                    = Camera.main.WorldToScreenPoint(this.transform.position);

                Vector3 mousePointInScreen
                    = new Vector3(Input.mousePosition.x,
                                  Input.mousePosition.y,
                                  objectPointInScreen.z);

                Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointInScreen);
                mousePointInWorld.z = this.transform.position.z;
                this.transform.position = mousePointInWorld;
            }
        }
    }
    


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        //マウスのポジションを取得してRayに代入
        Ray ray = camera_object.ScreenPointToRay(Input.mousePosition);
        
        //マウスがクリックされたら
        if (Input.GetMouseButtonDown(0)) 
        { 
            //マウスのポジションからRayを投げて何かに当たったらhitに入れる
            if (Physics.Raycast(ray, out hit))  
            {   
                //オブジェクト名を取得して変数に入れる
                string objectName = hit.collider.gameObject.name;

                //オブジェクト名をコンソールに表示
                //Debug.Log(objectName); 
                Nowdrag = true;
            }
        }
        

        if (Nowdrag == true)
        {
            if (Physics.Raycast(ray, out hit))
            {
                //オブジェクト名を取得して変数に入れる
                

                //オブジェクト名をコンソールに表示
                //Debug.Log(objectName); 
                Nowdrag = true;
            }
        }
        */

        //OnMouseDrag();
    }
}
