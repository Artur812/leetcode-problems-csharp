//Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

//If target is not found in the array, return [-1, -1].

//You must write an algorithm with O(log n) runtime complexity.


public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] result;
        int first_index = Array.IndexOf(nums, target);
        int last_index = Array.LastIndexOf(nums, target);
        if (first_index > -1 && last_index > -1)
            result = new int[]{ first_index,  last_index };
        else
            result = new int[] { -1,  -1 };
        return result;
    }
}
