    
VisitorPattern.File movie = new VisitorPattern.File("Incredibles");
VisitorPattern.File movie2 = new VisitorPattern.File("Hobitten");
VisitorPattern.File movie3 = new VisitorPattern.File("Hjemmefilm");
VisitorPattern.Folder movies = new VisitorPattern.Folder("Movies");
VisitorPattern.Folder animatedMovies = new VisitorPattern.Folder("Animated Movies");
VisitorPattern.Folder liveActionMovies = new VisitorPattern.Folder("Live Action Movies");


movies.AddFile(movie3);
animatedMovies.AddFile(movie);
liveActionMovies.AddFile(movie2);
movies.AddSubFolder(animatedMovies);
movies.AddSubFolder(liveActionMovies);
movies.printFolder();
