using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    // this is list of all fish in th egame
    //this is a list of all th efish which are found in the game
    private static List<Fish> allFish = new List<Fish>();

    private Vector2 randomPosition;
    [SerializeField] private Vector4 boundaries;

     public  int numberOfClicks;

     public float speed = 10f;
     private Animator _animator;
    
    
    //we need to calculate the number of clicks 
    private void OnMouseDown()
    {
        
        //check if the fish is th fish 
        //if this is the selcetd fish continue
        //else delete all the other fish 
        foreach (Fish fish in allFish)
        {
            if (fish == this)
            {
             
                continue;
            }
            //hide all fish
            fish.Hide();
        }

        SetRandomPosition();

        On3Click();
        //Destroy(gameObject);
        Debug.Log("When mouse down on  click the fish is removed");
    }

    private void SetRandomPosition()
    {
        float x = Random.Range(boundaries.x, boundaries.y);
        float y = Random.Range(boundaries.z, boundaries.w);
        
        //random posigion is give xPosition and yPosition,making it random value
        randomPosition = new Vector2(x, y);
    }

    private void On3Click()
    {
        numberOfClicks++;
        
        
        //in this method when the user clicks 3 times the game will get destoryed
        if (numberOfClicks >= 3)
        {
            Debug.Log("The shape is clicked 3 times");
            GameManager.instance.AddScore();
            ResetProps();
            
            //din se tahdem bil kontra 
            // se jicekja kollox u kif il fish titlaq
            //wara 3 clicks se jigu jidru l-ohrajn
            foreach (Fish fish in allFish)
            {
                if (fish == this)
                {
                    
                    continue;
                }
            
                fish.ResetProps();
                fish.Show();
            }
        }
        
        //increment score 
       
        
    }

    private void Start()
    {

        _animator = GetComponent<Animator>();
        
        //kif se tibda il game se jigu added to the list 
        allFish.Add(this);
        randomPosition = transform.position;
       

    }

    private void Update()
    {
        //ransom position is now the random position moved to it
        transform.position = Vector3.MoveTowards(transform.position, randomPosition, speed * Time.deltaTime);
    }

    //din se jitiliqu il fish 
    private void OnDestroy()
    {
        allFish.Remove(this);
    }

    //din se jitilqu l-extra fish  kif tiklikja 1 
    private void Hide()
    {
        _animator.SetBool("Hidden", true);
    }
    
    //show the other fish 
    //we need to create more fish from unity 
    private void Show()
    {
        _animator.SetBool("Hidden", false);
    }

    private void ResetProps()
    {
        numberOfClicks = 0;
        SetRandomPosition();
        transform.position = randomPosition;
       
    }
}
