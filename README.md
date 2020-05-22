# CookieClicker


## 1. Слики од играта

Initial Screen<br/>

![Initial Screen](https://i.imgur.com/QXYYx9Y.png "Initial Screen")

The Game<br/>

![Game](https://i.imgur.com/JScdC4U.png "The Game")


## 2. Game Description

Cookie Clicker is an 'idle' game with a very simple concept, that in the past few years has become more and 
more popular among flash and mobile games. The idea of an 'idle' game is that a player initially starts with 
zero 'coins', or any other currency, and then with the purchase of new upgrades and powerups he begins to earn
a lot more. This is a typical example of a snowball principle, where with each subsequent upgrade the profit 
gained in one second increases. The main purpose of the 'idle' aspect is that the player can leave the game,
and in the background his 'workers' will make him more money.

![Original Game](https://i.kinja-img.com/gawker-media/image/upload/s--JNu4Td2L--/c_scale,f_auto,fl_progressive,q_80,w_800/kggronat2bhshdyycncx.png "Оригиналната игра")

## 3. How to play

In Cookie Clicker, the 'currency' is cookies and the player's goal is to get as many of them as possible. With each click on the large cookie, the number of cookies increases by one. Buying one of the upgrades:
- Finger
- Grandma
- Robot <br/>

the player increases the number of cookies produced per second. Of courses, upgrades that produce more cookies 
are more expensive, but are a better investment. With each purchase, the price of the following purchase
increases, so that the game is more balanced. The background itself is made on an interactive principle, with 
the more cookies produced per second, the more cookies begin to 'rain'.

## 4. Implementation

The main class in the game is CookieGame, which calculates how many cookies the player has at the moment and
how many are produced per second. Additionally, in this class we calculate the cookies spent with each purchase.
In `Cookie`, we've implemented a 'clicking' effect that toggles an image animation with each press on the cookie.
Each type of PowerUp inherits from the abstract class `PowerUp`. The `PowerUpRates` class calculates the prices
for each upgrade and how they increase. The animation with which the cookies fall effect is achieved is inside
`Fall` and `FallDoc`. 
