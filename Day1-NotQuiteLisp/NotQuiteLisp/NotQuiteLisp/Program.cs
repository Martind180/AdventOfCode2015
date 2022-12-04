
var santaDirections = File.ReadAllText("C:\\Users\\marti\\Desktop\\Advent Of Code\\AdventOfCode2015\\Day1-NotQuiteLisp\\SantaDirections.txt");

var answer = 0;


foreach (var character in santaDirections)
{
    switch (character)
    {
        case '(':
            answer++;
            break;
        case ')':
            answer--;
            break;
    }
}

Console.WriteLine(answer);

//Part 2
var count = 0;

foreach (var character in santaDirections)
{
    if (answer < 0)
    {
        Console.WriteLine(count);
        return;
    }

    count++;
    switch (character)
    {
        case '(':
            answer++;
            break;
        case ')':
            answer--;
            break;
    }
}