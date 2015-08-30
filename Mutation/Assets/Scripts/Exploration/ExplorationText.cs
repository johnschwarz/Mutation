﻿using UnityEngine;
using System.Collections;

public class ExplorationText  : ScriptableObject
{

	public string[,] dialogue =  new string[30, 16];

	public void Start()
	{
		//A row
		dialogue[0,0] = "Impassable";
		dialogue[1,0] = "Impassable";
		dialogue[2,0] = "Impassable";
		dialogue[3,0] = "Impassable";
		dialogue[4,0] = "Impassable";
		dialogue[5,0] = "Impassable";
		dialogue[6,0] = "Impassable";
		dialogue[7,0] = "Impassable";
		dialogue[8,0] = "Impassable";
		dialogue[9,0] = "Impassable";
		dialogue[10,0] = "Impassable";
		dialogue[11,0] = "Impassable";
		dialogue[12,0] = "Impassable";
		dialogue[13,0] = "Impassable";
		dialogue[14,0] = "Impassable";
		dialogue[15,0] = "Impassable";
		dialogue[16,0] = "Impassable";
		dialogue[17,0] = "Impassable";
		dialogue[18,0] = "Impassable";
		dialogue[19,0] = "Impassable";
		dialogue[20,0] = "Impassable";
		dialogue[21,0] = "Impassable";
		dialogue[22,0] = "Impassable";
		dialogue[23,0] = "Impassable";
		dialogue[24,0] = "Impassable";
		dialogue[25,0] = "Impassable";
		dialogue[26,0] = "Impassable";
		dialogue[27,0] = "Impassable";
		dialogue[28,0] = "Impassable";
		dialogue[29,0] = "Impassable";

		//B row		   "   ;
		dialogue[0,1] = "Impassable";
		dialogue[1,1] = "Impassable";
		dialogue[2,1] = "Impassable";
		dialogue[3,1] = "Impassable";
		dialogue[4,1] = "Impassable";
		dialogue[5,1] = "Impassable";
		dialogue[6,1] = "Impassable";
		dialogue[7,1] = "Impassable";
		dialogue[8,1] = "Impassable";
		dialogue[9,1] = "Impassable";
		dialogue[10,1] = "Impassable";
		dialogue[11,1] = "Impassable";
		dialogue[12,1] = "Impassable";
		dialogue[13,1] = "Impassable";
		dialogue[14,1] = "Forest";
		dialogue[15,1] = "Forest";
		dialogue[16,1] = "Impassable";
		dialogue[17,1] = "Impassable";
		dialogue[18,1] = "Forest";
		dialogue[19,1] = "Forest";
		dialogue[20,1] = "Forest";
		dialogue[21,1] = "Impassable";
		dialogue[22,1] = "Impassable";
		dialogue[23,1] = "Impassable";
		dialogue[24,1] = "Impassable";
		dialogue[25,1] = "Impassable";
		dialogue[26,1] = "Impassable";
		dialogue[27,1] = "Impassable";
		dialogue[28,1] = "Impassable";
		dialogue[29,1] = "Impassable";

		//C row		   "   ;
		dialogue[0,2] = "Impassable";
		dialogue[1,2] = "Impassable";
		dialogue[2,2] = "Yard";
		dialogue[3,2] = "Yard";
		dialogue[4,2] = "Yard";
		dialogue[5,2] = "Impassable";
		dialogue[6,2] = "Forest";
		dialogue[7,2] = "Forest";
		dialogue[8,2] = "Forest";
		dialogue[9,2] = "Impassable";
		dialogue[10,2] = "Impassable";
		dialogue[11,2] = "Impassable";
		dialogue[12,2] = "Impassable";
		dialogue[13,2] = "Impassable";
		dialogue[14,2] = "Forest";
		dialogue[15,2] = "Forest";
		dialogue[16,2] = "Impassable";
		dialogue[17,2] = "Impassable";
		dialogue[18,2] = "Forest";
		dialogue[19,2] = "Forest";
		dialogue[20,2] = "Forest";
		dialogue[21,2] = "Impassable";
		dialogue[22,2] = "Impassable";
		dialogue[23,2] = "Impassable";
		dialogue[24,2] = "Impassable";
		dialogue[25,2] = "Impassable";
		dialogue[26,2] = "Impassable";
		dialogue[27,2] = "Quest1";
		dialogue[28,2] = "Forest";
		dialogue[29,2] = "Impassable";


		//D row		   "   ;
		dialogue[0,3] = "Impassable";
		dialogue[1,3] = "Impassable";
		dialogue[2,3] = "Yard";
		dialogue[3,3] = "Yard";
		dialogue[4,3] = "Yard";
		dialogue[5,3] = "Impassable";
		dialogue[6,3] = "Forest";
		dialogue[7,3] = "Forest";
		dialogue[8,3] = "Forest";
		dialogue[9,3] = "Forest";
		dialogue[10,3] = "Trail";
		dialogue[11,3] = "Trail";
		dialogue[12,3] = "Trail";
		dialogue[13,3] = "Trail";
		dialogue[14,3] = "Embankment";
		dialogue[15,3] = "Pool";
		dialogue[16,3] = "Waterfall";
		dialogue[17,3] = "Waterfall";
		dialogue[18,3] = "Pool";
		dialogue[19,3] = "Forest";
		dialogue[20,3] = "Forest";
		dialogue[21,3] = "Impassable";
		dialogue[22,3] = "Impassable";
		dialogue[23,3] = "Impassable";
		dialogue[24,3] = "Impassable";
		dialogue[25,3] = "Impassable";
		dialogue[26,3] = "Impassable";
		dialogue[27,3] = "Forest";
		dialogue[28,3] = "Forest";
		dialogue[29,3] = "Impassable";

		//E row		   "   ;
		dialogue[0,4] = "Yard";
		dialogue[1,4] = "Yard";
		dialogue[2,4] = "Yard";
		dialogue[3,4] = "Yard";
		dialogue[4,4] = "Yard";
		dialogue[5,4] = "Impassable";
		dialogue[6,4] = "Forest";
		dialogue[7,4] = "Forest";
		dialogue[8,4] = "Forest";
		dialogue[9,4] = "Forest";
		dialogue[10,4] = "Trail";
		dialogue[11,4] = "Impassable";
		dialogue[12,4] = "Impassable";
		dialogue[13,4] = "Impassable";
		dialogue[14,4] = "Forest";
		dialogue[15,4] = "Pool";
		dialogue[16,4] = "Pool";
		dialogue[17,4] = "Pool";
		dialogue[18,4] = "Pool";
		dialogue[19,4] = "Forest";
		dialogue[20,4] = "Forest";
		dialogue[21,4] = "Impassable";
		dialogue[22,4] = "Impassable";
		dialogue[23,4] = "Impassable";
		dialogue[24,4] = "Impassable";
		dialogue[25,4] = "Impassable";
		dialogue[26,4] = "Impassable";
		dialogue[27,4] = "River";  //make this the teleport spot
		dialogue[28,4] = "Forest"; 
		dialogue[29,4] = "Impassable";

		//F Row		   "   ;
		dialogue[0,5] = "Yard";
		dialogue[1,5] = "Yard";
		dialogue[2,5] = "Yard";
		dialogue[3,5] = "Yard";
		dialogue[4,5] = "Yard";
		dialogue[5,5] = "Impassable";
		dialogue[6,5] = "Forest";
		dialogue[7,5] = "Forest";
		dialogue[8,5] = "Forest";
		dialogue[9,5] = "Forest";
		dialogue[10,5] = "Trail";
		dialogue[11,5] = "Impassable";
		dialogue[12,5] = "Impassable";
		dialogue[13,5] = "Impassable";
		dialogue[14,5] = "Impassable";
		dialogue[15,5] = "Impassable";
		dialogue[16,5] = "River Bed";
		dialogue[17,5] = "River";
		dialogue[18,5] = "River";
		dialogue[19,5] = "River Bed";
		dialogue[20,5] = "Forest";
		dialogue[21,5] = "Forest";
		dialogue[22,5] = "Forest";
		dialogue[23,5] = "Forest";
		dialogue[24,5] = "Impassable";
		dialogue[25,5] = "Impassable";
		dialogue[26,5] = "Impassable";
		dialogue[27,5] = "Impassable";
		dialogue[28,5] = "DownTownEntrance";
		dialogue[29,5] = "Impassable";

		//G row		   
		dialogue[0,6] = "Yard";
		dialogue[1,6] = "Yard";
		dialogue[2,6] = "Yard";
		dialogue[3,6] = "Yard";
		dialogue[4,6] = "Yard";
		dialogue[5,6] = "Impassable";
		dialogue[6,6] = "Forest";
		dialogue[7,6] = "Forest";
		dialogue[8,6] = "Forest";
		dialogue[9,6] = "Forest";
		dialogue[10,6] = "Trail";
		dialogue[11,6] = "Forest";
		dialogue[12,6] = "Forest";
		dialogue[13,6] = "Impassable";
		dialogue[14,6] = "Impassable";
		dialogue[15,6] = "Impassable";
		dialogue[16,6] = "River Bed";
		dialogue[17,6] = "River Bed";
		dialogue[18,6] = "River";
		dialogue[19,6] = "River Bed";
		dialogue[20,6] = "River Bed";
		dialogue[21,6] = "Forest";
		dialogue[22,6] = "Forest";
		dialogue[23,6] = "Forest";
		dialogue[24,6] = "Quest1";
		dialogue[25,6] = "Impassable";
		dialogue[26,6] = "DownTown";
		dialogue[27,6] = "DownTown";
		dialogue[28,6] = "DownTown";
		dialogue[29,6] = "Impassable";

		//H row		   
		dialogue[0,7] = "Yard";
		dialogue[1,7] = "Yard";
		dialogue[2,7] = "Yard";
		dialogue[3,7] = "Yard";
		dialogue[4,7] = "Yard";
		dialogue[5,7] = "Trail";
		dialogue[6,7] = "Trail";
		dialogue[7,7] = "Trail";
		dialogue[8,7] = "Trail";
		dialogue[9,7] = "Trail";
		dialogue[10,7] = "Trail";
		dialogue[11,7] = "Forest";
		dialogue[12,7] = "Forest";
		dialogue[13,7] = "Impassable";
		dialogue[14,7] = "Impassable";
		dialogue[15,7] = "Impassable";
		dialogue[16,7] = "Forest";
		dialogue[17,7] = "River Bed";
		dialogue[18,7] = "River";
		dialogue[19,7] = "River";
		dialogue[20,7] = "River";
		dialogue[21,7] = "River";
		dialogue[22,7] = "DownTownEntrance";
		dialogue[23,7] = "Impassable";
		dialogue[24,7] = "Impassable";
		dialogue[25,7] = "Impassable";
		dialogue[26,7] = "DownTown";
		dialogue[27,7] = "DownTown";
		dialogue[28,7] = "DownTown";
		dialogue[29,7] = "Impassable";

		//I row		  
		dialogue[0,8] = "Impassable";
		dialogue[1,8] = "Impassable";
		dialogue[2,8] = "Impassable";
		dialogue[3,8] = "Impassable";
		dialogue[4,8] = "Forest";
		dialogue[5,8] = "Forest";
		dialogue[6,8] = "Forest";
		dialogue[7,8] = "Forest";
		dialogue[8,8] = "Trail";
		dialogue[9,8] = "Forest";
		dialogue[10,8] = "Forest";
		dialogue[11,8] = "Forest";
		dialogue[12,8] = "Forest";
		dialogue[13,8] = "Impassable";
		dialogue[14,8] = "Impassable";
		dialogue[15,8] = "Impassable";
		dialogue[16,8] = "Forest";
		dialogue[17,8] = "River Bed";
		dialogue[18,8] = "River Bed";
		dialogue[19,8] = "River Bed";
		dialogue[20,8] = "River";
		dialogue[21,8] = "River";
		dialogue[22,8] = "Embankment";
		dialogue[23,8] = "Forest";
		dialogue[24,8] = "Embankment";
		dialogue[25,8] = "Impassable";
		dialogue[26,8] = "DownTown";
		dialogue[27,8] = "DownTown";
		dialogue[28,8] = "DownTown";
		dialogue[29,8] = "Impassable";

		//J row		   
		dialogue[0,9] = "Forest";
		dialogue[1,9] = "Forest";
		dialogue[2,9] = "Forest";
		dialogue[3,9] = "Forest";
		dialogue[4,9] = "Forest";
		dialogue[5,9] = "Forest"; 
		dialogue[6,9] = "Forest";
		dialogue[7,9] = "Impassable";
		dialogue[8,9] = "Trail";
		dialogue[9,9] = "River Bed";
		dialogue[10,9] = "River Bed";
		dialogue[11,9] = "Embankment";
		dialogue[12,9] = "Embankment";
		dialogue[13,9] = "Embankment";
		dialogue[14,9] = "Embankment";
		dialogue[15,9] = "Embankment";
		dialogue[16,9] = "Embankment";
		dialogue[17,9] = "Forest";
		dialogue[18,9] = "Forest";
		dialogue[19,9] = "River Bed";
		dialogue[20,9] = "River";
		dialogue[21,9] = "River";
		dialogue[22,9] = "Embankment";
		dialogue[23,9] = "Embankment";
		dialogue[24,9] = "River";
		dialogue[25,9] = "Impassable";
		dialogue[26,9] = "DownTown";
		dialogue[27,9] = "DownTown";
		dialogue[28,9] = "DownTown";
		dialogue[29,9] = "Impassable";

		//10			  
		dialogue[0,10] = "Forest";
		dialogue[1,10] = "Forest";
		dialogue[2,10] = "Forest";
		dialogue[3,10] = "River Bank";
		dialogue[4,10] = "Forest";
		dialogue[5,10] = "Forest";
		dialogue[6,10] = "Forest";
		dialogue[7,10] = "Impassable";
		dialogue[8,10] = "River Bank";
		dialogue[9,10] = "River Bank";
		dialogue[10,10] = "Pool";
		dialogue[11,10] = "Pool";
		dialogue[12,10] = "Pool";
		dialogue[13,10] = "Pool";
		dialogue[14,10] = "River";
		dialogue[15,10] = "River";
		dialogue[16,10] = "River";
		dialogue[17,10] = "Embankment";
		dialogue[18,10] = "Embankment";
		dialogue[19,10] = "Embankment";
		dialogue[20,10] = "River";
		dialogue[21,10] = "River";
		dialogue[22,10] = "River";
		dialogue[23,10] = "River";
		dialogue[24,10] = "River";
		dialogue[25,10] = "Impassable";
		dialogue[26,10] = "DownTown";
		dialogue[27,10] = "DownTown";
		dialogue[28,10] = "DownTown";
		dialogue[29,10] = "Impassable";


		//11			  
		dialogue[0,11] = "Forest";
		dialogue[1,11] = "Forest";
		dialogue[2,11] = "Forest";
		dialogue[3,11] = "River Bed";
		dialogue[4,11] = "River";
		dialogue[5,11] = "River";
		dialogue[6,11] = "River";
		dialogue[7,11] = "River";
		dialogue[8,11] = "River";
		dialogue[9,11] = "River";
		dialogue[10,11] = "Pool";
		dialogue[11,11] = "Pool";
		dialogue[12,11] = "Pool";
		dialogue[13,11] = "Pool";
		dialogue[14,11] = "River";
		dialogue[15,11] = "River";
		dialogue[16,11] = "River";
		dialogue[17,11] = "River";
		dialogue[18,11] = "River";
		dialogue[19,11] = "River";
		dialogue[20,11] = "River";
		dialogue[21,11] = "River";
		dialogue[22,11] = "Embankment";
		dialogue[23,11] = "Embankment";
		dialogue[24,11] = "Embankment";
		dialogue[25,11] = "Impassable";
		dialogue[26,11] = "DownTown";
		dialogue[27,11] = "DownTown";
		dialogue[28,11] = "DownTown";
		dialogue[29,11] = "Impassable";
						  
		dialogue[0,12] = "Forest";
		dialogue[1,12] = "Forest";
		dialogue[2,12] = "Embankment";
		dialogue[3,12] = "Embankment";
		dialogue[4,12] = "River";
		dialogue[5,12] = "River";
		dialogue[6,12] = "River";
		dialogue[7,12] = "River";
		dialogue[8,12] = "River";
		dialogue[9,12] = "River";
		dialogue[10,12] = "River Bed";
		dialogue[11,12] = "River Bed";
		dialogue[12,12] = "River Bed";
		dialogue[13,12] = "Embankment";
		dialogue[14,12] = "Embankment";
		dialogue[15,12] = "Embankment";
		dialogue[16,12] = "Forest";
		dialogue[17,12] = "River Bed";
		dialogue[18,12] = "River Bed";
		dialogue[19,12] = "River Bed";
		dialogue[20,12] = "River Bed";
		dialogue[21,12] = "Forest";
		dialogue[22,12] = "Forest";
		dialogue[23,12] = "Forest";
		dialogue[24,12] = "Forest";
		dialogue[25,12] = "Impassable";
		dialogue[26,12] = "Impassable";
		dialogue[27,12] = "Impassable";
		dialogue[28,12] = "Impassable";
		dialogue[29,12] = "Impassable";
						  
		dialogue[0,13] = "Impassable";
		dialogue[1,13] = "Forest";
		dialogue[2,13] = "Embankment";
		dialogue[3,13] = "River Bed";
		dialogue[4,13] = "River";
		dialogue[5,13] = "Embankment";
		dialogue[6,13] = "Forest";
		dialogue[7,13] = "Forest";
		dialogue[8,13] = "Forest";
		dialogue[9,13] = "Impassable";
		dialogue[10,13] = "Impassable";
		dialogue[11,13] = "Impassable";
		dialogue[12,13] = "Impassable";
		dialogue[13,13] = "Impassable";
		dialogue[14,13] = "Impassable";
		dialogue[15,13] = "Forest";
		dialogue[16,13] = "Forest";
		dialogue[17,13] = "Impassable";
		dialogue[18,13] = "Impassable";
		dialogue[19,13] = "Forest";
		dialogue[20,13] = "Forest";
		dialogue[21,13] = "Forest";
		dialogue[22,13] = "Forest";
		dialogue[23,13] = "Forest";
		dialogue[24,13] = "Forest";
		dialogue[25,13] = "Forest";
		dialogue[26,13] = "Forest";
		dialogue[27,13] = "Forest";
		dialogue[28,13] = "Impassable";
		dialogue[29,13] = "Impassable";
						  
		dialogue[0,14] = "Impassable";
		dialogue[1,14] = "Impassable";
		dialogue[2,14] = "Impassable";
		dialogue[3,14] = "Impassable";
		dialogue[4,14] = "Waterfall";
		dialogue[5,14] = "River Bed";
		dialogue[6,14] = "Forest";
		dialogue[7,14] = "Forest";
		dialogue[8,14] = "Forest";
		dialogue[9,14] = "Impassable";
		dialogue[10,1] = "Impassable";
		dialogue[11,14] = "Impassable";
		dialogue[12,14] = "Impassable";
		dialogue[13,14] = "Impassable";
		dialogue[14,14] = "Impassable";
		dialogue[15,14] = "Forest";
		dialogue[16,14] = "Forest";
		dialogue[17,14] = "Forest";
		dialogue[18,14] = "Forest";
		dialogue[19,14] = "Forest";
		dialogue[20,14] = "Impassable";
		dialogue[21,14] = "Impassable";
		dialogue[22,14] = "Impassable";
		dialogue[23,14] = "Impassable";
		dialogue[24,14] = "Impassable";
		dialogue[25,14] = "Impassable";
		dialogue[26,14] = "Impassable";
		dialogue[27,14] = "Impassable";
		dialogue[28,14] = "Impassable";
		dialogue[29,14] = "Impassable";
						  
		dialogue[0,15] = "Impassable";
		dialogue[1,15] = "Impassable";
		dialogue[2,15] = "Impassable";
		dialogue[3,15] = "Impassable";
		dialogue[4,15] = "Impassable";
		dialogue[5,15] = "Impassable";
		dialogue[6,15] = "Impassable";
		dialogue[7,15] = "Impassable";
		dialogue[8,15] = "Impassable";
		dialogue[9,15] = "Impassable";
		dialogue[10,15] = "Impassable";
		dialogue[11,15] = "Impassable";
		dialogue[12,15] = "Impassable";
		dialogue[13,15] = "Impassable";
		dialogue[14,15] = "Impassable";
		dialogue[15,15] = "Impassable";
		dialogue[16,15] = "Impassable";
		dialogue[17,15] = "Impassable";
		dialogue[18,15] = "Impassable";
		dialogue[19,15] = "Impassable";
		dialogue[20,15] = "Impassable";
		dialogue[21,15] = "Impassable";
		dialogue[22,15] = "Impassable";
		dialogue[23,15] = "Impassable";
		dialogue[24,15] = "Impassable";
		dialogue[25,15] = "Impassable";
		dialogue[26,15] = "Impassable";
		dialogue[27,15] = "Impassable";
		dialogue[28,15] = "Impassable";
		dialogue[29,15] = "Impassable";

	}
	

}
