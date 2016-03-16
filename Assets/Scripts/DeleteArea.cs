using UnityEngine;
using System.Collections;

public class DeleteArea : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D col)
    {
        //自機以外は範囲外で消滅
        if(col.gameObject.tag == "Player") { }
        else
        {
            Destroy(col.gameObject);
        }
    }
}
