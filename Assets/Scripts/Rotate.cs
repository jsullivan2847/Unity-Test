using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;
    Vector3 prevMousePos;
    Vector3 mouseDelta;
    public float speed;
    
    bool trackpad;

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Swipe(); 
       Drag();
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
            Debug.Log("Left Swipe");
        }
        else if(RightSwipe(currentSwipe)){
            target.transform.Rotate(0,-90,0,Space.World);
            Debug.Log("Right Swipe");
        }
        else if(UpLeftSwipe(currentSwipe)){
            target.transform.Rotate(90,0,0, Space.World);
            Debug.Log("UpLeft Swipe");
        }
        else if(UpRightSwipe(currentSwipe)){
            target.transform.Rotate(0,0,-90, Space.World);
            Debug.Log("Up Right Swipe");
        }
        else if(DownLeftSwipe(currentSwipe)){
            target.transform.Rotate(0,0,90,Space.World);
            Debug.Log("DownLeft Swipe");
        }
        else if(DownRightSwipe(currentSwipe)){
            target.transform.Rotate(-90,0,0, Space.World);
            Debug.Log("DownRight Swipe");
        }
        }
        
    }

    void Drag(){
        //while mouse is held down the cube can be moved around it's central axis to provide visual feedback
       
        if(Input.GetMouseButton(1)){
                mouseDelta = Input.mousePosition - prevMousePos;
        mouseDelta *= 0.5f; //reduces rotation speed;
        transform.rotation = Quaternion.Euler(mouseDelta.y, -mouseDelta.x, 0) * transform.rotation;
        } 
        else{
            if(transform.rotation != target.transform.rotation){
        var step = speed * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.transform.rotation, step);
       }
        }
        prevMousePos = Input.mousePosition;
    }

    bool LeftSwipe(Vector2 swipe){
        return currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f;
    }
    bool RightSwipe(Vector2 swipe){
        return currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f;
    } 
    bool UpLeftSwipe(Vector2 swipe){
        return currentSwipe.y > 0 && currentSwipe.x < 0f;
    }
    bool UpRightSwipe(Vector2 swipe){
        return currentSwipe.y > 0 && currentSwipe.x > 0f;
    }
    bool DownRightSwipe(Vector2 swipe){
        return currentSwipe.y < 0f && currentSwipe.x < 0f;
    }
    bool DownLeftSwipe(Vector2 swipe){
        return currentSwipe.y < 0f && currentSwipe.x > 0f;
    }
}
