using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeImageView : MonoBehaviour {

	[SerializeField]
	private float _maxWidth = 1500;

	public float MaxCount = 0;

	private RectTransform _rectTransform;

    [SerializeField]
    public TimerController countTime;

    // Use this for initialization
    void Start ()
    {
		_rectTransform = GetComponent<RectTransform>();
		Initialize();
	}
	
	public void SizeChange(float count)
	{
		var size = _rectTransform.sizeDelta;
		size.x = (count / MaxCount) * _maxWidth;
		_rectTransform.sizeDelta = size;
	}

	public void Initialize()
	{
		var size = _rectTransform.sizeDelta;
		size.x = _maxWidth;
		_rectTransform.sizeDelta = size;
	}
}
