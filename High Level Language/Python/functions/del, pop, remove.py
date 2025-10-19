#lets del function
my_list = [1, 2, 3]
del my_list[1]  #del basically just deletes an element from the list
print(my_list)  

#pop function
my_list = [4, 5, 6]
item = my_list.pop(1) #pop basically removes the element of the list and stores it in another element.
print(my_list)  
print(item)      

#remove function
my_list = [1, 2, 3, 2]
my_list.remove(2) #removes the element according to the argument inside the function. 
print(my_list)  

#clears the whole list
my_list = [1, 2, 3]
my_list.clear()
print(my_list)  # Output: []

