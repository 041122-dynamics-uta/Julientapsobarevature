#!/bin/bash
echo Hello welcome to your calculator! 
 echo Please choose a function of your choice
num1=$1
num2=$2
if [ $# == 0 ] ; then
while true
do

    echo 1. Addition
    echo 2. Subtraction
    echo 3. Multiplication
    echo 4. Division
    echo 5. Exit
    echo please, Enter your choice
    read choice

if [ $choice == 1 ]; then
     echo your choice is Addition
     echo Enter your first number
     read num1
     echo Enter a second number
     read num2
     echo result
     echo The sum of $num1 and $num2 is $((num1+num2)) 
     
elif [ $choice == 2 ]; then
    echo Your choice is substraction 
    echo Enter your first number
    read num1
    echo Enter a second number
    read num2
    echo result
    echo The difference of $num1 and $num2 is $((num1 - num2)) 
    
elif [ $choice == 3 ]; then
    echo Your choice is multiplication
    echo Pleae enter your first number
    read num1
    echo Enter a second number
    read num2
    echo result 
    echo The product of $num1 and $num2 is $((num1 * num2))

elif [ $choice == 4 ]; then
    echo Your choice is division
    echo Enter your first number
    read num1
    echo Enter a second number
    read num2
    echo result
    echo The result of  $num1 and $num2 is $((num1 / num2))

elif [ $choice == 5 ]; then
    exit
else
    echo Invalid entry... please choose the numbers listed above
    
    
    fi  
 done
fi
    




   

 






    
    
    
