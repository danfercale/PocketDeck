using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragandDropTest : MonoBehaviour
{
    GameObject DraggedObj;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.transform.gameObject.tag == "Card")
                {
                    DraggedObj = hit.transform.gameObject;
                }
            }

        }

        if (Input.GetMouseButton(0))
        {
            if (DraggedObj != null)
            {
                Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                point.z = DraggedObj.transform.position.z;

                DraggedObj.transform.position = point;

            }

        }
        else if (Input.GetMouseButtonUp(0))
        {

         //   OnMouseUp();
            DraggedObj = null;
        }
    }
}
