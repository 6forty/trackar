trackar
=======

KSP plugin for RBI tracks

part.cfg parameters and brief description:

MODULE
{
    	name = DualTrack or SingleTrack
    	trackLength = track texture panning speed, higher number is slower, floats are valid. zero effect on physical length.
    	BrakingTorque = brake stopping power
    	RollingResistance = it's.. natural resistance to movement. yeah.
    	
    	TorqueCurve
    	{
    		key = 0 18 0 0
    		key = 70 6 0 0
    		key = 200 3.4 0 0
    		key = 1000 1.0 0 0
    	}
}

Adjusting the TorqueCurve
first number is RPM, second number is torque to apply, third and fourth are something to do with step size or something? better explanations soon.



Also acceptable:
WheelModelName
WheelColliderName
TrackSurfaceName
SuspJointName
LeftTrackRoot
RightTrackRoot
SingleTrackRoot

If you don't know what these do, then it's best not to try to use them; their default values will be perfectly fine and Doing It Wrong will lead to NullReferences Everywhere.