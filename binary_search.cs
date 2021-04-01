public class Solution {
  public int PeakIndexInMountainArray(int[] A) {
    if(A.Length < 3 ){
      return 0;
    }
    
    int start = 0;
    int end = A.Length - 1;
    int mid = 0;
    
    while(start <= end){
      mid = (start + end)/2;
      if(A[mid] > A[mid + 1] && A[mid] > A[mid - 1]){
        break;
      }
      
      if(A[mid] < A[mid + 1]){
        start = mid + 1;
      }else if(A[mid] < A[mid - 1]){
        end = mid - 1;
      }
    }
    
    return mid;
  }
}

