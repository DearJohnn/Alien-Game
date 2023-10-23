-> main

=== main ===
Hello,I lost my credit cards. Could you help me fond it?
    + Sure!
    Don't worry, I'm willing to help you search. Where do you think you might have lost it?
        -> Sure
        
        
=== Sure ===
 I'm not sure, it could be in the parking lot, the park, or maybe in the hospital restroom.
    + Alright, I'll check those places first. 
    If I find it, would you be willing to offer a reward of 500 coins?
        ->Coins

=== Coins ===
 Absolutely! Getting my card back is worth much more than 500 coins.
    + Please stay in touch, and if there's any news, I'll let you know immediately.
        ->MakeMoney
        
=== MakeMoney ===
->END