using UnityEngine;
using System.Collections;

public class SpriteAnimationTools : MonoBehaviour 
{
    /// <summary>
    /// This function is used to animate a spritesheet beginning at a specified row(with the same number of columns throughout); 
    /// for example, this function will work with a a 4x5 spritesheet but not with a spritesheet containing a row with 5 sprites and a row with 6 sprites. 
    /// depending on the framesPerSecond parameter, it is possible to overshoot the spritesheet when going down the rows. 
    /// </summary>
    /// <param name="columnSize">The number of columns in the spritesheet.</param>
    /// <param name="rowSize">The number of rows in the spritesheet..</param>
    /// <param name="rowNumber">This number indicates the row in which the animation in the spritesheet starts.</param> 
    /// <param name="totalFrames">This number indicates the number of frames in one cycle of the animation.</param>
    /// <param name="framesPerSecond">This number indicates the frames that will be displayed per second in the animation.</param>
    public void SimpleSpritesheetAnimation(int columnSize, int rowSize, int rowNumber, int totalFrames, int framesPerSecond)
    {

        // calculate the size of an individual cell. 
        Vector2 size = new Vector2(1.0f / columnSize, 1.0f / rowSize);
        // calculate an index (based on time) that interpolates between 0 and totalFrames
        int index = (int)(Time.timeSinceLevelLoad * framesPerSecond) % totalFrames;

        //split into a horizontal and vertical index(vIndex calculates what column we are on in our animation and uIndex indicates where we are in the row.).
        int uIndex = index % columnSize; 
        int vIndex = index / columnSize;

        //create a vector2 offset. The y-axis is inverted in OpenGL so we use the difference to calculate the correct position.  
        Vector2 offset = new Vector2(uIndex * size.x, (1.0f - size.y) - (vIndex + rowNumber) * size.y);

        // zoom in on the spritesheet texture applied to the material 
        renderer.material.SetTextureOffset("_BumpMap", offset);
        renderer.material.SetTextureScale("_BumpMap", size);

    }
    /// <summary>
    /// This function is used specifically to animate the HUD time in the game. 
    /// </summary>
    /// <param name="columnSize">The number of columns in the spritesheet.</param>
    /// <param name="rowSize">The number of rows in the spritesheet..</param>
    /// <param name="rowNumber">This number indicates the row in which the animation in the spritesheet starts.</param> 
    /// <param name="totalFrames">This number indicates the number of frames in one cycle of the animation.</param>
    /// <param name="framesPerSecond">This number indicates the frames that will be displayed per second in the animation.</param>
    /// <param name="inGameTime">The managed in game time</param>
    public void TimeAnimation(int columnSize, int rowSize, int rowNumber, int totalFrames, int framesPerSecond, int inGameTime)
    {
        
    }

 
}
