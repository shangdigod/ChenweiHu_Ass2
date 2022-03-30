using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageManager : MonoBehaviour
{
    public GameObject image;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value - 0.1f;
        image.transform.position = new Vector3(value, 2, 1);
    }

    public void RotateLeft()
    {
        image.transform.Rotate(20f, 10f, 10f);
    }

    public void Grow()
    {
        image.transform.localScale = image.transform.localScale + sizeChange;
    }

    public void ResetImage()
    {
        image.transform.position = new Vector3(0, 2, 1);
        image.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        image.transform.localScale = new Vector3(1, 1, 1);
    }
}
