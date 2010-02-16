// Learn more about F# at http://fsharp.net
#light
module Roman
open System
type RomanNumber ={
                    num:string;
                    decimal_num:int; 
                    left_bound:int; 
                    right_bound:int; 
                    }
 
let is_left_of(x, n:RomanNumber) =
    (x >= n.left_bound && x < n.decimal_num)

let is_right_of(x, n:RomanNumber) =
    (x >= n.decimal_num && x < n.right_bound)

let nums = [
            { num="L"; decimal_num = 50; left_bound = 40; right_bound = 90;};
            { num="C"; decimal_num = 100; left_bound = 90; right_bound = 400;}
            ]
    
   
let  rec convert x =
    
        if(x>=10 && x<40) then
            "X" + convert(x-10)
        elif(is_left_of(x, nums.Item(0))) then
            convert(nums.Item(0).decimal_num-x) + "L"
        elif(is_right_of(x, nums.Item(0))) then
            "L" + convert(x-nums.Item(0).decimal_num)
        elif(is_left_of(x, nums.Item(1))) then
            convert(nums.Item(1).decimal_num-x) + "C"
        elif(is_right_of(x, nums.Item(1))) then
            "C" + convert(x-nums.Item(1).decimal_num)
        else
            match Math.Abs((int)x) with
            | 0 -> ""
            | 1 -> "I"
            | 2 -> "II"
            | 3-> "III"
            | 4 -> "IV"
            | 5 -> "V"
            | 6 -> "VI"
            | 7 -> "VII"
            | 8 -> "VIII"
            | 9 -> "IX"
            | x -> ""
            
    
           

