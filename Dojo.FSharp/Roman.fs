// Learn more about F# at http://fsharp.net
#light
module Roman
open System

let  rec convert x =
        if(x>=10 && x<40) then
            "X" + convert(x-10)
        elif(x>=40 && x<50) then
            convert(50-x) + "L"
        elif(x>=50 && x<90) then
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
            
    
           

