list = [1,2,3,4,5,6,7,8,9,10]

target = 7


def binary_search(list, target):
  min = 0
  max = len(list)-1

  while min <= max:
    mid = (min+max)//2
    guess = list[mid]
    if guess == target:
      return mid
    if guess < target:
      min = mid+1
    else:
      max = mid-1
  return None


print(binary_search(list, target))