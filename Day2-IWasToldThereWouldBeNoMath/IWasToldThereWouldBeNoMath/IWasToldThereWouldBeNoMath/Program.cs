
var presentSizes = File.ReadAllLines("C:\\Users\\marti\\Desktop\\Advent Of Code\\AdventOfCode2015\\Day2-IWasToldThereWouldBeNoMath\\PresentSizes.txt");

var total = 0;

foreach (var line in presentSizes)
{
    var dimensions = Array.ConvertAll(line.Split('x'), int.Parse);
    
    var l = dimensions[0];
    var w = dimensions[1];
    var h = dimensions[2];

    var surfaceArea1 = 2 * l * w;
    var surfaceArea2 = 2 * w * h;
    var surfaceArea3 = 2 * h * l;

    total += surfaceArea1 + surfaceArea2 + surfaceArea3 + new[] { l * w, w * h, h * l }.Min();
}

Console.WriteLine(total);

//Part 2
var totalRibbon = 0;

foreach (var line in presentSizes)
{
    var dimensions = Array.ConvertAll(line.Split('x'), int.Parse).ToList();

    dimensions.Sort();

    totalRibbon += dimensions[0] + dimensions[0] + dimensions[1] + dimensions[1] + dimensions.Aggregate((x, y) => x * y);
}

Console.WriteLine(totalRibbon);
