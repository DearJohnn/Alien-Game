INCLUDE globals.ink
{firstTalkWithAnna == false: -> main | -> AskToTalkToDoctor}
-> main

=== main ===

    What can I help you? #speaker:Anna #layout:left
    + [Hello, can I see a doctor, please?]
        Hello, can I see a doctor, please?#speaker:Me #layout:right
        -> SeeDoctor
        
        
=== SeeDoctor ===
Certainly. Do you have an appointment? #speaker:Anna #layout:left
    +[ I don't have an appointment.]
        Sorry, I don't have an appointment.#speaker:Me #layout:right
        ->Illness

===Illness===
    I have a strange illness, getting weaker day by day. 
    Earth doctors can't help me, so I want to see a doctor from another planet.
        ->Appointment

=== Appointment ===
No problem, alien doctor can assist you with that. #speaker:Anna #layout:left
Please go straight, then turn left and you'll find the doctors in the room on your left.
Doctor Arthur will assist you.
    +[Thank you!]
        Go straight and then turn left, got it. Thank you!#speaker:Me #layout:right
        ->Welcome
    
=== Welcome ===
You're welcome! I hope you recover soon. #speaker:Anna #layout:left
If you have any other questions, feel free to ask me. Best of luck!
~ firstTalkWithAnna = true
->END

=== AskToTalkToDoctor ===
Did you find Dr. Arthur?#speaker:Anna #layout:left
    +[I can't find him]
        ->CannotFind

=== CannotFind===
Sorry, I can't find him. Can you tell me again how to find him?#speaker:Me #layout:right
    ->Repeat

===Repeat===
Please go straight, then turn left and you'll find the doctors in the room on your left.#speaker:Anna #layout:left
        +[Thank you!]
            Go straight and then turn left, got it. Thank you!#speaker:Me #layout:right
            ->END