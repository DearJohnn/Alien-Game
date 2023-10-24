INCLUDE globals.ink
{firstTalkWithDoctor == false : -> Finding | -> main}
-> main

===Finding===
I'm looking for something. Don't bother me.#speaker:Bob #layout:left
    ->END
    
=== main ===

Hello,I lost my credit cards. Could you help me fond it? #speaker:Bob #layout:left
    + [Sure!]
    Don't worry, I'm willing to help you search. Where do you think you might have lost it? #speaker:Me #layout:right
        -> Sure
        
        
=== Sure ===
 I'm not sure, it could be in the parking lot, the park, or maybe in the hospital restroom. #speaker:Bob #layout:left
    + [Alright, I'll check those places first. ]
        If I find it, would you be willing to offer a reward of 500 coins? #speaker:Me #layout:right
        ->Coins

=== Coins ===
 Absolutely! Getting my card back is worth much more than 500 coins. #speaker:Bob #layout:left
    + [Great!]
        Please stay in touch, and if there's any news, I'll let you know immediately.#speaker:Me #layout:right
        ~firstTalkWithDoctor = true
            ->END