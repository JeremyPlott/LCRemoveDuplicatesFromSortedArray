This is pretty straightforward, although a little weird with what the problem wants as a return coupled with the modified in-place requirement.

```
"public class Solution {

	public int RemoveDuplicates(int[] nums)
{

	//we need to track the number of unique digits because it wants an integer return of that count.
	//this will also be the index of where we write our new numbers to the start of the array.
	var uniqueNums = 0;

	//we will iterate through the array to check every number
	for (int num = 0; num < nums.Length; num++)
	{
		//since this array is sorted its very easy to skip duplicates.
		//we use length - 1 and < because we will get out of range exceptions with the num + 1 index check.
		//if the current number = the next number, skip it.
		while (num < nums.Length - 1 && nums[num] == nums[num + 1]) num++;

		//the diplicate numbers have been skipped, so the current number must be unique.
		//add it to the start of the array
		nums[uniqueNums] = nums[num];

		//now increment our counter / unique number writer
		uniqueNums++;
	}

	//return the count of unique numbers. The site will check if the array has been modified.
	return uniqueNums;
}
}
```