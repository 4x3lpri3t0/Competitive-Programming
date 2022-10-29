# Competitive Programming Solutions

My (often futile) attempts to solve increasingly harder competitive programming problems in C#. This is mainly a way for me to practice Algorithms & Data Structures in different environments and [online judges](https://code.fandom.com/wiki/Online_judge).


## CodeForces VS Template

1. Copy zipped template located in this repo under `_VS Template` dir
2. Win + R
3. `%USERPROFILE%\OneDrive\Documentos` or `%USERPROFILE%\OneDrive\Documents` or `%USERPROFILE%\Documentos` depending on Win config
4. Paste zipped template here
5. Restart VS
6. Now can create templated class with CTRL + SHIFT + A

Documentation:

* https://learn.microsoft.com/en-us/visualstudio/ide/how-to-create-item-templates?view=vs-2022
* https://learn.microsoft.com/en-us/visualstudio/ide/creating-project-and-item-templates?view=vs-2022
* https://learn.microsoft.com/en-us/visualstudio/ide/how-to-update-existing-templates?view=vs-2022
* https://learn.microsoft.com/en-us/visualstudio/ide/how-to-substitute-parameters-in-a-template?view=vs-2022
* https://learn.microsoft.com/en-us/visualstudio/extensibility/visual-studio-template-schema-reference?view=vs-2022


## HighTail + Competitive Companion

* HT (located under `_HighTail` dir) works great with [CC Chrome extension](https://chrome.google.com/webstore/detail/competitive-companion/cjnmckjndlpiamhfimnnjmnckgghkjbl).
* HT project has been abandoned by the maintainers but still works OK with CC as of 2022.
* You'll have to remember to update the `Main.cs` to make sure HT is executing the current exercise.
* HT hotkeys:
    * CTRL + R = `R`un tests
    * CTRL + T = add new custom `T`est and...
    * CTRL + ENTER = confirm adding current custom test
* CC hotkeys:
    * CTRL + SHIFT + U = `U`pload(?) to HT
        * If HT is open CC will parse the current exercise page and send it to your open HT instance.
        * Equivalent to clicking on the green `(+)` extension button on Chrome.
* CC also supports [other tools](https://github.com/jmerle/competitive-companion), and at some point I'll have to migrate to one of those since HT has been abandoned.