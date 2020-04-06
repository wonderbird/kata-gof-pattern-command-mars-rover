# Mars Rover

In this kata you implement the Gang Of Four Command Pattern [[1](#ref-1), [2](#ref-2), [3](#ref-3)].

Origins:

- ThoughtWork interviews (without reference, hearsay)
- Victor Farcic: [Java Tutorial Through Katas: Mars Rover](https://technologyconversations.com/2014/10/17/java-tutorial-through-katas-mars-rover/)
- Priyank Gupta: [Mars Rover](https://github.com/priyaaank/MarsRover/blob/master/README.md)
- Kata-Log.rocks: [Mars Rover Kata](https://kata-log.rocks/mars-rover-kata)

## Problem Description

A robotic rover is to be landed by NASA on a plateau on Mars. This plateau, which is curiously rectangular, must be navigated by the rover so that its on-board cameras can get a complete view of the surrounding terrain to send back to Earth. The rover's position and location is represented by a combination of x and y coordinates and a letter representing one of the four cardinal compass points. The plateau is divided up into a grid to simplify navigation. An example position might be 0, 0, N, which means the rover is in the bottom left corner and facing north. In order to control the rover, NASA sends a simple string of letters. The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively, without moving from its current spot. 'M' means move forward one grid point, and maintain the same heading.

Assume that the square directly North from (x, y) is (x, y+1).

Develop an api that moves a rover around on a grid.

## Requirements

### Input

Input is provided as a string. The string contains space separated numbers, characters and character sequences. Example: 5 6 1 2 N LMLMRMM

* **1st and 2nd integer**: Upper right coordinates of the plateau (x, y). The lower left is assumed to be (0, 0).

* **3rd and 4th integer**: Initial rover position (x, y).

* **5th character**: Initial rover orientation. One of 'N', 'E', 'S', 'W'.

* **6th character sequence**: Series of instructions telling the rover how to explore the plateau. A character in this series can be one of 'L', 'R', 'M'.

### Requirements

Goal: You are given the input described above. Move the rover according to the input. Finally return a string giving the new rover position and orientation.

* Implement commands that move the rover forward (M).
* Implement commands that turn the rover left/right (L,R).
* If a command is malformed, then print an appropriate message.
* Implement wrapping from one edge of the grid to another. (planets are spheres after all)
* Implement obstacle detection before each move to a new square. If a given sequence of commands encounters an obstacle, the rover moves up to the last possible point and reports the obstacle.

## Rules

* Hardcore TDD. No Excuses!
* Be careful about edge cases and exceptions. We can not afford to lose a mars rover, just because the developers overlooked a null pointer.

## Suggested Test Cases

Sample input:

```
5 5 1 2 N LFLFLFLFF
5 5 3 3 E MMRMMRMRRM
...
```

Sample output:

```
1 3 N
5 1 E
...
```

## Finishing Touches

- Avoid duplicated code (use `tools\dupfinder.bat`).
- Fix all static code analysis warnings.

## References

<a name="ref-1">[1]</a> David Starr and others: "The Command Pattern" in "Pluralsight: Design Patterns Library", https://www.pluralsight.com/courses/patterns-library, last visited on Apr. 2, 2020.

<a name="ref-2">[2]</a> Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides: "Design Patterns: Elements of Reusable Object-Oriented Software", Addison Wesley, 1994, pp. 151ff, [ISBN 0-201-63361-2](https://en.wikipedia.org/wiki/Special:BookSources/0-201-63361-2).

<a name="ref-3">[3]</a> Wikipedia: "Command pattern", https://en.wikipedia.org/wiki/Command_pattern, last visited on Apr. 2, 2020.
