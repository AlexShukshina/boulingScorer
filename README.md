# BoulingScorer
The program calculates the score of a game of bowling.
(Task from R.Martin book - "Agile Principles, Patterns, and Practices in C#")
I've made my version of this program. It's different from implementation in a book.


Game rules:
The game is played in ten frames. At the beginning of each frame, all ten pins are set up.
The player then gets two tries to knock them all down.
If the player knocks all the pins down on the first try, it is called a "strike," and the frame
ends. If the player fails to knock down all the pins with the first ball but succeeds with
the second ball, it is called a "spare." After the second ball of the frame, the frame ends
even if pins are still standing.

A strike frame is scored by adding ten, plus the number of pins knocked down by the
next two balls, to the score of the previous frame. A spare frame is scored by adding ten,
plus the number of pins knocked down by the next ball, to the score of the previous
frame. Otherwise, a frame is scored by adding the number of pins knocked down by the
two balls in the frame to the score of the previous frame.
If a strike is thrown in the tenth frame, the player may throw two more balls to complete
the score of the strike. Likewise, if a spare is thrown in the tenth frame, the player may
throw one more ball to complete the score of the spare. Thus, the tenth frame may have
three balls instead of two.
