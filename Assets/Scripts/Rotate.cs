using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;
    public float speed;

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Swipe(); 
       if(transform.rotation != target.transform.rotation){
        var step = speed * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.transform.rotation, step);
       }
    }

    void Swipe(){
        if(Input.GetMouseButtonDown(1)){
            // get the 2D pos of the first mouse click
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            // print(firstPressPos);
        }
        if(Input.GetMouseButtonUp(1)){
            //get the 2D pos of mouse
            secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            //create a vector from the first and second click pos
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
            //normalize the swipe vector???
            currentSwipe.Normalize();

            if(LeftSwipe(currentSwipe)){
            target.transform.Rotate(0,90,0, Space.World);
        }
        else if(RightSwipe(currentSwipe)){
            target.transform.Rotate(0,-90,0,Space.World);
        }
        }
        
    }

    bool LeftSwipe(Vector2 swipe){
        return currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f;
    }
    bool RightSwipe(Vector2 swipe){
        return currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f;
    } 

}
