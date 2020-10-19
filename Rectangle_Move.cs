﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle_Move : MonoBehaviour{

	private Vector3 target = new Vector3(0, 0, 0);
    private Vector3 back = new Vector3(0, 0, 0);
	private int n;
	Vector3 temp;

	void Start(){
		n = Random.Range(1, 3);
	}

    void Update(){
    	if (Globals.is_rectangle == true){
    		if (n == 1){
    			transform.position = Vector3.MoveTowards(transform.position, target, 1);
    			transform.Rotate(Vector3.forward * Time.deltaTime * 25);
                temp = transform.localScale;
                temp.x -= Time.deltaTime * Globals.x_rectangle;
                temp.y -= Time.deltaTime * Globals.x_rectangle;
                transform.localScale = temp;  
                if (temp.x < 0){
                    transform.position = Vector3.MoveTowards(transform.position, back, 1);
                    temp = transform.localScale;
                    temp.x = 3;
                    temp.y = 3;
                    transform.localScale = temp; 
                    Globals.is_rectangle = false;   
                    Globals.is_triangle = true;                 
                }  	 	    			
    		}
    		else{
    			transform.position = Vector3.MoveTowards(transform.position, target, 1);
    			transform.Rotate(-Vector3.forward * Time.deltaTime * 25);   
                temp = transform.localScale;
                temp.x -= Time.deltaTime * Globals.x_rectangle;
                temp.y -= Time.deltaTime * Globals.x_rectangle;
                transform.localScale = temp;  
                if (temp.x < 0){
                    transform.position = Vector3.MoveTowards(transform.position, back, 1);
                    temp = transform.localScale;
                    temp.x = 3;
                    temp.y = 3;
                    transform.localScale = temp; 
                    Globals.is_rectangle = false; 
                    Globals.is_triangle = true;                   
                }  	                 	  			
    		}
    	}
    }
}
