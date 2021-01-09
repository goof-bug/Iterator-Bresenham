# Bresenham's line algorithm
An iterator based implementation of Bresenham's line algorithm in C#.

This approach makes integrating it with different methods of plotting or drawing easy and effecient because the iterator simply returns the relevant points one at a time.
## Usage 
The `Bresenham.New()` method returns an IEnumerable that will iterate over all the points in the line in the form of a `ValueTuple<int, int>`.
This can easily be iterated over with a foreach loop like this:
```csharp
var point1 = (1, 2);
var point2 = (4, 6);

foreach(var point in Bresenham.New(point1, point2)){
  Console.WriteLine(point);
}
// This will output:
// (1, 2)
// (2, 3)
// (3, 4)
// (3, 5)
// (4, 6)
```
The `Console.WriteLine()` can easily be substitued with a `plotPixel()` or similar relevant to your application.

### License
Distributed under the MIT License. See [LICENSE](LICENSE) for more information.

### Acknowledgements
- Inspired by [this rust crate.](https://github.com/mbr/bresenham-rs)
- Algorithm derived from [this wikipedia article.](https://en.wikipedia.org/wiki/Bresenham%27s_line_algorithm)
