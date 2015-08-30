﻿using UnityEngine;
using System.Collections;

public class ExplorationImage  : ScriptableObject
{
	
	public string[,] backgroundImage = new string[30, 16];
	
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
		
		
	}
	
	
}
