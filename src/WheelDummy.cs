//=============================================================
// Back to bring-a-booksville
// We've all been there, what's the next stop?
// I won't sit still 
//=============================================================

using System;
using System.Collections.Generic;

using UnityEngine;


namespace Trackar
{
	public class WheelDummy
	{
		public WheelCollider Collider { get { return _collider; } }
		public Transform Joint { get { return _joint; } }
		public GameObject WheelModel { get { return _model; } }

		public SuspConfig Susp;

		private WheelCollider _collider;
		private Transform _joint;
		private GameObject _model;

		public WheelDummy(WheelCollider col, Transform joint, GameObject model)
		{
			Debuggar.Message ("New WheelDummy instantiated");

			this._collider = col;
			this._joint = joint;
			this._model = model;
		}

		public void Rotate(float rpm)
		{
			float deg = (rpm / 60) * 360;
			float delta = deg * Time.deltaTime;
			float rot = delta / Collider.radius;
			WheelModel.transform.Rotate(Vector3.right, rot);
		}

		public void PhysUpdate()
		{
			Collider.suspensionDistance = Susp.Travel;
			JointSpring spring = Collider.suspensionSpring;
			spring.targetPosition = Susp.TravelCenter;
			spring.damper = Susp.Damper;
			Collider.suspensionSpring = spring; // UGH this feels hacky
		}
	}
}

