---
permalink: /objects/obj_room_of_haha_screen
---
# Room of Haha Screen  
## obj_room_of_haha_screen  
&nbsp;  
# Description  
The screen shown in Squid's Presentation Room (RoomOfHaha).  
This screen changes its appearance based on the images you put in this directory:
`[WYS Steam Install Location]/Squids Secret Presentation/`  
These images will then be played in game as a "presentation" and allow you to make Squid react to whatever you want with the same script. 
The images must be titled in the following format:  
`Slide-[N]` Where N is the index the slide appears in the presentation loop.
The start at `Slide-1` and only go up to `Slide-11`.  
&nbsp;  
# Sprite  
### spr_screen_size_test  
&nbsp;  
# General Values  
Visible = `true`  
Solid = `false`  
Persistent = `false`  
Parent = `[none]`  
Texture Mask ID = `[none]`  
Uses Physics = `false`  
Is Sensor = `false`  
Collision Shape = `Box`  
&nbsp;
# Physics Values
### The physics values in this object are meaningless because `Uses Physics` is set to false. (See General Values)
Density = `0.5`  
Restitution = `0.1`  
Group = `1`  
Linear Damping = `0.1`  
Angular Damping = `0.1`  
Friction = `0.2`  
Is Awake = `true`  
Is Kinematic = `false`  
Physics Shape Vertices = `[]`  
&nbsp;
# Events
### Create  
gml_Object_obj_room_of_haha_screen_Create_0  
### Step
gml_Object_obj_room_of_haha_screen_Step_0  
### Draw
gml_Object_obj_room_of_haha_screen_Draw_0  
### PreCreate
gml_Object_obj_room_of_haha_screen_PreCreate_0  

  
