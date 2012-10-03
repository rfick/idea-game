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

3.  Now you need to **clone** your forked repository to your computer. You
    can do this through Github for Windows, or you can open the git
    shell, `cd` to a suitable location, and do

        $ git clone <repository>

    where `<repository>` is something like
    `git@github.com:<username>/<reponame>` (this is shown on the Github
    page for your repository). This will create a new directory with the
    same name as the repository.

4.  Add the `upstream` remote. I think you have to use the git shell to
    do this.

        $ git remote add upstream git://github.com/kalgynirae/idea-game.git

### Git basics

Your best friend:

    $ git status

#### Staging and committing

After you've made changes to files in the repository, you have to
*stage* and then *commit* the changes.

**Staging** lets you specify exactly which changes you want to commit.
For example, if you change File A and File B, but the changes are
unrelated and would make more sense in separate commits, you can stage
File A, commit, and then stage File B and commit again. Usually you'll
stage entire files, but it's also possible to stage only parts of files.

In the git shell, you can stage files like this:

    $ git add <files>

To see what files have been changed and what files are currently staged,
use:

    $ git status

To see what has changed in a particular file:

    $ git diff <file>

**Committing** is the process of packaging up the changes you've made
with a message that explains them.

Commiting is done in the git shell like this:

    $ git commit

This will open a text editor so that you can enter your commit message.
Once you save the file and quit the editor, git will record the commit.
If you want to cancel the commit, you can exit the editor without saving
the file.

Git commit messages consist of a required short title
(written in the imperative voice, max 55 characters) and an optional
longer description.

Commits in git are identified by a hexidecimal hash. The hashes are
quite long, but in most cases you can use just the first 6 or 7 characters of
the hash.

To see the log of previous commits and their hashes:

    $ git log
    $ git log --oneline

#### Branches

The default branch in a git repository is called `master`.

To list the branches in your local repository or to see which branch you
currently have checked out, you can do:

    $ git branch

If you also want to see local copies of remote branches:

    $ git branch -a

To switch to a branch:

    $ git checkout <branch name>

To make a new branch:

    $ git checkout -b <branch name>

### Using git to work on the game

[1]: https://github.com/
[2]: http://windows.github.com/
[3]: https://github.com/kalgynirae/idea-game
