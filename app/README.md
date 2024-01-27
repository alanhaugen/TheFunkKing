# The King's Mood

King has gone through a tragedy. He is in a funk. Cheer him up!

You decide who gets to entertain the king.

Increase the king's Laugh meter

Bring the kingdom out of mourning 

# Instructions

## Instructions for use of the QtCreator (Download from qt.io) qbs build system

Open chess.qbs with QtCreator

Change the run working directory to the following:

> %{sourceDir}/intermediate

Add the following build step before qbs build

For Unix:

> make acp

For Windows, please add /c/Program\ Files/Git/usr/bin to your PATH and use mingw make:

> mingw32-make.exe acp

For this build step, regardless of platform, change the build working directory to the following:

> %{sourceDir}

Also, to Run set the following for working directory (QtCreator does not seem to expand variables here for some reason):

> /Users/username/chess/intermediate
