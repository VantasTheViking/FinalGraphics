# FinalGraphics

Texture Sources:
https://3dtextures.me/2021/09/10/wallpaper-art-deco-001/
https://3dtextures.me/2016/05/05/lava-002/

Controls:
WASD - player\
JK - light\
QE - world light\
Num 1 - lava flow toggle\

Scene Explanation:
Mikey (i think thats orange turtles name) can move WASD since i assume this game is a beatem up 2D game. Mikey also has a light to make him stand out more in the scene. The world light can move using QE to allow for testing and observation on the wall's normal map application. Roomlight can be moved via JK buttons to test/observe bloom.

Wallpaper Explanation:
Pseudocode

Input color var, main tex, normal map\
Get the uv coordinates set one for maintex and normalmap\
Apply main tex using uv coordinates to the object's albedo\
Modify texture colour using color variable\
Apply normal map using uv coordinates to the object's normals\
increase(multiply) normals to make it stand out.\
Added modification that allows changing of texture color to be more faithful to the orange wall background in the game.

Water Explanation:
PseudoCode

Input Time and Speed and emission color\
make a sine wave based on the each vertex' x value\
modify vertex' y value using the sine wave\
modify normal according to the sine wave\
apply textures like in wallpaper (but without the normal map)\
modify the uv values based on the time\
apply additional texture on top of the base texture and modify its uv values based on time\
the speed of the uv value modification is based on if the flow is set to fast or not\
add emission (black for slow, red for fast)\
Added modifications to allow for differences between fast and slow. This makes them feel a bit more distict from each other aside from
the top texture moving faster and higher freq of the wave.


Bloom Explanation:
Use box filter to modify each pixel.\
Box filter grabs the surrounding pixels and base the current pixel's value on that\
Do this only to pixels above a certain threshold\
Repeat this based on the amount of inputted iterations.\
Modified threshold calculation to be simpler for easier adjustments.
