# American Checkers
<strong>American Checkers game implemented in C# at .NET framework to windows application.</strong>


* In case we choose to play against the computer his moves are prioritized in this order:

Eating any soldier > Making any move that is not dangerous (meaning it can’t be eaten next step) > Making any move.</li>

* In case of a 'jump' over an opposing coin ("Eating" / "Capturing"), the
opposing man is eliminated. if there is another valid jump option for the
current coin the turn is still the current player's, and the following
jump(s) will be his only valid move(s).

* After a win/draw/quit the user will be asked to decide weather to play
another round or to quit the program

## Instructions

-Select size of game board

-Select weather to play against a computer upponent
or another human upponent. In case of another human uponent, enter the upponent's name

![image](https://user-images.githubusercontent.com/105008868/179564448-eec5e52c-67ac-40f0-a045-c07f6295d6ae.png)

*After the user fill the login form the game will start with an initialize board (8x8 example):*

![image](https://user-images.githubusercontent.com/105008868/179566379-111e6d1f-ec92-47d3-89a2-5dc8761e4f03.png)



## Score calculation
Each player that left on the board - 1 Point

Each King that left on the board - 4 Points
