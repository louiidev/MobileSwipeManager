# MobileSwipeManager
A Unity3d script to manage mobile swiping


## Usage
```     
        GameObject gameObjectWithScript;
        SwipeManager swipeManager;
        
        void Start() {
          gameObjectWithScript = GameObject.Find("foo");
          swipeManager = gameObjectWithScript.GetComponent<SwipeManager>();
        }
        
        void Update() {
           if (swipeManager.IsSwiping(SwipeDirection.Left)) {
              //do something..
           }
        }
       
```
