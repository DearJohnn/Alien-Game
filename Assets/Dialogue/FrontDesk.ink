-> main

=== main ===
What can I help you?
    + Hello, can I see a doctor, please?
        -> SeeDoctor
        
        
=== SeeDoctor ===
Certainly. Do you have an appointment?
    + I don't have an appointment.
    I have a strange illness, getting weaker day by day. Earth doctors can't help me, so I want to see a doctor from another planet.
        ->Appointment

=== Appointment ===
No problem, I can assist you with that. Please go straight, then turn left and you'll find the doctors in the room on your left. They will assist you.
    + Go straight and then turn left, got it. Thank you!
        ->Welcome
        
=== Welcome ===
You're welcome! I hope you recover soon. If you have any other questions, feel free to ask me. Best of luck!
->END