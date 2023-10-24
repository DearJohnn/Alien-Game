INCLUDE globals.ink

{ firstTalkWithAnna == false: ->Appointment | -> main}

===Appointment===
Please make an appointment at the front desk! #speaker:Arthur #layout:left
->END

-> main
=== main ===
{firstTalkWithDoctor == true: ->Pay  | ->Hello}

===Pay===
Please pay for the treatment as soon as possible.#speaker:Arthur #layout:left
->END
===Hello===
Hello, I can assist you. Please tell me your symptoms.#speaker:Arthur #layout:left
    + [ feel so weak.]
    I feel extremely weak and have no energy. #speaker:Me #layout:right
    I feel like my life is slipping away every day.
        -> illness
        
        
=== illness ===
 It sounds like a rare disease from our planet. #speaker:Arthur #layout:left
 This illness requires specialized treatment; otherwise, it will continue to deplete your life force. 
 Luckily, we have a highly effective treatment, but it costs 500 coins.
    + [500 coins?] That's a lot of money, but I don't have that much. #speaker:Me #layout:right
        ->Coins

=== Coins ===
 I understand your difficulty, but if this condition isn't treated promptly, the consequences will be severe. #speaker:Arthur #layout:left
 If you're willing, I can negotiate with the hospital to see if they can provide some assistance.
    + [I'm willing to do everything] I'm willing to do everything I can to raise the treatment funds.#speaker:Me #layout:right
        ->MakeMoney
        
=== MakeMoney ===
Very well, I will arrange the treatment as soon as possible. Please rest assured; we will do our best to help you regain your health.#speaker:Arthur #layout:left
~ firstTalkWithDoctor = true
->END