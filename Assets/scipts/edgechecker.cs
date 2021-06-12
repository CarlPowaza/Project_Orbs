using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edgechecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    { 
            PolygonCollider2D poly = GetComponent<PolygonCollider2D>();
            Vector2[] points = poly.points;
          //  points[points.length()]= points[0];
            EdgeCollider2D edge = gameObject.AddComponent<EdgeCollider2D>();
            edge.points = points;
            Destroy(poly); 
    }

 
}
