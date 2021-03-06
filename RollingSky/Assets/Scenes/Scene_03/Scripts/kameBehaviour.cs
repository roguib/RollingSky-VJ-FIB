﻿using UnityEngine;

public class kameBehaviour : MonoBehaviour
{
    public GameObject kameCylinder;
    public Transform playerTransform;
    private Vector3 positionOffset = new Vector3(0f, 0f, 30f);
    private Vector3 scaleOffset = new Vector3(0f, 30f, 0f);
    private Vector3 originPos;
    private Vector3 originScale;

    void onAwake()
    {
      originPos = transform.position;
      originScale = kameCylinder.transform.localScale;
    }

    void Update()
    {
        float playerPosition = playerTransform.position.z * (-1f);
        float obstaclePosition = transform.position.z * (-1f);
        if(obstaclePosition - playerPosition <= 7f && kameCylinder.transform.localScale.y < 6f) {
            kameCylinder.transform.localScale += scaleOffset * Time.deltaTime;
            kameCylinder.transform.position += positionOffset * Time.deltaTime;
        }/*
        else {
          Debug.Log("!hola!");
            kameCylinder.transform.localScale = originScale;
            kameCylinder.transform.position = originPos;
        }*/
    }
}
