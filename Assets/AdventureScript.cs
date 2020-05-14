using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureScript : MonoBehaviour
{
    public Vector3 mousePos;

    public Camera mainCamera;

    public Vector3 mousePosWorld;
    
    public Vector2 mousePosWorld2D;
    
    public RaycastHit2D hit;

    void Start()
    {
        
    }

    void Update()
    {
        if ( Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            mousePosWorld = mainCamera.ScreenToWorldPoint(mousePos);
            mousePosWorld2D = new Vector2(mousePosWorld.x, mousePosWorld.y);
            hit = Physics2D.Raycast(mousePosWorld2D, Vector2.zero);

            if (hit.collider != null)
            {
                print("Name: " + hit.collider.gameObject.name);
            }
            else
            {
                print("Kein Collider");
            }
        }
    }
}
