This is the README in the git repository for the currently unnamed IDEA
game!

## Plan for the game

The theme is "unicorns and leprechauns in space".

### Gameplay synopsis

Kill the dangerous unicorns and leprechauns, who are trying to murder
you, whilst avoiding being sucked into the nearby black hole.

## How to use Git and Github

### Getting your own copy of the repository

1.  Make a Github account and install [Github for Windows][2] (or just
    git on Mac/Linux).

2.  Visit the [main idea-game repository][3] on github.com and click the
    **Fork** button. Now you have a copy of the repository under your
    Github account.

3.  Now you need to "clone" your forked repository to your computer. You
    can do this through Github for Windows, or you can open the git
    shell, `cd` to a suitable location, and do

        $ git clone <repository>

    where `<repository>` is something like
    `git@github.com:<username>/<reponame>` (this is given on the Github
    page for your repository). This will create a new directory with the
    same name as the repository.

### Git basics

#### Staging and committing

After you've made changes to files in the repository, you have to
*stage* and then *commit* the changes.  The staging process exists so
that you can commit only some files or certain parts of files that have
changes. For example, if you change File A and File B, but the changes
are unrelated and would make more sense in separate commits, you can
stage File A only and commit, and then stage File B and commit again.

In the git shell, you can stage files like this:

    $ git add <files>

Committing is the process of packaging up the changes you've made with a
message that explains them. Git commit titles should be written in the
present imperative and should be 55 characters or fewer. (examples: `Add
Run/Stop buttons`, `Fix bug #4453`, and `Add a new character sprite`)
More detailed information can be included in the description.

Commiting is done in the git shell like this:

    $ git commit -m "<title>"

#### Branches

Git stores repository configuration and metadata in a special directory
named `.git` inside the repository folder.

[1]: https://github.com/
[2]: http://windows.github.com/
[3]: https://github.com/kalgynirae/idea-game
