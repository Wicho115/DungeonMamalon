using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Oscar
public static class Globals
{
    public static int level = 0;
    public static List<List<int[]>> waves = new List<List<int[]>>()
    {
        new List<int[]>(){new int[] {5,0,13},new int[] {50,1,16},new int[] {10,0,18},new int[] {10,1,10},new int[] {10,0,10},new int[] {1,1,12}},
        new List<int[]>(){new int[] {10,0,5},new int[] {5,0,6},new int[] {30,1,8},new int[] {30,0,10},new int[] {30,0,10},new int[] {1,0,12} },
        new List<int[]>(){new int[] {50,0,5},new int[] {50,0,6},new int[] {50,0,8},new int[] {50,0,10},new int[] {50,0,10},new int[] {1,0,12} },
        new List<int[]>(){new int[] {50,0,5},new int[] {50,0,6},new int[] {50,0,8},new int[] {50,0,10},new int[] {50,0,10},new int[] {1,0,12} },
        new List<int[]>(){new int[] {50,0,5},new int[] {50,0,6},new int[] {50,0,8},new int[] {50,0,10},new int[] {50,0,10},new int[] {1,0,12} },
        new List<int[]>(){new int[] {50,0,5},new int[] {50,0,6},new int[] {50,0,8},new int[] {50,0,10},new int[] {50,0,10},new int[] {1,0,12} },
        new List<int[]>(){new int[] {50,0,5},new int[] {50,0,6},new int[] {50,0,8},new int[] {50,0,10},new int[] {50,0,10},new int[] {1,0,12} },
        new List<int[]>(){new int[] {50,0,5},new int[] {50,0,6},new int[] {50,0,8},new int[] {50,0,10},new int[] {50,0,10},new int[] {1,0,12} },

    };

    public static int life = 3;
}
