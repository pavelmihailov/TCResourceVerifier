(c) Rouslan Grabar 2012

Velocity Resource Reference Verifier
------------------------------------

This application scans widget files and checks references to language resources.
This tool will let you know, what resource string is being referenced in code but not defined in the languages section of a widget definition.

The TCResourceVerifier.dll contains all the checking code, while TCResourceVerifierApp.exe (and accompanying dependency WPFFolderBrowser.dll) is a GUI which visualises the errors in widgets, if there are any

To-do:
------

* Check for unused resources, i.e. resources strings are defined, but not used in widget
* Create a console app (should be pretty easy now, just _cout_ the results!)
* Rewrite the GUI part to make it MVVMesque 
* Add progress bar to the GUI 

