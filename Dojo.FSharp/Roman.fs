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
    
   
let  rec convert x =
        if(x>=10 && x<40) then
            "X" + convert(x-10)
        elif(is_left_of(x, { num="L"; decimal_num = 50; left_bound = 40; right_bound = 90;})) then
            convert(50-x) + "L"
        elif(is_right_of(x, { num="L"; decimal_num = 50; left_bound = 40; right_bound = 90;})) then
            "L" + convert(x-50)
        elif(x >= 100) then
            "C" + convert(x-100)
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
            
    
           

