Check if the given point belongs to the given line.

Example

For point = [0, 1] and line = [1, 1, 0], the output should be
pointInLine(point, line) = false;
For point = [1, -1] and line = [1, 1, 0], the output should be
pointInLine(point, line) = true.


bool pointInLine(int[] point, int[] line) {

    if(((point[0] * line[0]) + (point[1] * line[1]) + line[2]) == 0)
        return true;
    
    return false;
   
}
