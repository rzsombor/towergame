var crosshairTexture : Texture2D;
var crosshairScaleFactor : float = 1.0;

private var position : Rect;
 
function Start()
{
    position = Rect((Screen.width - GetCrosshairWidth()) / 2, (Screen.height - 
        GetCrosshairHeight()) /2, GetCrosshairWidth(), GetCrosshairHeight());
}
 
function OnGUI()
{
    GUI.DrawTexture(position, crosshairTexture);
    
}

function GetCrosshairWidth(){
	return crosshairTexture.width * crosshairScaleFactor;
}

function GetCrosshairHeight(){
	return crosshairTexture.height * crosshairScaleFactor;
}