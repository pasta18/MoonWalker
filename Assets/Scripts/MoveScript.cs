using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour
{
    public void Move(float xValue)
    {
        transform.Translate(new Vector2(xValue, 0) * Time.deltaTime);
    }
}
