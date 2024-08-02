# First Person Cinema

Game link: https://jerffesonj.itch.io/cinema

<p align="center">
  <img src="https://i.imgur.com/bYpKGSu.png" width="75%" height="75%">
</p>
<p align="center">
 <i>Spider-Man Into the Spider-Verse</i>
</p>


<p align="center">
  <img src="https://img.itch.zone/aW1hZ2UvMjE3MjgyMC8xMjg0MzI3My5wbmc=/original/2aItU0.png" width="75%" height="75%">
</p>
<p align="center">
 <i>Turning Red</i>
</p>


<p align="center">
  <img src="https://img.itch.zone/aW1hZ2UvMjE3MjgyMC8xMjg0MzI5MC5wbmc=/original/4rCOhW.png" width="75%" height="75%">
</p>
<p align="center">
 <i>Alita: Battle Angel</i>
</p>

# How to Play

W A S D - Walk

Space - Jump

Mouse - Look around

To interact with the posters just look to the <b>Play</b>, it will start automatically.

# About
Game made in 5 days using Unity, using art assets from Mixamo and Sketchfab.

The main goal was to show three different videos and play it on a screen like a cinema.
To play the video inside of Unity was implemented the Youtube Player repository from iBicha and only with the video link the game plays automatically with no need to downloading it before building the game.

Repository used: https://github.com/iBicha/UnityYoutubePlayer/

To show the videos thumbnail I got the video ID from the youtube video link and used the <b><i>img.youtube</i></b> domain to join with the HD or SD file name on the end of the link.

To use the HD thumbnail: <blockquote>/maxresdefault.jpg</blockquote>

To use the SD thumbnail: <blockquote>/0.jpg</blockquote>

## Example: 

Video

<blockquote>https://www.youtube.com/watch?v=dQw4w9WgXcQ</blockquote>

[![Rick Astley - Never Gonna Give You Up (Official Music Video)](https://i.imgur.com/kJC5uyK.png)](https://youtu.be/dQw4w9WgXcQ?t=61 "Rickroll")

Link construction

<b><blockquote>ht<span>tps://img.youtube.com/vi/ + youtubeVideoId + hd or sd thumbnail </blockquote></b>

Result 

<blockquote>https://img.youtube.com/vi/dQw4w9WgXcQ/maxresdefault.jpg</blockquote>

<p align="center">
  <img src="https://img.youtube.com/vi/dQw4w9WgXcQ/maxresdefault.jpg">
</p>

or

<blockquote>https://img.youtube.com/vi/dQw4w9WgXcQ/0.jpg</blockquote>

<p align="center">
  <img src="https://img.youtube.com/vi/dQw4w9WgXcQ/0.jpg">
</p>
