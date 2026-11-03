using VisitorPattern;

VisitorPattern.File movie = new VisitorPattern.File("Incredibles", 1);
VisitorPattern.File movie2 = new VisitorPattern.File("Hobitten", 1);
VisitorPattern.File movie3 = new VisitorPattern.File("Hjemmefilm", 1);
VisitorPattern.Folder movies = new VisitorPattern.Folder("Movies", 1);
VisitorPattern.Folder animatedMovies = new VisitorPattern.Folder("Animated Movies", 1);
VisitorPattern.Folder pixarMovies = new VisitorPattern.Folder("Pixar Movies", 1);
VisitorPattern.Folder liveActionMovies = new VisitorPattern.Folder("Live Action Movies", 1);


movies.AddFile(movie3);
pixarMovies.AddFile(movie);
liveActionMovies.AddFile(movie2);
animatedMovies.AddSubFolder(pixarMovies);
movies.AddSubFolder(animatedMovies);
movies.AddSubFolder(liveActionMovies);
movies.Accept(new PrintTreeVisitor());


var directories = new List<IVisitableElement>
{
    pixarMovies,
};

var pathVisitor = new PathVisitor();
var sizeVisitor = new SizeVisitor();

directories.ForEach(e => e.Accept(sizeVisitor));
directories.ForEach(e => e.Accept(pathVisitor));
Console.WriteLine($"{sizeVisitor.totalSize}");
Console.WriteLine($"{pathVisitor.path}");


