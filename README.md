# GDIM 33 In-Class Activities
## W1
### Activity 1
[Inspirational board](https://docs.google.com/drawings/d/1dr1KRww7tM6Abjm2_kDQVk039oA6CF7bDKHd7vt23xM/edit?usp=sharing)
1. patterns that are emerging in this are surivval open world and horror elements within this 
2. Chatted with one of my tablemates and they are interested in the surival mechanics of their game another mentioned the open world fantasy aspects
3. The LA taste in game is that they like to play a lot fo fanstasy games for example breath of the wild, open world aspects, a lot similar to my peers. 

### Activity 2
1. 2D platformer genre 
2. core mechanics are turn based, combat, health bar system, platforming
3. <img width="922" height="697" alt="unnamed" src="https://github.com/user-attachments/assets/aac1833b-30c6-4aeb-adef-c4ac64aef4b4" />



## W2
### Activity 1
1. [link to commit](https://github.com/leandrl-pixel/uci-gdim33-s25-weekly-activities-GDIM33Activities/commit/13f7986cedac19b680b45eaebd18752d8af450c1)

Continue adding additional headers below this one for future weeks and future activities.

## W3 
### Activity 1
1. <img width="936" height="715" alt="Screenshot 2026-04-15 220653" src="https://github.com/user-attachments/assets/b22ce5af-6295-4f32-80fd-622b4ef367a9" />



### Activity 2 
1. It is advantageous to save the event for the explore to dialouge state state transistions as a vairbale clickNPCEventName as a scene variable because it alows us to access it from any graph in the scene
2. using a debug log is for when the walrus is clicked was really helpful due to allowing us to see when there were indirect errors if it was firing or not 
3. For mine it is not relvant because my game wont require any use for any camera locks for my NPC and since I am doing 2D the perspective will mainly be on the player from left to right. 
4. The concept of the game state will be relevant in my game since when I am doing 2D for my movement I will need movements and powerups that will have different states of movements and different states of stats like increase in damage, speed, dash

## W4 
### Activity 1 
1. In my build right now what is playable is the basic movement from the player and the ground working as intended for going up and down, with decrative designs 
2. My playtesting goal is to add animations, different states, and perhaps a powerup 
3. The names of our playtest team are: Weida Chen, Andrew John Hsur, Gael Parras, Lillian Su 
4. I noticed for my playtest from someone playing my game they knew the keys were WASD and they used either the W key or the space bar in order to jump into the air, at the same time they also climbed up the platforms. There overall experince was that they knew the movement keys however there is no directionality with the game, just a ground zone with some basic movement. 

### Activity 2 
1. Yes, a writer could add more dialogue without writing code. The system uses ScriptableObjects for each dialogue node, once you got everything set up then the writer can make more new nodes type in different dialouges. They dont really need to touch the scripts of code unless they want t change how the system overall works. 
2. I am thinking that ther eis not really a hard limit for the dialouge node but the main limtation might be the UI, the user interface, especially with the nodes being too vast that it may end up getting difficult and complex making someone lost if they work on it for big amount of time. 
3. The purpose of regenerate nodes button is so that visual scripting is updated and properly in unity, for example if someone is making a custom event its not going to appear yet in the nodes while there working on it so they have to regnerate it so that it appears its kinda like the github where we push our commits to update our main branch in this case the regenerating nodes is updating our branch for any changes. 

## W5 
### Activity 1 

#### Step 1: Create a tilemap  
1. this is done by getting your assests and making a scene 
2. slice sprite into different tiles in the pallete
3. add the tile map assests into the tile pallete 

#### Step 2: Make a tilemap trap in the scene & script that influences 
1. add normal tiles into this scene to make into the ground 
2. Add the tiles that you want to make them special which in this case these tiles are going to be traps. Add sprite tilemap that looks like it will harm the player, or some type of color indicator. 
3. create both a trap script and health script, the trap script will influence the players current health and if they fall into the ground there HP will decrease, influencing the players HP (health). This will be done using the oncollision2D method. When this method runs it will take away a certain amount of health. add a debug log or a ui text that updates the score of the players health.

### Activty 2 
1. Made the tilemap assets then added then into the ground for the scene. I added the traps which all damage the player a bit, I made a tilemap for the traps and are categorize as that and this tilemap specifically influences the players health. 2 scripts where created in this which are for the players health and the other is for trap collisions which will be used for future implementation. 

## W6 
### Activity 1 
1. Implemented new animations states via visual scripting with a state graph. kept color changes. WASD controls, blue means inactive, red means active, these colors are for indicating if the different states are working via visual scripting. 
2. [Link to itch page](https://leandrl.itch.io/playtest-v2)
3. Animations are smooth in the playtest however some bugs noted in the experince where the animations states being lagged, so I need to figure out if I did a has exit time in one of my sections. Also another bug noted in my platform was on the edge on the player is grounded and there sort of hovering or floating in the air. I need something to do, like make things interactable with the player my next steps to do are implementing challenges to the player to make an overall interactable experince   
4. In other words, my goal is to resolve bugs in my playtest and make an overall interactable experince for my player  

### Activity 2 
1. It results in a dark and less saturated color than the input colors because the RGB values are stored as either 0.0 or 1 values. For example when you multiply both numbers in the range its going to lead to a more smaller input. Like two decimals multiplying and since each RGB channel gets low the resulting color becomes darker.it can also look less satuarted due to the strong colors channels being reduced. 
2. Multiplying the aplpha values usually makes the result more translucent as aplha is also stored as a 0 to 1 value where 0 means that its fully  transparent when its just zero making ti completely invisible, and then 1 when its fully opaque. Multiplying the two values usually gives a smaller one so the result is going to be more transparent and more translucent thant the orignal value. 
3. The shader gets UV values from the mesh as the UV coordinates are stored on the model vertex data. Each vertex may have the UV coordinates that show in the shader which part of the texture maps onto the mesh. Unity uses the UV and passes it into the shader and the sample texture of 2d node uses it to sample. 
4. It sounds really cool that were able to manipulate colors with math and im exicted to see what else will do, especially vfx. 

## W7 
### Activity 1 
1. This data comes from the mesh first, and mesh vertices contain data other than just a position. vertex data also includes UVs and surface normals. 
2. our blend of all of the colors of V1, V2, and V3 dpending on the fragment sdistance from each distance. Data is interpolated blended between the 3 vertices that make up a triangle. 
3. I think the reason why its less detailed is because we have not done anything to it but just input the shaders into the shiba. As for the vector color I imagine its useful because it allows you to assign colors directly to the vertices of the mesh which allow for effects like graidents or color based visualzations 
4. a surface normal is a 3d vector descirbing the direction a surface is point in, normals are prependicular to the surface there sticking out of. But as for the shibas mesh vertex normals nothing seems wrong yet 
5. One piece of vertex data or any kind of data that I can imagine testing with a debug shader...
6. There is an error in the lighting step for 4 on the back of the shiba because... 
7. I think we set the blend mode to additive for the fire effect in step 5 because... 