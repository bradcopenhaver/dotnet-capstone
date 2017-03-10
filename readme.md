# HaloClipFinder

HaloClipFinder was created to provide a quick reference for Halo 5 players to see when significant events happened in their recent games so that they can then find those events quickly and easily in Halo 5 Theater mode. Unfortunately, it is currently failing in that endeavor because Theater mode has no visible timer that relates to the timing data provided for game events. The app uses the Halo Public API to retrieve match histories for individual players and then display the time in match when that player earned any medal.

## Setup and Installation

The best way to view this app on your local machine is to use Microsoft Visual Studio.
* [Git](https://git-scm.com/)
* [Microsoft Visual Studio](https://www.visualstudio.com/downloads/)

Get a Developer Access subscription from the [Halo Public API](https://developer.haloapi.com/products). Clone this repository and open the solution file `HaloClipFinder.sln`. In the solution's `Models` folder, create a file `EnvironmentVariables.cs` and save your Halo Public API Keys as `HaloApiKey` and `HaloApiKey2`.
