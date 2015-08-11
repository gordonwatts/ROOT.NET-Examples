This solution contains some sample projects for ROOT.NET.

Check out of GitHub
Use a fairly modern version of VS (it has been tested with 2013, but should work with 2012 as well).

It will automatically pull down and unpack the proper version of ROOT, if you don't have it installed already
(it won't install it, just bring it down locally). It will create a .bat file next to your .sln file and you
should double-click that in order to run with the proper ROOT environment variables defined. You will get build
warnings if you haven't done this.

Note there is (at least) one known bug: if your build needs to do the download, and you hit re-build all, all
the example programs will attempt to do the download, and that will cause a race condition preventing some of
the builds from succeeding. Just let the ones that are running finish - they will get the ROOT install - and
then rebuild all again and you'll be set to go. As soon as I figure out how to properly make the builds talk
to each other, this will get fixed. :-)
