# Educating The Player
Making Game Educating The Player without speech or text.

In this game i try to design a game that does not tell the player exactly how to play! by avoid using text or prompts that inform the player on game mechanics or where to go.

To warning player from dangers zoon and find him way to goal.I use sounds, lights, and 3d Modeling.


This is game demo  [Find Your Way In Space](https://maha-sh.itch.io/findyourwayinspace).

Game scene screenshout.

<img src="https://user-images.githubusercontent.com/87305604/155496330-f939ddf1-01c4-4413-a533-ceacfba87435.png" width="547.5" height="253.5">

First,I designed a particle system to look like caterpillars guiding you to the right path in the game

<img src="https://user-images.githubusercontent.com/87305604/155493492-2febad8e-20e9-4666-a32d-3c54d50cbd8a.png" width="489" height="366">

*Spaceship hazard* has particle system with damages ability to the player you can found it in ParticlesystemDamage.cs.


<img src="https://user-images.githubusercontent.com/87305604/155487927-73bb5c2a-994d-447d-8095-7813476d738d.png" width="362" height="339">

also,I coding a *Laser Gun* to be the second hazard in these Game level you can found it in LaserGun.cs 

<img src="https://user-images.githubusercontent.com/87305604/155488991-a698baf0-7e3c-43b0-b44d-e4d83638432d.png" width="415" height="404">

Finally, i try guide the player to the *goal* by the road design in the game scene,then i spawn the particle system to show the goal has been reached
you can find goal partical in GoalPartical.cs

<img src="https://user-images.githubusercontent.com/87305604/155490569-bb27baef-b13e-40d7-925b-9a5df2c6b5f4.png" width="404" height="435">
