using UnityEngine;
using System.Collections;

public class ReadBluetooth : MonoBehaviour {
	
	string BT;
	
	void start () {

	}
	
	void update() {
		
		string temp = BtConnector.readLine();
		
		if (temp.Length > 0) {
			
			BT = temp;
			
			Debug.Log (BT);
		
//		if ( BT.Length >= 2 ){
//			
//			joystickxy[0] = BT[0] - 48; // -48 used to convert char to int
//			
//			joystickxy[1] = BT[1] - 48;
//			
//		} // do whatever you want with these data

		}
		
	} 
}
