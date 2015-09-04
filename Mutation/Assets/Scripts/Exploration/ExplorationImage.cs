﻿using UnityEngine;
using System.Collections;

public class ExplorationImage  : ScriptableObject
{
	
	public string[,] backgroundImage = new string[30, 29];
	
	public void Start ()
	{  
		backgroundImage [0, 0] = "Impassable";
		backgroundImage [1, 0] = "Impassable";
		backgroundImage [2, 0] = "Impassable";
		backgroundImage [3, 0] = "Impassable";
		backgroundImage [4, 0] = "Impassable";
		backgroundImage [5, 0] = "Impassable";
		backgroundImage [6, 0] = "Impassable";
		backgroundImage [7, 0] = "Impassable";
		backgroundImage [8, 0] = "Impassable";
		backgroundImage [9, 0] = "Impassable";
		backgroundImage [10, 0] = "Impassable";
		backgroundImage [11, 0] = "Impassable";
		backgroundImage [12, 0] = "Impassable";
		backgroundImage [13, 0] = "Impassable";
		backgroundImage [14, 0] = "Impassable";
		backgroundImage [15, 0] = "Impassable";
		backgroundImage [16, 0] = "Impassable";
		backgroundImage [17, 0] = "Impassable";
		backgroundImage [18, 0] = "Impassable";
		backgroundImage [19, 0] = "Impassable";
		backgroundImage [20, 0] = "Impassable";
		backgroundImage [21, 0] = "Impassable";
		backgroundImage [22, 0] = "Impassable";
		backgroundImage [23, 0] = "Impassable";
		backgroundImage [24, 0] = "Impassable";
		backgroundImage [25, 0] = "Impassable";
		backgroundImage [26, 0] = "Impassable";
		backgroundImage [27, 0] = "Impassable";
		backgroundImage [28, 0] = "Impassable";
		backgroundImage [29, 0] = "Impassable";
		
		//B row		   "   ;
		backgroundImage [0, 1] = "Impassable";
		backgroundImage [1, 1] = "Impassable";
		backgroundImage [2, 1] = "Impassable";
		backgroundImage [3, 1] = "Impassable";
		backgroundImage [4, 1] = "Impassable";
		backgroundImage [5, 1] = "Impassable";
		backgroundImage [6, 1] = "Impassable";
		backgroundImage [7, 1] = "Impassable";
		backgroundImage [8, 1] = "Impassable";
		backgroundImage [9, 1] = "Impassable";
		backgroundImage [10, 1] = "Impassable";
		backgroundImage [11, 1] = "Impassable";
		backgroundImage [12, 1] = "Impassable";
		backgroundImage [13, 1] = "Impassable";
		backgroundImage [14, 1] = "Backgrounds/Green";
		backgroundImage [15, 1] = "Backgrounds/Green";
		backgroundImage [16, 1] = "Impassable";
		backgroundImage [17, 1] = "Impassable";
		backgroundImage [18, 1] = "Backgrounds/Green";
		backgroundImage [19, 1] = "Backgrounds/Green";
		backgroundImage [20, 1] = "Backgrounds/Green";
		backgroundImage [21, 1] = "Impassable";
		backgroundImage [22, 1] = "Impassable";
		backgroundImage [23, 1] = "Impassable";
		backgroundImage [24, 1] = "Impassable";
		backgroundImage [25, 1] = "Impassable";
		backgroundImage [26, 1] = "Impassable";
		backgroundImage [27, 1] = "Impassable";
		backgroundImage [28, 1] = "Impassable";
		backgroundImage [29, 1] = "Impassable";
		
		//C row		   "   ;
		backgroundImage [0, 2] = "Impassable";
		backgroundImage [1, 2] = "Impassable";
		backgroundImage [2, 2] = "Backgrounds/Yard";
		backgroundImage [3, 2] = "Backgrounds/Yard";
		backgroundImage [4, 2] = "Backgrounds/Yard";
		backgroundImage [5, 2] = "Impassable";
		backgroundImage [6, 2] = "Backgrounds/Green";
		backgroundImage [7, 2] = "Backgrounds/Green";
		backgroundImage [8, 2] = "Backgrounds/Green";
		backgroundImage [9, 2] = "Impassable";
		backgroundImage [10, 2] = "Impassable";
		backgroundImage [11, 2] = "Impassable";
		backgroundImage [12, 2] = "Impassable";
		backgroundImage [13, 2] = "Impassable";
		backgroundImage [14, 2] = "Backgrounds/Green";
		backgroundImage [15, 2] = "Backgrounds/Green";
		backgroundImage [16, 2] = "Impassable";
		backgroundImage [17, 2] = "Impassable";
		backgroundImage [18, 2] = "Backgrounds/Green";
		backgroundImage [19, 2] = "Backgrounds/Green";
		backgroundImage [20, 2] = "Backgrounds/Green";
		backgroundImage [21, 2] = "Impassable";
		backgroundImage [22, 2] = "Impassable";
		backgroundImage [23, 2] = "Impassable";
		backgroundImage [24, 2] = "Impassable";
		backgroundImage [25, 2] = "Impassable";
		backgroundImage [26, 2] = "Impassable";
		backgroundImage [27, 2] = "Backgrounds/DownTown - BountyBar";
		backgroundImage [28, 2] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [29, 2] = "Impassable";
		
		
		//D row		   "   ;
		backgroundImage [0, 3] = "Impassable";
		backgroundImage [1, 3] = "Impassable";
		backgroundImage [2, 3] = "Backgrounds/Yard";
		backgroundImage [3, 3] = "Backgrounds/Yard";
		backgroundImage [4, 3] = "Backgrounds/Yard";
		backgroundImage [5, 3] = "Impassable";
		backgroundImage [6, 3] = "Backgrounds/Green";
		backgroundImage [7, 3] = "Backgrounds/Green";
		backgroundImage [8, 3] = "Backgrounds/Green";
		backgroundImage [9, 3] = "Backgrounds/Green";
		backgroundImage [10, 3] = "Backgrounds/Trail";
		backgroundImage [11, 3] = "Backgrounds/Trail";
		backgroundImage [12, 3] = "Backgrounds/Trail";
		backgroundImage [13, 3] = "Backgrounds/Trail";
		backgroundImage [14, 3] = "Backgrounds/Embankment";
		backgroundImage [15, 3] = "Backgrounds/Pool";
		backgroundImage [16, 3] = "Backgrounds/Waterfall";
		backgroundImage [17, 3] = "Backgrounds/Waterfall";
		backgroundImage [18, 3] = "Backgrounds/Pool";
		backgroundImage [19, 3] = "Backgrounds/Green";
		backgroundImage [20, 3] = "Backgrounds/Green";
		backgroundImage [21, 3] = "Impassable";
		backgroundImage [22, 3] = "Impassable";
		backgroundImage [23, 3] = "Impassable";
		backgroundImage [24, 3] = "Impassable";
		backgroundImage [25, 3] = "Impassable";
		backgroundImage [26, 3] = "Impassable";
		backgroundImage [27, 3] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [28, 3] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [29, 3] = "Impassable";
		
		//E row		   "   ;
		backgroundImage [0, 4] = "Backgrounds/Yard";
		backgroundImage [1, 4] = "Backgrounds/Yard";
		backgroundImage [2, 4] = "Backgrounds/Yard";
		backgroundImage [3, 4] = "Backgrounds/Yard";
		backgroundImage [4, 4] = "Backgrounds/Yard";
		backgroundImage [5, 4] = "Impassable";
		backgroundImage [6, 4] = "Backgrounds/Green";
		backgroundImage [7, 4] = "Backgrounds/Green";
		backgroundImage [8, 4] = "Backgrounds/Green";
		backgroundImage [9, 4] = "Backgrounds/Green";
		backgroundImage [10, 4] = "Backgrounds/Trail";
		backgroundImage [11, 4] = "Impassable";
		backgroundImage [12, 4] = "Impassable";
		backgroundImage [13, 4] = "Impassable";
		backgroundImage [14, 4] = "Backgrounds/Green";
		backgroundImage [15, 4] = "Backgrounds/Pool";
		backgroundImage [16, 4] = "Backgrounds/Pool";
		backgroundImage [17, 4] = "Backgrounds/Pool";
		backgroundImage [18, 4] = "Backgrounds/Pool";
		backgroundImage [19, 4] = "Backgrounds/Green";
		backgroundImage [20, 4] = "Backgrounds/Green";
		backgroundImage [21, 4] = "Impassable";
		backgroundImage [22, 4] = "Impassable";
		backgroundImage [23, 4] = "Impassable";
		backgroundImage [24, 4] = "Impassable";
		backgroundImage [25, 4] = "Impassable";
		backgroundImage [26, 4] = "Impassable";
		backgroundImage [27, 4] = "Backgrounds/DownTown - DesolateBrown"; //Make Teleporter!
		backgroundImage [28, 4] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [29, 4] = "Impassable";
		
		//F Row		   "   ;
		backgroundImage [0, 5] = "Backgrounds/Yard";
		backgroundImage [1, 5] = "Backgrounds/Yard";
		backgroundImage [2, 5] = "Backgrounds/Yard";
		backgroundImage [3, 5] = "Backgrounds/Yard";
		backgroundImage [4, 5] = "Backgrounds/Yard";
		backgroundImage [5, 5] = "Impassable";
		backgroundImage [6, 5] = "Backgrounds/Green";
		backgroundImage [7, 5] = "Backgrounds/Green";
		backgroundImage [8, 5] = "Backgrounds/Green";
		backgroundImage [9, 5] = "Backgrounds/Green";
		backgroundImage [10, 5] = "Backgrounds/Trail";
		backgroundImage [11, 5] = "Impassable";
		backgroundImage [12, 5] = "Impassable";
		backgroundImage [13, 5] = "Impassable";
		backgroundImage [14, 5] = "Impassable";
		backgroundImage [15, 5] = "Impassable";
		backgroundImage [16, 5] = "Backgrounds/River Bed";
		backgroundImage [17, 5] = "Backgrounds/River";
		backgroundImage [18, 5] = "Backgrounds/River";
		backgroundImage [19, 5] = "Backgrounds/River Bed";
		backgroundImage [20, 5] = "Backgrounds/Green";
		backgroundImage [21, 5] = "Backgrounds/Green";
		backgroundImage [22, 5] = "Backgrounds/Green";
		backgroundImage [23, 5] = "Backgrounds/Green";
		backgroundImage [24, 5] = "Backgrounds/Green";
		backgroundImage [25, 5] = "Backgrounds/Green";
		backgroundImage [26, 5] = "Impassable";
		backgroundImage [27, 5] = "Impassable";
		backgroundImage [28, 5] = "Backgrounds/DownTown - Entrance";
		backgroundImage [29, 5] = "Impassable";
		
		//G row		   
		backgroundImage [0, 6] = "Backgrounds/Yard";
		backgroundImage [1, 6] = "Backgrounds/Yard";
		backgroundImage [2, 6] = "Backgrounds/Yard";
		backgroundImage [3, 6] = "Backgrounds/Yard";
		backgroundImage [4, 6] = "Backgrounds/Yard";
		backgroundImage [5, 6] = "Impassable";
		backgroundImage [6, 6] = "Backgrounds/Green";
		backgroundImage [7, 6] = "Backgrounds/Green";
		backgroundImage [8, 6] = "Backgrounds/Green";
		backgroundImage [9, 6] = "Backgrounds/Green";
		backgroundImage [10, 6] = "Backgrounds/Trail";
		backgroundImage [11, 6] = "Backgrounds/Green";
		backgroundImage [12, 6] = "Backgrounds/Green";
		backgroundImage [13, 6] = "Impassable";
		backgroundImage [14, 6] = "Impassable";
		backgroundImage [15, 6] = "Impassable";
		backgroundImage [16, 6] = "Backgrounds/River Bed";
		backgroundImage [17, 6] = "Backgrounds/River Bed";
		backgroundImage [18, 6] = "Backgrounds/River";
		backgroundImage [19, 6] = "Backgrounds/River Bed";
		backgroundImage [20, 6] = "Backgrounds/River Bed";
		backgroundImage [21, 6] = "Backgrounds/Green";
		backgroundImage [22, 6] = "Backgrounds/Green";
		backgroundImage [23, 6] = "Backgrounds/Green";
		backgroundImage [24, 6] = "Backgrounds/Green";
		backgroundImage [25, 6] = "Backgrounds/Embankment";
		backgroundImage [26, 6] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [27, 6] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [28, 6] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [29, 6] = "Backgrounds/River";
		
		//H row		   
		backgroundImage [0, 7] = "Backgrounds/Yard";
		backgroundImage [1, 7] = "Backgrounds/Yard";
		backgroundImage [2, 7] = "Backgrounds/Yard";
		backgroundImage [3, 7] = "Backgrounds/Yard";
		backgroundImage [4, 7] = "Backgrounds/Yard";
		backgroundImage [5, 7] = "Backgrounds/Trail";
		backgroundImage [6, 7] = "Backgrounds/Trail";
		backgroundImage [7, 7] = "Backgrounds/Trail";
		backgroundImage [8, 7] = "Backgrounds/Trail";
		backgroundImage [9, 7] = "Backgrounds/Trail";
		backgroundImage [10, 7] = "Backgrounds/Trail";
		backgroundImage [11, 7] = "Backgrounds/Green";
		backgroundImage [12, 7] = "Backgrounds/Green";
		backgroundImage [13, 7] = "Impassable";
		backgroundImage [14, 7] = "Impassable";
		backgroundImage [15, 7] = "Impassable";
		backgroundImage [16, 7] = "Backgrounds/Green";
		backgroundImage [17, 7] = "Backgrounds/River Bed";
		backgroundImage [18, 7] = "Backgrounds/River";
		backgroundImage [19, 7] = "Backgrounds/River";
		backgroundImage [20, 7] = "Backgrounds/River";
		backgroundImage [21, 7] = "Backgrounds/River";
		backgroundImage [22, 7] = "Backgrounds/Green";
		backgroundImage [23, 7] = "Impassable";
		backgroundImage [24, 7] = "Impassable";
		backgroundImage [25, 7] = "Backgrounds/Embankment";
		backgroundImage [26, 7] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [27, 7] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [28, 7] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [29, 7] = "Backgrounds/Embankment";
		
		//I row		  
		backgroundImage [0, 8] = "Impassable";
		backgroundImage [1, 8] = "Impassable";
		backgroundImage [2, 8] = "Impassable";
		backgroundImage [3, 8] = "Impassable";
		backgroundImage [4, 8] = "Backgrounds/Green";
		backgroundImage [5, 8] = "Backgrounds/Green";
		backgroundImage [6, 8] = "Backgrounds/Green";
		backgroundImage [7, 8] = "Backgrounds/Green";
		backgroundImage [8, 8] = "Backgrounds/Trail";
		backgroundImage [9, 8] = "Backgrounds/Green";
		backgroundImage [10, 8] = "Backgrounds/Green";
		backgroundImage [11, 8] = "Backgrounds/Green";
		backgroundImage [12, 8] = "Backgrounds/Green";
		backgroundImage [13, 8] = "Impassable";
		backgroundImage [14, 8] = "Impassable";
		backgroundImage [15, 8] = "Impassable";
		backgroundImage [16, 8] = "Backgrounds/Green";
		backgroundImage [17, 8] = "Backgrounds/River Bed";
		backgroundImage [18, 8] = "Backgrounds/River Bed";
		backgroundImage [19, 8] = "Backgrounds/River Bed";
		backgroundImage [20, 8] = "Backgrounds/River";
		backgroundImage [21, 8] = "Backgrounds/River";
		backgroundImage [22, 8] = "Backgrounds/Embankment";
		backgroundImage [23, 8] = "Backgrounds/Green";
		backgroundImage [24, 8] = "Backgrounds/Embankment";
		backgroundImage [25, 8] = "Backgrounds/Embankment";
		backgroundImage [26, 8] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [27, 8] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [28, 8] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [29, 8] = "Backgrounds/Embankment";
		
		//J row		   
		backgroundImage [0, 9] = "Backgrounds/Green";
		backgroundImage [1, 9] = "Backgrounds/Green";
		backgroundImage [2, 9] = "Backgrounds/Green";
		backgroundImage [3, 9] = "Backgrounds/Green";
		backgroundImage [4, 9] = "Backgrounds/Green";
		backgroundImage [5, 9] = "Backgrounds/Green"; 
		backgroundImage [6, 9] = "Backgrounds/Green";
		backgroundImage [7, 9] = "Impassable";
		backgroundImage [8, 9] = "Backgrounds/Trail";
		backgroundImage [9, 9] = "Backgrounds/River Bed";
		backgroundImage [10, 9] = "Backgrounds/River Bed";
		backgroundImage [11, 9] = "Backgrounds/Embankment";
		backgroundImage [12, 9] = "Backgrounds/Embankment";
		backgroundImage [13, 9] = "Backgrounds/Embankment";
		backgroundImage [14, 9] = "Backgrounds/Embankment";
		backgroundImage [15, 9] = "Backgrounds/Embankment";
		backgroundImage [16, 9] = "Backgrounds/Embankment";
		backgroundImage [17, 9] = "Backgrounds/Green";
		backgroundImage [18, 9] = "Backgrounds/Green";
		backgroundImage [19, 9] = "Backgrounds/River Bed";
		backgroundImage [20, 9] = "Backgrounds/River";
		backgroundImage [21, 9] = "Backgrounds/River";
		backgroundImage [22, 9] = "Backgrounds/Embankment";
		backgroundImage [23, 9] = "Backgrounds/Embankment";
		backgroundImage [24, 9] = "Backgrounds/River";
		backgroundImage [25, 9] = "Backgrounds/River";
		backgroundImage [26, 9] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [27, 9] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [28, 9] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [29, 9] = "Backgrounds/Green";
		
		//10			  
		backgroundImage [0, 10] = "Backgrounds/Green";
		backgroundImage [1, 10] = "Backgrounds/Green";
		backgroundImage [2, 10] = "Backgrounds/Green";
		backgroundImage [3, 10] = "Backgrounds/River Bank";
		backgroundImage [4, 10] = "Backgrounds/Green";
		backgroundImage [5, 10] = "Backgrounds/Green";
		backgroundImage [6, 10] = "Backgrounds/Green";
		backgroundImage [7, 10] = "Impassable";
		backgroundImage [8, 10] = "Backgrounds/River Bank";
		backgroundImage [9, 10] = "Backgrounds/River Bank";
		backgroundImage [10, 10] = "Backgrounds/Pool";
		backgroundImage [11, 10] = "Backgrounds/Pool";
		backgroundImage [12, 10] = "Backgrounds/Pool";
		backgroundImage [13, 10] = "Backgrounds/Pool";
		backgroundImage [14, 10] = "Backgrounds/River";
		backgroundImage [15, 10] = "Backgrounds/River";
		backgroundImage [16, 10] = "Backgrounds/River";
		backgroundImage [17, 10] = "Backgrounds/Embankment";
		backgroundImage [18, 10] = "Backgrounds/Embankment";
		backgroundImage [19, 10] = "Backgrounds/Embankment";
		backgroundImage [20, 10] = "Backgrounds/River";
		backgroundImage [21, 10] = "Backgrounds/River";
		backgroundImage [22, 10] = "Backgrounds/River";
		backgroundImage [23, 10] = "Backgrounds/River";
		backgroundImage [24, 10] = "Backgrounds/River";
		backgroundImage [25, 10] = "Backgrounds/Green";
		backgroundImage [26, 10] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [27, 10] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [28, 10] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [29, 10] = "Backgrounds/Green";
		
		
		//11			  
		backgroundImage [0, 11] = "Backgrounds/Green";
		backgroundImage [1, 11] = "Backgrounds/Green";
		backgroundImage [2, 11] = "Backgrounds/Green";
		backgroundImage [3, 11] = "Backgrounds/River Bed";
		backgroundImage [4, 11] = "Backgrounds/River";
		backgroundImage [5, 11] = "Backgrounds/River";
		backgroundImage [6, 11] = "Backgrounds/River";
		backgroundImage [7, 11] = "Backgrounds/River";
		backgroundImage [8, 11] = "Backgrounds/River";
		backgroundImage [9, 11] = "Backgrounds/River";
		backgroundImage [10, 11] = "Backgrounds/Pool";
		backgroundImage [11, 11] = "Backgrounds/Pool";
		backgroundImage [12, 11] = "Backgrounds/Pool";
		backgroundImage [13, 11] = "Backgrounds/Pool";
		backgroundImage [14, 11] = "Backgrounds/River";
		backgroundImage [15, 11] = "Backgrounds/River";
		backgroundImage [16, 11] = "Backgrounds/River";
		backgroundImage [17, 11] = "Backgrounds/River";
		backgroundImage [18, 11] = "Backgrounds/River";
		backgroundImage [19, 11] = "Backgrounds/River";
		backgroundImage [20, 11] = "Backgrounds/River";
		backgroundImage [21, 11] = "Backgrounds/River";
		backgroundImage [22, 11] = "Backgrounds/Embankment";
		backgroundImage [23, 11] = "Backgrounds/Embankment";
		backgroundImage [24, 11] = "Backgrounds/Embankment";
		backgroundImage [25, 11] = "Backgrounds/Green";
		backgroundImage [26, 11] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [27, 11] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [28, 11] = "Backgrounds/DownTown - DesolateBrown";
		backgroundImage [29, 11] = "Backgrounds/Green";
		
		backgroundImage [0, 12] = "Backgrounds/Green";
		backgroundImage [1, 12] = "Backgrounds/Green";
		backgroundImage [2, 12] = "Backgrounds/Embankment";
		backgroundImage [3, 12] = "Backgrounds/Embankment";
		backgroundImage [4, 12] = "Backgrounds/River";
		backgroundImage [5, 12] = "Backgrounds/River";
		backgroundImage [6, 12] = "Backgrounds/River";
		backgroundImage [7, 12] = "Backgrounds/River";
		backgroundImage [8, 12] = "Backgrounds/River";
		backgroundImage [9, 12] = "Backgrounds/River";
		backgroundImage [10, 12] = "Backgrounds/River Bed";
		backgroundImage [11, 12] = "Backgrounds/River Bed";
		backgroundImage [12, 12] = "Backgrounds/River Bed";
		backgroundImage [13, 12] = "Backgrounds/Embankment";
		backgroundImage [14, 12] = "Backgrounds/Embankment";
		backgroundImage [15, 12] = "Backgrounds/Embankment";
		backgroundImage [16, 12] = "Backgrounds/Green";
		backgroundImage [17, 12] = "Backgrounds/River Bed";
		backgroundImage [18, 12] = "Backgrounds/River Bed";
		backgroundImage [19, 12] = "Backgrounds/River Bed";
		backgroundImage [20, 12] = "Backgrounds/River Bed";
		backgroundImage [21, 12] = "Backgrounds/Green";
		backgroundImage [22, 12] = "Backgrounds/Green";
		backgroundImage [23, 12] = "Backgrounds/Green";
		backgroundImage [24, 12] = "Backgrounds/Green";
		backgroundImage [25, 12] = "Backgrounds/Green";
		backgroundImage [26, 12] = "Backgrounds/Green";
		backgroundImage [27, 12] = "Backgrounds/Green";
		backgroundImage [28, 12] = "Impassable";
		backgroundImage [29, 12] = "Impassable";
		
		backgroundImage [0, 13] = "Impassable";
		backgroundImage [1, 13] = "Backgrounds/Green";
		backgroundImage [2, 13] = "Backgrounds/Embankment";
		backgroundImage [3, 13] = "Backgrounds/River Bed";
		backgroundImage [4, 13] = "Backgrounds/River";
		backgroundImage [5, 13] = "Backgrounds/Embankment";
		backgroundImage [6, 13] = "Backgrounds/Green";
		backgroundImage [7, 13] = "Backgrounds/Green";
		backgroundImage [8, 13] = "Backgrounds/Green";
		backgroundImage [9, 13] = "Impassable";
		backgroundImage [10, 13] = "Impassable";
		backgroundImage [11, 13] = "Impassable";
		backgroundImage [12, 13] = "Impassable";
		backgroundImage [13, 13] = "Impassable";
		backgroundImage [14, 13] = "Impassable";
		backgroundImage [15, 13] = "Backgrounds/Green";
		backgroundImage [16, 13] = "Backgrounds/Green";
		backgroundImage [17, 13] = "Impassable";
		backgroundImage [18, 13] = "Impassable";
		backgroundImage [19, 13] = "Backgrounds/Green";
		backgroundImage [20, 13] = "Backgrounds/Green";
		backgroundImage [21, 13] = "Backgrounds/Green";
		backgroundImage [22, 13] = "Backgrounds/Green";
		backgroundImage [23, 13] = "Backgrounds/Green";
		backgroundImage [24, 13] = "Backgrounds/Green";
		backgroundImage [25, 13] = "Backgrounds/Green";
		backgroundImage [26, 13] = "Backgrounds/Green";
		backgroundImage [27, 13] = "Backgrounds/Green";
		backgroundImage [28, 13] = "Impassable";
		backgroundImage [29, 13] = "Impassable";
		
		backgroundImage [0, 14] = "Impassable";
		backgroundImage [1, 14] = "Impassable";
		backgroundImage [2, 14] = "Impassable";
		backgroundImage [3, 14] = "Impassable";
		backgroundImage [4, 14] = "Backgrounds/Waterfall";
		backgroundImage [5, 14] = "Backgrounds/River Bed";
		backgroundImage [6, 14] = "Backgrounds/Green";
		backgroundImage [7, 14] = "Backgrounds/Green";
		backgroundImage [8, 14] = "Backgrounds/Green";
		backgroundImage [9, 14] = "Impassable";
		backgroundImage [10, 1] = "Impassable";
		backgroundImage [11, 14] = "Impassable";
		backgroundImage [12, 14] = "Impassable";
		backgroundImage [13, 14] = "Impassable";
		backgroundImage [14, 14] = "Impassable";
		backgroundImage [15, 14] = "Backgrounds/Green";
		backgroundImage [16, 14] = "Backgrounds/Green";
		backgroundImage [17, 14] = "Backgrounds/Green";
		backgroundImage [18, 14] = "Backgrounds/Green";
		backgroundImage [19, 14] = "Backgrounds/Green";
		backgroundImage [20, 14] = "Impassable";
		backgroundImage [21, 14] = "Impassable";
		backgroundImage [22, 14] = "Impassable";
		backgroundImage [23, 14] = "Impassable";
		backgroundImage [24, 14] = "Impassable";
		backgroundImage [25, 14] = "Impassable";
		backgroundImage [26, 14] = "Impassable";
		backgroundImage [27, 14] = "Impassable";
		backgroundImage [28, 14] = "Impassable";
		backgroundImage [29, 14] = "Impassable";
		
		backgroundImage [0, 15] = "Impassable";
		backgroundImage [1, 15] = "Impassable";
		backgroundImage [2, 15] = "Impassable";
		backgroundImage [3, 15] = "Impassable";
		backgroundImage [4, 15] = "Impassable";
		backgroundImage [5, 15] = "Impassable";
		backgroundImage [6, 15] = "Impassable";
		backgroundImage [7, 15] = "Impassable";
		backgroundImage [8, 15] = "Impassable";
		backgroundImage [9, 15] = "Impassable";
		backgroundImage [10, 15] = "Impassable";
		backgroundImage [11, 15] = "Impassable";
		backgroundImage [12, 15] = "Impassable";
		backgroundImage [13, 15] = "Impassable";
		backgroundImage [14, 15] = "Impassable";
		backgroundImage [15, 15] = "Impassable";
		backgroundImage [16, 15] = "Impassable";
		backgroundImage [17, 15] = "Impassable";
		backgroundImage [18, 15] = "Impassable";
		backgroundImage [19, 15] = "Impassable";
		backgroundImage [20, 15] = "Impassable";
		backgroundImage [21, 15] = "Impassable";
		backgroundImage [22, 15] = "Impassable";
		backgroundImage [23, 15] = "Impassable";
		backgroundImage [24, 15] = "Impassable";
		backgroundImage [25, 15] = "Impassable";
		backgroundImage [26, 15] = "Impassable";
		backgroundImage [27, 15] = "Impassable";
		backgroundImage [28, 15] = "Impassable";
		backgroundImage [29, 15] = "Impassable";

		backgroundImage[0,16] = "Impassable";
		backgroundImage[1,16] = "Impassable";
		backgroundImage[2,16] = "Impassable";
		backgroundImage[3,16] = "Impassable";
		backgroundImage[4,16] = "Impassable";
		backgroundImage[5,16] = "Impassable";
		backgroundImage[6,16] = "Impassable";
		backgroundImage[7,16] = "Impassable";
		backgroundImage[8,16] = "Impassable";
		backgroundImage[9,16] = "Impassable";
		backgroundImage[10,16] = "Impassable";
		backgroundImage[11,16] = "Impassable";
		backgroundImage[12,16] = "Impassable";
		backgroundImage[13,16] = "Impassable";
		backgroundImage[14,16] = "Impassable";
		backgroundImage[15,16] = "Impassable";
		backgroundImage[16,16] = "Impassable";
		backgroundImage[17,16] = "Impassable";
		backgroundImage[18,16] = "Impassable";
		backgroundImage[19,16] = "Impassable";
		backgroundImage[20,16] = "Impassable";
		backgroundImage[21,16] = "Impassable";
		backgroundImage[22,16] = "Impassable";
		backgroundImage[23,16] = "Impassable";
		backgroundImage[24,16] = "Impassable";
		backgroundImage[25,16] = "Impassable";
		backgroundImage[26,16] = "Impassable";
		backgroundImage[27,16] = "Impassable";
		backgroundImage[28,16] = "Impassable";
		backgroundImage[29,16] = "Impassable";
		
		backgroundImage[0,17] = "Impassable";
		backgroundImage[1,17] = "Impassable";
		backgroundImage[2,17] = "Impassable";
		backgroundImage[3,17] = "Impassable";
		backgroundImage[4,17] = "Impassable";
		backgroundImage[5,17] = "Impassable";
		backgroundImage[6,17] = "Impassable";
		backgroundImage[7,17] = "Impassable";
		backgroundImage[8,17] = "Impassable";
		backgroundImage[9,17] = "Impassable";
		backgroundImage[10,17] = "Impassable";
		backgroundImage[11,17] = "Impassable";
		backgroundImage[12,17] = "Impassable";
		backgroundImage[13,17] = "Impassable";
		backgroundImage[14,17] = "Impassable";
		backgroundImage[15,17] = "Impassable";
		backgroundImage[16,17] = "Impassable";
		backgroundImage[17,17] = "Impassable";
		backgroundImage[18,17] = "Impassable";
		backgroundImage[19,17] = "Impassable";
		backgroundImage[20,17] = "Impassable";
		backgroundImage[21,17] = "Impassable";
		backgroundImage[22,17] = "Impassable";
		backgroundImage[23,17] = "Impassable";
		backgroundImage[24,17] = "Impassable";
		backgroundImage[25,17] = "Impassable";
		backgroundImage[26,17] = "Impassable";
		backgroundImage[27,17] = "Impassable";
		backgroundImage[28,17] = "Impassable";
		backgroundImage[29,17] = "Impassable";
		
		backgroundImage[0,18] = "Impassable";
		backgroundImage[1,18] = "Impassable";
		backgroundImage[2,18] = "Impassable";
		backgroundImage[3,18] = "Impassable";
		backgroundImage[4,18] = "Impassable";
		backgroundImage[5,18] = "Impassable";
		backgroundImage[6,18] = "Impassable";
		backgroundImage[7,18] = "Impassable";
		backgroundImage[8,18] = "Impassable";
		backgroundImage[9,18] = "Impassable";
		backgroundImage[10,18] = "Impassable";
		backgroundImage[11,18] = "Impassable";
		backgroundImage[12,18] = "Impassable";
		backgroundImage[13,18] = "Impassable";
		backgroundImage[14,18] = "Impassable";
		backgroundImage[15,18] = "Impassable";
		backgroundImage[16,18] = "Impassable";
		backgroundImage[17,18] = "Impassable";
		backgroundImage[18,18] = "Impassable";
		backgroundImage[19,18] = "Impassable";
		backgroundImage[20,18] = "Impassable";
		backgroundImage[21,18] = "Impassable";
		backgroundImage[22,18] = "Impassable";
		backgroundImage[23,18] = "Impassable";
		backgroundImage[24,18] = "Impassable";
		backgroundImage[25,18] = "Impassable";
		backgroundImage[26,18] = "Impassable";
		backgroundImage[27,18] = "Impassable";
		backgroundImage[28,18] = "Impassable";
		backgroundImage[29,18] = "Impassable";
		
		backgroundImage[0,19] = "Impassable";
		backgroundImage[1,19] = "Impassable";
		backgroundImage[2,19] = "Impassable";
		backgroundImage[3,19] = "Impassable";
		backgroundImage[4,19] = "Impassable";
		backgroundImage[5,19] = "Impassable";
		backgroundImage[6,19] = "Impassable";
		backgroundImage[7,19] = "Impassable";
		backgroundImage[8,19] = "Impassable";
		backgroundImage[9,19] = "Impassable";
		backgroundImage[10,19] = "Impassable";
		backgroundImage[11,19] = "Impassable";
		backgroundImage[12,19] = "Impassable";
		backgroundImage[13,19] = "Impassable";
		backgroundImage[14,19] = "Impassable";
		backgroundImage[15,19] = "Impassable";
		backgroundImage[16,19] = "Impassable";
		backgroundImage[17,19] = "Impassable";
		backgroundImage[18,19] = "Impassable";
		backgroundImage[19,19] = "Impassable";
		backgroundImage[20,19] = "Impassable";
		backgroundImage[21,19] = "Impassable";
		backgroundImage[22,19] = "Impassable";
		backgroundImage[23,19] = "Impassable";
		backgroundImage[24,19] = "Impassable";
		backgroundImage[25,19] = "Impassable";
		backgroundImage[26,19] = "Impassable";
		backgroundImage[27,19] = "Impassable";
		backgroundImage[28,19] = "Impassable";
		backgroundImage[29,19] = "Impassable";
		
		backgroundImage[0,20] = "Impassable";
		backgroundImage[1,20] = "Impassable";
		backgroundImage[2,20] = "Impassable";
		backgroundImage[3,20] = "Impassable";
		backgroundImage[4,20] = "Impassable";
		backgroundImage[5,20] = "Impassable";
		backgroundImage[6,20] = "Impassable";
		backgroundImage[7,20] = "Impassable";
		backgroundImage[8,20] = "Impassable";
		backgroundImage[9,20] = "Impassable";
		backgroundImage[10,20] = "Impassable";
		backgroundImage[11,20] = "Impassable";
		backgroundImage[12,20] = "Impassable";
		backgroundImage[13,20] = "Impassable";
		backgroundImage[14,20] = "Impassable";
		backgroundImage[15,20] = "Impassable";
		backgroundImage[16,20] = "Impassable";
		backgroundImage[17,20] = "Impassable";
		backgroundImage[18,20] = "Impassable";
		backgroundImage[19,20] = "Impassable";
		backgroundImage[20,20] = "Impassable";
		backgroundImage[21,20] = "Impassable";
		backgroundImage[22,20] = "Impassable";
		backgroundImage[23,20] = "Impassable";
		backgroundImage[24,20] = "Impassable";
		backgroundImage[25,20] = "Impassable";
		backgroundImage[26,20] = "Impassable";
		backgroundImage[27,20] = "Impassable";
		backgroundImage[28,20] = "Impassable";
		backgroundImage[29,20] = "Impassable";
		
		backgroundImage[0,21] = "Impassable";
		backgroundImage[1,21] = "Impassable";
		backgroundImage[2,21] = "Impassable";
		backgroundImage[3,21] = "Impassable";
		backgroundImage[4,21] = "Impassable";
		backgroundImage[5,21] = "Impassable";
		backgroundImage[6,21] = "Impassable";
		backgroundImage[7,21] = "Impassable";
		backgroundImage[8,21] = "Impassable";
		backgroundImage[9,21] = "Impassable";
		backgroundImage[10,21] = "Impassable";
		backgroundImage[11,21] = "Impassable";
		backgroundImage[12,21] = "Impassable";
		backgroundImage[13,21] = "Impassable";
		backgroundImage[14,21] = "Impassable";
		backgroundImage[15,21] = "Impassable";
		backgroundImage[16,21] = "Impassable";
		backgroundImage[17,21] = "Impassable";
		backgroundImage[18,21] = "Impassable";
		backgroundImage[19,21] = "Impassable";
		backgroundImage[20,21] = "Impassable";
		backgroundImage[21,21] = "Impassable";
		backgroundImage[22,21] = "Impassable";
		backgroundImage[23,21] = "Impassable";
		backgroundImage[24,21] = "Impassable";
		backgroundImage[25,21] = "Impassable";
		backgroundImage[26,21] = "Impassable";
		backgroundImage[27,21] = "Impassable";
		backgroundImage[28,21] = "Impassable";
		backgroundImage[29,21] = "Impassable";
		
		backgroundImage[0,22] = "Impassable";
		backgroundImage[1,22] = "Impassable";
		backgroundImage[2,22] = "Impassable";
		backgroundImage[3,22] = "Impassable";
		backgroundImage[4,22] = "Impassable";
		backgroundImage[5,22] = "Impassable";
		backgroundImage[6,22] = "Impassable";
		backgroundImage[7,22] = "Impassable";
		backgroundImage[8,22] = "Impassable";
		backgroundImage[9,22] = "Impassable";
		backgroundImage[10,22] = "Impassable";
		backgroundImage[11,22] = "Impassable";
		backgroundImage[12,22] = "Impassable";
		backgroundImage[13,22] = "Impassable";
		backgroundImage[14,22] = "Impassable";
		backgroundImage[15,22] = "Impassable";
		backgroundImage[16,22] = "Impassable";
		backgroundImage[17,22] = "Impassable";
		backgroundImage[18,22] = "Impassable";
		backgroundImage[19,22] = "Impassable";
		backgroundImage[20,22] = "Impassable";
		backgroundImage[21,22] = "Impassable";
		backgroundImage[22,22] = "Impassable";
		backgroundImage[23,22] = "Impassable";
		backgroundImage[24,22] = "Impassable";
		backgroundImage[25,22] = "Impassable";
		backgroundImage[26,22] = "Impassable";
		backgroundImage[27,22] = "Impassable";
		backgroundImage[28,22] = "Impassable";
		backgroundImage[29,22] = "Impassable";
		
		backgroundImage[0,23] = "Impassable";
		backgroundImage[1,23] = "Impassable";
		backgroundImage[2,23] = "Impassable";
		backgroundImage[3,23] = "Impassable";
		backgroundImage[4,23] = "Impassable";
		backgroundImage[5,23] = "Impassable";
		backgroundImage[6,23] = "Impassable";
		backgroundImage[7,23] = "Impassable";
		backgroundImage[8,23] = "Impassable";
		backgroundImage[9,23] = "Impassable";
		backgroundImage[10,23] = "Impassable";
		backgroundImage[11,23] = "Impassable";
		backgroundImage[12,23] = "Impassable";
		backgroundImage[13,23] = "Impassable";
		backgroundImage[14,23] = "Impassable";
		backgroundImage[15,23] = "Impassable";
		backgroundImage[16,23] = "Impassable";
		backgroundImage[17,23] = "Impassable";
		backgroundImage[18,23] = "Impassable";
		backgroundImage[19,23] = "Impassable";
		backgroundImage[20,23] = "Impassable";
		backgroundImage[21,23] = "Impassable";
		backgroundImage[22,23] = "Impassable";
		backgroundImage[23,23] = "Impassable";
		backgroundImage[24,23] = "Impassable";
		backgroundImage[25,23] = "Impassable";
		backgroundImage[26,23] = "Impassable";
		backgroundImage[27,23] = "Impassable";
		backgroundImage[28,23] = "Impassable";
		backgroundImage[29,23] = "Impassable";
		
		backgroundImage[0,24] = "Impassable";
		backgroundImage[1,24] = "Impassable";
		backgroundImage[2,24] = "Impassable";
		backgroundImage[3,24] = "Impassable";
		backgroundImage[4,24] = "Impassable";
		backgroundImage[5,24] = "Impassable";
		backgroundImage[6,24] = "Impassable";
		backgroundImage[7,24] = "Impassable";
		backgroundImage[8,24] = "Impassable";
		backgroundImage[9,24] = "Impassable";
		backgroundImage[10,24] = "Impassable";
		backgroundImage[11,24] = "Impassable";
		backgroundImage[12,24] = "Impassable";
		backgroundImage[13,24] = "Impassable";
		backgroundImage[14,24] = "Impassable";
		backgroundImage[15,24] = "Impassable";
		backgroundImage[16,24] = "Impassable";
		backgroundImage[17,24] = "Impassable";
		backgroundImage[18,24] = "Impassable";
		backgroundImage[19,24] = "Impassable";
		backgroundImage[20,24] = "Impassable";
		backgroundImage[21,24] = "Impassable";
		backgroundImage[22,24] = "Impassable";
		backgroundImage[23,24] = "Impassable";
		backgroundImage[24,24] = "Impassable";
		backgroundImage[25,24] = "Impassable";
		backgroundImage[26,24] = "Impassable";
		backgroundImage[27,24] = "Impassable";
		backgroundImage[28,24] = "Impassable";
		backgroundImage[29,24] = "Impassable";
		
		backgroundImage[0,25] = "Impassable";
		backgroundImage[1,25] = "Impassable";
		backgroundImage[2,25] = "Impassable";
		backgroundImage[3,25] = "Impassable";
		backgroundImage[4,25] = "Impassable";
		backgroundImage[5,25] = "Impassable";
		backgroundImage[6,25] = "Impassable";
		backgroundImage[7,25] = "Impassable";
		backgroundImage[8,25] = "Impassable";
		backgroundImage[9,25] = "Impassable";
		backgroundImage[10,25] = "Impassable";
		backgroundImage[11,25] = "Impassable";
		backgroundImage[12,25] = "Impassable";
		backgroundImage[13,25] = "Impassable";
		backgroundImage[14,25] = "Impassable";
		backgroundImage[15,25] = "Impassable";
		backgroundImage[16,25] = "Impassable";
		backgroundImage[17,25] = "Impassable";
		backgroundImage[18,25] = "Impassable";
		backgroundImage[19,25] = "Impassable";
		backgroundImage[20,25] = "Impassable";
		backgroundImage[21,25] = "Impassable";
		backgroundImage[22,25] = "Impassable";
		backgroundImage[23,25] = "Impassable";
		backgroundImage[24,25] = "Impassable";
		backgroundImage[25,25] = "Impassable";
		backgroundImage[26,25] = "Impassable";
		backgroundImage[27,25] = "Impassable";
		backgroundImage[28,25] = "Impassable";
		backgroundImage[29,25] = "Impassable";
		
		backgroundImage[0,26] = "Impassable";
		backgroundImage[1,26] = "Impassable";
		backgroundImage[2,26] = "Impassable";
		backgroundImage[3,26] = "Impassable";
		backgroundImage[4,26] = "Impassable";
		backgroundImage[5,26] = "Impassable";
		backgroundImage[6,26] = "Impassable";
		backgroundImage[7,26] = "Impassable";
		backgroundImage[8,26] = "Impassable";
		backgroundImage[9,26] = "Impassable";
		backgroundImage[10,26] = "Impassable";
		backgroundImage[11,26] = "Impassable";
		backgroundImage[12,26] = "Impassable";
		backgroundImage[13,26] = "Impassable";
		backgroundImage[14,26] = "Impassable";
		backgroundImage[15,26] = "Impassable";
		backgroundImage[16,26] = "Impassable";
		backgroundImage[17,26] = "Impassable";
		backgroundImage[18,26] = "Impassable";
		backgroundImage[19,26] = "Impassable";
		backgroundImage[20,26] = "Impassable";
		backgroundImage[21,26] = "Impassable";
		backgroundImage[22,26] = "Impassable";
		backgroundImage[23,26] = "Impassable";
		backgroundImage[24,26] = "Impassable";
		backgroundImage[25,26] = "Impassable";
		backgroundImage[26,26] = "Impassable";
		backgroundImage[27,26] = "Impassable";
		backgroundImage[28,26] = "Impassable";
		backgroundImage[29,26] = "Impassable";
		
		backgroundImage[0,27] = "Impassable";
		backgroundImage[1,27] = "Impassable";
		backgroundImage[2,27] = "Impassable";
		backgroundImage[3,27] = "Impassable";
		backgroundImage[4,27] = "Impassable";
		backgroundImage[5,27] = "Impassable";
		backgroundImage[6,27] = "Impassable";
		backgroundImage[7,27] = "Impassable";
		backgroundImage[8,27] = "Impassable";
		backgroundImage[9,27] = "Impassable";
		backgroundImage[10,27] = "Impassable";
		backgroundImage[11,27] = "Impassable";
		backgroundImage[12,27] = "Impassable";
		backgroundImage[13,27] = "Impassable";
		backgroundImage[14,27] = "Impassable";
		backgroundImage[15,27] = "Impassable";
		backgroundImage[16,27] = "Impassable";
		backgroundImage[17,27] = "Impassable";
		backgroundImage[18,27] = "Impassable";
		backgroundImage[19,27] = "Impassable";
		backgroundImage[20,27] = "Impassable";
		backgroundImage[21,27] = "Impassable";
		backgroundImage[22,27] = "Impassable";
		backgroundImage[23,27] = "Impassable";
		backgroundImage[24,27] = "Impassable";
		backgroundImage[25,27] = "Impassable";
		backgroundImage[26,27] = "Impassable";
		backgroundImage[27,27] = "Impassable";
		backgroundImage[28,27] = "Impassable";
		backgroundImage[29,27] = "Impassable";
		
		backgroundImage[0,28] = "Impassable";
		backgroundImage[1,28] = "Impassable";
		backgroundImage[2,28] = "Impassable";
		backgroundImage[3,28] = "Impassable";
		backgroundImage[4,28] = "Impassable";
		backgroundImage[5,28] = "Impassable";
		backgroundImage[6,28] = "Impassable";
		backgroundImage[7,28] = "Impassable";
		backgroundImage[8,28] = "Impassable";
		backgroundImage[9,28] = "Impassable";
		backgroundImage[10,28] = "Impassable";
		backgroundImage[11,28] = "Impassable";
		backgroundImage[12,28] = "Impassable";
		backgroundImage[13,28] = "Impassable";
		backgroundImage[14,28] = "Impassable";
		backgroundImage[15,28] = "Impassable";
		backgroundImage[16,28] = "Impassable";
		backgroundImage[17,28] = "Impassable";
		backgroundImage[18,28] = "Impassable";
		backgroundImage[19,28] = "Impassable";
		backgroundImage[20,28] = "Impassable";
		backgroundImage[21,28] = "Impassable";
		backgroundImage[22,28] = "Impassable";
		backgroundImage[23,28] = "Impassable";
		backgroundImage[24,28] = "Impassable";
		backgroundImage[25,28] = "Impassable";
		backgroundImage[26,28] = "Impassable";
		backgroundImage[27,28] = "Impassable";
		backgroundImage[28,28] = "Impassable";
		backgroundImage[29,28] = "Impassable";
		

		
		
	}
	
	
}
