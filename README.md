# protoype2
The Assets file has folders

Animation folder has the animation of the fish and the  fishing rod

assets folder has all the images  such as Luzzu,welcome screen,game Over and icons and 
materials.

The Prefabs folder file consist of :
Effects prefab is the  particle effect as the fish gets destroy
Instructions which  is the scene which was set as a prefab
Level  is the scene which was set as a prefab
Square.prefab are the fish 
Square1.prefab are the fish 
Square.prefab are the fish 

The Scenes folder :
Welcome
Instructions
SampleScene
GameOver 

Sound folder has the background music sound.

Scripts Folder
Fish Scripts
This class has the code for the fish

List that stores all the Fish in it
Vector2 randomPosition which gives a random position to the fish 
Boundaries  a Vector4 that stores the limit position that the fish can shown in 
numberOfClicks is a int that hold the number of click with the mousebutton
speed refers to the speed of the movement of the fish
_animator : is the code of the amitor for the animation of the transparency fish
GameObejct Effect store a particle effect gameobject
Float bDuration is the duration for the particle effect.

Methods

private void OnMouseDown()
Check the list if there is a fish,if the fish is selected will continue.
call Hide method

private void SetRandomPostion ()
has in it the float x and y which throw a position with random.Range Which has the paramiters of the Vector4 boundaries 
Random Position gives xPosion and Ypostion making a random value

private void On3Click()
increments the number of clicks
If statement check is the number of clicks is = to 3 
If yes then particle effect 
Add score
Reset Props 
Then Checks,the List and as the fish gets destroyed others will show.

Start()
The start method calls the animtior, and as the game starts the fish will be added to the list 
have random position

Update()
Transform position is now the random position moved to 

OnDestroy()
Remove all the fish 

private void Hide()
Hides the fish using and animator 

 private void Show()
Shows the fish using the animator but set as false

private void ResetProps()
Reset the number of clicks 
and  random position method

GameManager Class 
Has the methods to load and addscore checks the high score, and updates text.

Public static GameManager insteance  to acces other scripts

Start()
Loads the data

public void AddScore()
Add score by 1,
gets the highscore ,
update the text 

private void Awake()
 the instance

Ondestroy()
SaveData

Level Script
This class has the code of all the scene changes in unity.

Music Script
Awake method plays the music.

SaveData 
This class Saves the data  using json

public static void Save ()
Put the info in  a file 

public static  Scores Load()
Load the data if the file exist 
Put the information 

Scores Script
Store the data types

Timer Script has the code for the timer

text in unity
float remaningTime

Update()
This method checks the remaing timer is > 0 timer continues
if the timer reaches 0 change screen.

Line 31 Calculations with MathF for minutes and seconds.
