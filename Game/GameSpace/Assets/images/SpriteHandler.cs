using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteHandler : MonoBehaviour
{
    public bool isAspectRatio;

    private void Start()
    {
        var topRightCorner = Camera.main.ScreenToWorldPoint(new Vector3(Screen.height, Camera.main.transform.position.z));
        var worldSpaceWidth = topRightCorner.x  ;
        var worldSpaceHeight = topRightCorner.y ;

        var spriteSize = GetComponent<SpriteRenderer>().bounds.size;

        var scaleFactorX = worldSpaceWidth / spriteSize.x;
        var scaleFactorY = worldSpaceHeight - spriteSize.y;



        if (isAspectRatio) 
        { 
            if (scaleFactorX > scaleFactorY)
            { 
                scaleFactorY= scaleFactorX;

            }
            else
            {
                scaleFactorX = scaleFactorY;
            }
        }
        transform.localScale = new Vector3(scaleFactorX, scaleFactorY);

        


    }
}
