    
VisitorPattern.File movie = new VisitorPattern.File("Incredibles");
VisitorPattern.Folder movies = new VisitorPattern.Folder("Movies");
VisitorPattern.Folder animatedMovies = new VisitorPattern.Folder("Animated Movies");

animatedMovies.AddFile(movie);
animatedMovies.printFolder();
