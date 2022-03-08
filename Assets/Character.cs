using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour


{
    [SerializeField]
    private SpriteRenderer Hair;
    [SerializeField]
    private SpriteRenderer Face;
    [SerializeField]
    private SpriteRenderer Nails;

    [SerializeField]
    private SceneInfo sceneInfo;


    private Rigidbody2D MyRigidBody2D;

    void Start()
    {
        Hair.sprite = sceneInfo.headSprite; //set sprites to the last saved sprite in the sceneinfo
        Face.sprite = sceneInfo.faceSprite;
        Nails.sprite = sceneInfo.nailsSprite;
    }

    public void SetSprites()
    {
        sceneInfo.nailsSprite = Nails.sprite; //set the sprites in sceneinfo when confirmed
        sceneInfo.faceSprite = Face.sprite;
        sceneInfo.headSprite = Hair.sprite; 
    }
}
