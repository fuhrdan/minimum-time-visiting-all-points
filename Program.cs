//*****************************************************************************
//** 1266. Minimum Time Visiting All Points                         leetcode **
//*****************************************************************************
//** Vectorized Integer Steps In Time                                        **
//** Between each point, seconds are measured by the larger of x or y        **
//** Diagonal strides steal distance from both directions at once            **
//** So order is honored, and the clock ticks only as far as it must         **
//*****************************************************************************

int minTimeToVisitAllPoints(int** points, int pointsSize, int* pointsColSize) {
    int retnum = 0;
    for(int i = 1; i < pointsSize; i++)
    {
        int dx = abs(points[i][0] - points[i - 1][0]);
        int dy = abs(points[i][1] - points[i - 1][1]);
        if(dx > dy) retnum += dx;
        else retnum += dy;
    }
    return retnum;
}