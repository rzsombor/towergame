
var xSpeed = 250.0;
var ySpeed = 250.0;

var xMinLimit = -20;
var xMaxLimit = 20;

var yMinLimit = -20;
var yMaxLimit = 20;

private var x = 0.0;
private var y = 0.0;

function Start () {
    var angles = transform.eulerAngles;
    x = angles.y;
    y = angles.x;
}

function LateUpdate () {
    x += Input.GetAxis("Mouse X") * xSpeed * 0.02;
    y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02;
 		
 	x = ClampAngle(x, xMinLimit, xMaxLimit);
 	y = ClampAngle(y, yMinLimit, yMaxLimit);
 		       
    var rotation = Quaternion.Euler(y, x, 0);
        
    transform.rotation = rotation;
}

static function ClampAngle (angle : float, min : float, max : float) {
	if (angle < -360)
		angle += 360;
	if (angle > 360)
		angle -= 360;
	return Mathf.Clamp (angle, min, max);
}