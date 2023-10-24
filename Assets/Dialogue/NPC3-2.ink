INCLUDE globals.ink
{submitCard == false: ->main| ->Thanks}
->main

===Thanks===
Thank you so much!#speaker:Bob #layout:left
->END

===main===
Did you find my credit card? #speaker:Bob #layout:left
    +[Yes]Yes, I found it. #speaker:Me #layout:right
          Here it is.
        ->Return
    +[Not yet] I haven't found it yet#speaker:Me #layout:right
        ->END

===Return===
~submitCard = "submit"
Thank you so much!#speaker:Bob #layout:left
->END