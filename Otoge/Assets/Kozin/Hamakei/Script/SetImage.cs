using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetImage : MonoBehaviour
{

    //public
    public float speed = 1.0f;

    //private
    private Image image;
    private float time;

    private enum ObjType
    {
        IMAGE
    };

    private ObjType thisObjType = ObjType.IMAGE;

    void Start()
    {
        //アタッチしてるオブジェクトを判別
        if (this.gameObject.GetComponent<Image>())
        {

            thisObjType = ObjType.IMAGE;
            image = this.gameObject.GetComponent<Image>();

        }

    }

    void Update()
    {
        //オブジェクトのAlpha値を更新
        if (thisObjType == ObjType.IMAGE)
        {
            image.color = GetAlphaColor(image.color);
        }
    }

    //Alpha値を更新してColorを返す
    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;
        return color;
    }
}