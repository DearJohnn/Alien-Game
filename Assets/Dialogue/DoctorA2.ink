INCLUDE globals.ink
-> main

===main===
Have you prepared enough money? #speaker:Arthur #layout:left
    +[Yes]Yes,I helped Bob find his credit card and he gave me a lot of coins. #speaker:Me #layout:right
        ->Start
    +[Not yet]Not yet. I need more time.#speaker:Me #layout:right
    ->END
    
===Start===
Let us begin the treatment, and you will soon be well again.#speaker:Arthur #layout:left
    +[Great!]Great!#speaker:Me #layout:right
    ~ rehabilitation = "health"
    ->END