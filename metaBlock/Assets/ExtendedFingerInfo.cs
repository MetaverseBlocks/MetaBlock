using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendedFingerInfo : MonoBehaviour
{
    public static bool fistGesture = false;  //주먹쥔 모션인지 아닌지 
    public static bool clickGuesture = false;   //클릭하는 검지를 펼친 모션인지 아닌지

    public void fistMotionLeft()
    {
        fistGesture = true;
        if (CollisionDetector.collsionStay)
            Debug.Log("left hand grabbing the block");//Debug.Log("왼손 블록 잡음");
        //Debug.Log("주먹쥠");
    }

    public void notFistMotionLeft()
    {
        fistGesture = false;
        if (CollisionDetector.collsionStay)  //방금까지 블록과 충돌되었는데 주먹을 펼친다 -> 블록을 놓음
            Debug.Log("left hand put down the block"); //Debug.Log("왼손 블록 놓음");
       // Debug.Log("주먹안쥠");
    }

    public void fistMotionRight()
    {
        fistGesture = true;
        if (CollisionDetector.collsionStay)
            Debug.Log("right hand grabbing the block"); //Debug.Log("오른손 블록 잡음");
        //Debug.Log("주먹쥠");
    }

    public void notFistMotionRight()
    {
        fistGesture = false;
        if (CollisionDetector.collsionStay)  //방금까지 블록과 충돌되었는데 주먹을 펼친다 -> 블록을 놓음
            Debug.Log("right hand put down the block");//Debug.Log("오른손 블록 놓음");
        // Debug.Log("주먹안쥠");
    }

    public void clickMotion()
    {
        clickGuesture = true;
    }

    public void notClickMotion()
    {
        clickGuesture = false;
    }
}
