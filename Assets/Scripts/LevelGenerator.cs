using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour{
   

   public GameObject Camera; 

    public GameObject Empty;
    public GameObject OutsideCorner;
    public GameObject OutsideWall;
    public GameObject InsideCorner;
    public GameObject InsideWall;
    public GameObject SmallPellet;
    public GameObject BigPellet;
    public GameObject TJunction;

    // Start is called before the first frame update
    void Start()
    {

    

        
        int[,] levelMap =
 {
 {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
 {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
 {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
 {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
 {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
 {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
 {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
 {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
 {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
 {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
 {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
 }; 
  
  
  Instantiate(OutsideCorner, new Vector3(-7.0F, -1, 0), Quaternion.identity);
        for (int i = 0; i < 12; i++) {
        Instantiate(OutsideWall, new Vector3(i + 0F, 0, 0), Quaternion.identity);
        } 
        Instantiate(TJunction, new Vector3(23.5F, -3, 0), Quaternion.identity);
        for (int i = 0; i < 12; i++) {
         Instantiate(SmallPellet, new Vector3(i + -6F, -3, 0), Quaternion.identity);
         
        } 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
