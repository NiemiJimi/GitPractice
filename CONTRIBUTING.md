# Contributing to GitPractice

## Setup (once per PC)
- Install Git for Windows (with Git LFS) and GitHub Desktop
- Run: git lfs install
- Set the Git editor to Notepad: git config --global core.editor notepad
- GitHub: Settings > Emails > tick "Keep my email addresses private"
- Use the exact Unity version in ProjectSettings/ProjectVersion.txt
- Clone to a short path without special characters, e.g. C:\Projects\GitPractice

## Branches
- main: shipped builds only. Never commit directly.
- develop: the team's working build. Never commit directly.
- feature/, fix/, art/, level/, audio/: one branch per task, from develop
- release/x.y.z: from develop, only fixes and version bumps
- hotfix/x.y.z: from main, merged into BOTH main and develop

## Daily routine
1. Switch to develop and pull
2. Create or switch to your task branch
3. Lock scenes, prefabs and art before editing: git lfs lock <file>
4. Commit small and often, with clear messages ("Add dash ability")
5. Push before you stop for the day
6. Open a pull request into develop when the task is done
7. After merge: pull develop, delete your local branch, unlock files

## Unity rules
- Save in Unity before switching branches, pulling or discarding
- Always commit .meta files together with their assets
- Never commit Library/, Temp/, Logs/, UserSettings/
- Check the Changes list before every commit: Unity changes files on its own
- If a script shows as missing after a pull: do NOT save, ask the lead
- Never hand-merge scenes or prefabs: keep one side and redo the change

## Pull requests
- Features go into develop with Squash and merge
- Releases and hotfixes use a merge commit
- For releases and hotfixes, open BOTH pull requests (main and develop) before merging either
- Check the commit message before confirming a merge

## Help
Ask the lead before force-unlocking a file or deleting someone else's branch.
