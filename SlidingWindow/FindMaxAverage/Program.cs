// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] nums = { 1, 12, -5, -6, 50, 3 };
int k = 4;

Console.WriteLine(FindMaxAverage(nums, k));
int []nums1 = { 5 };
Console.WriteLine(FindMaxAverage(nums1, 1));


static double FindMaxAverage(int[]num,int k)
{
    int left = 1, right = k;
    double max = 0, sum = 0;

    for(int i=0;i<k;i++)
    {
        sum = sum + num[i];
    }
    max = sum / k;

    while(right < num.Length)
    {
        sum = sum + num[right];
        sum = sum - num[left - 1];

        if(max < (sum / k))
            max = sum / k;
        right = right + 1;
        left = left + 1;
    }
    return max;

}