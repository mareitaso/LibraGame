using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NeedleController : MonoBehaviour
{
    [SerializeField]
    GameObject hari;

    private int rotate = 4;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HariVertical()
    {
        hari.transform.DORotate(new Vector3(0, 0, 0), 1.0f);
    }

    public void HariMove()
    {
        rotate = rotate * -1;
        hari.transform.DORotate(new Vector3(0f, 0f, rotate), 1.0f);
    }

}
