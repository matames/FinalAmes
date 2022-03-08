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

    public static Character Instance;



    private Rigidbody2D MyRigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        Hair.sprite = sceneInfo.headSprite; //set sprites to the last saved sprite in the sceneinfo
        Face.sprite = sceneInfo.faceSprite;
        Nails.sprite = sceneInfo.nailsSprite;

        
        MyRigidBody2D = GetComponent<Rigidbody2D>();
    }

    public void SetSprites()
    {
        sceneInfo.nailsSprite = Nails.sprite;
        sceneInfo.faceSprite = Face.sprite;
        sceneInfo.headSprite = Hair.sprite; //set the sprites in sceneinfo when confirmed
    }
}
