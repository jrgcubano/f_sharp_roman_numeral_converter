#light
module RomanTests
open Xunit
open Roman

   
[<Fact>]
let one_is_converted_to_I() =
    Assert.Equal("I", Roman.convert 1)
    
[<Fact>]
let two_is_II() = 
    Assert.Equal("II", Roman.convert 2)
    
[<Fact>]
let three_is_III() =
    Assert.Equal("III", Roman.convert 3)
    
[<Fact>]
let ten_is_X() =
    Assert.Equal("X", Roman.convert 10)

[<Fact>]
let six_is_VI() =
    Assert.Equal("VI", Roman.convert 6) 
    
[<Fact>]
let eleven_is_XI() =
    Assert.Equal("XI", Roman.convert 11)
  
[<Fact>]
let five_is_V() =
    Assert.Equal("V", Roman.convert 5)

[<Fact>]
let forty_is_XL() =
    Assert.Equal("XL", Roman.convert 40)

[<Fact>]
let forty_nine_is_IL() =
    Assert.Equal("IL", Roman.convert 49)
    
[<Fact>]
let fifty_is_L() =
    Assert.Equal("L", Roman.convert 50)
    
[<Fact>]
let fifty_one_LI() =
    Assert.Equal("LI", Roman.convert 51)
   
[<Fact>]
let fifty_two_LII() =
    Assert.Equal("LII", Roman.convert 52)
[<Fact>]
let sixty_one_LXI() =
    Assert.Equal("LXI", Roman.convert 61)

[<Fact>]
let one_hundred_is_C() =
    Assert.Equal("C", Roman.convert 100)

[<Fact>]
let one_hundred_and_one_is_CI() =
    Assert.Equal("CI", Roman.convert 101)

[<Fact>]
let _200_is_CC() = 
    Assert.Equal("CC", Roman.convert 200)

[<Fact>]
let _211_is_CCXI() =
    Assert.Equal("CCXI", Roman.convert 211) 
