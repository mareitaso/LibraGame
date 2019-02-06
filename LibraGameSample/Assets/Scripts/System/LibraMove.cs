using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class LibraMove : MonoBehaviour
{
    private int rotate = 2;
    private float MoveSara = 0.1f;

    [SerializeField]
    GameObject ude;
    [SerializeField]
    GameObject RightKoteigu;
    [SerializeField]
    GameObject LeftKoteigu;

    // Use this for initialization
    void Start()
    {
        Vector3 Rtmp = RightKoteigu.transform.position;
        Vector3 Ltmp = LeftKoteigu.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //腕の回転
    public void OnUdeMove()
    {
        //rotateにかける数はif文で皿に乗っている分銅の重さで決める
        //右が重い時はプラスに、左が重い時はマイナスに
        rotate = rotate * -1;
        ude.transform.DORotate(new Vector3(0f, 0f, rotate), 1.0f);
    }

    public void Even()
    {

    }

    //右の皿の重い時の動き、左の皿の軽い時の動き
    public void RightSaraHeavyMove()
    {
        Vector3 Rtmp = RightKoteigu.transform.position;
        RightKoteigu.transform.DOMove(new Vector3(Rtmp.x, Rtmp.y + MoveSara, Rtmp.z), 1.0f);
        Vector3 Ltmp = LeftKoteigu.transform.position;
        LeftKoteigu.transform.DOMove(new Vector3(Ltmp.x, Ltmp.y - MoveSara, Ltmp.z), 1.0f);
    }



    //右の皿の軽い時の動き、左の皿の重い時の動き
    public void RightSaraLightMove()
    {
        Vector3 Rtmp = RightKoteigu.transform.position;
        RightKoteigu.transform.DOMove(new Vector3(Rtmp.x, Rtmp.y - MoveSara, Rtmp.z), 1.0f);
        Vector3 Ltmp = LeftKoteigu.transform.position;
        LeftKoteigu.transform.DOMove(new Vector3(Ltmp.x, Ltmp.y + MoveSara, Ltmp.z), 1.0f);
    }



}
