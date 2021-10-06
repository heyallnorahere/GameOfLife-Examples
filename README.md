# GameOfLife examples

Some examples for [my implementation](https://github.com/yodasoda1219/GameOfLife) of [Conway's Game of Life](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life).

To run an example:
```bash
# On Unix systems

# Make sure to build first
dotnet build

# Run an example
dotnet bin/Launcher.dll example-name $ADDITIONAL_ARGS
```
```cmd
rem On Windows

rem Build
dotnet build

rem Run an example
dotnet bin\Launcher.dll example-name %ADDITIONAL_ARGS%
```