using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linker : MonoBehaviour{

    public Color c1 = Color.black;
    public Color c2 = Color.white;
    public int lengthOfLineRenderer = 5;

    public Transform orb1;
    public Transform orb2;




    // Start is called before the first frame update
    void Start()
    {
          LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
         lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
         lineRenderer.widthMultiplier = 0.2f;
         lineRenderer.positionCount = lengthOfLineRenderer;

      
       float alpha = 1.0f;
       Gradient gradient = new Gradient();
         gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(c1, 0.0f), new GradientColorKey(c2, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
        );
        lineRenderer.colorGradient = gradient; 
    }

    // Update is called once per frame
    void Update()
    {
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        var t = Time.time;
      var points = new Vector3[lengthOfLineRenderer];

        points[0]=orb1.position;
        points[lengthOfLineRenderer-1]=new Vector3(orb2.position.x,orb2.position.y,orb2.position.z);
           for (int i = 1; i < lengthOfLineRenderer-1; i++)
        {
            points[i] =new Vector3(orb2.position.x,orb2.position.y,orb2.position.z);
        }
        lineRenderer.SetPositions(points);





      //    lineRenderer.SetPosition(1,orb1.position);
      //   lineRenderer.SetPosition(0,new Vector3(orb2.position.x,orb2.position.y,orb2.position.z));
        //Debug.Log(orb2.position.x);
        
    }
}
