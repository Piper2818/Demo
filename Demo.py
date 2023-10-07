# you can write to stdout for debugging purposes, e.g.
# print("this is a debug message")

def solution(A):
    # Implement your solution here
    A = list(set(A))
    A.sort()
    
    LowestNum = 1 
    Done = False 
    start = 0
    while(Done == False): 
        try: 
            spot = A.index(LowestNum, start)
            start = spot 
            A.remove(LowestNum)
            LowestNum = LowestNum + 1
            
        except ValueError: 
            Done = True 
        
    return LowestNum

if __name__ == '__main__': 
    num = [-3,-6,-8, 2,1, 3, 4]
    Ans =  solution(num) 
    print("The lowest number that does not occur in the list is:", Ans)
