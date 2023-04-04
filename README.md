# Very Simple Game Save Solution For Small Unity Projects

This is a very simple game save solution for Unity projects

# Why?

Because sometimes all you need is PlayerPrefs to save data. 

# Is this secure?

If you don't want the players to be able to change the values (they are stored as plain text), you can make this class bigger by adding hash and salt to it.

Just hash every important value with a randomly generated salt value in the save method. For every save you could crete a new random salt too. And when you load the data, you should hash the loaded values with the saved salt value and check that the saved hash matches the calculated one.

For example (with pseudo code):

```
data.salt = GenerateRandomSalt();
data.hash = GenerateHash(data.level + data.lv1src + [...] + data.salt);

PlayerPrefs.SetString("hash", data.hash);
PlayerPrefs.SetString("salt", data.salt);
```

This way, if the player changes a value that you do not want them to change, the game will load the default values (or you could prompt them with a corrupted save file error so they know to change back the value and continue playing).

Of course, if a cheater with more know-how can determine how you salt, this will not be enough. But this is just a game. If you need a simple solution for saving a game, this is it.
