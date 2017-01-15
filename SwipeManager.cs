using UnityEngine;
using System.Collections;

public enum SwipeDirection {
	None = 0,
	Left = 1,
	Right = 2,
	Up = 4,
	Down = 8
}

public class SwipeManager : MonoBehaviour {

	private static SwipeManager instance;
	public static SwipeManager Instance {get { return instance; }}

	private Vector3 touchPosition;
	private float swipeResistanceX = 50;
	private float swipeResistanceY = 100;

	public SwipeDirection Direction { get; set; }

	void Start() {
		instance = this;
	}

	void Update() {

		Direction = SwipeDirection.None;

		if (Input.GetMouseButtonDown (0)) {
			touchPosition = Input.mousePosition;
		}

		if (Input.GetMouseButtonUp (0)) {
			Vector2 deltaSwipe = touchPosition - Input.mousePosition;

			if (Mathf.Abs(deltaSwipe.x) > swipeResistanceX) {
				Direction |= (deltaSwipe.x < 0) ? SwipeDirection.Right : SwipeDirection.Left;
			}

			if (Mathf.Abs(deltaSwipe.y) > swipeResistanceY) {
				Direction |= (deltaSwipe.y < 0) ? SwipeDirection.Up : SwipeDirection.Down;
			}
		}
	}

	public bool IsSwiping(SwipeDirection dir)
	{
		return (Direction & dir) == dir;
	}﻿
}
