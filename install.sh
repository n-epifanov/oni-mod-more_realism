#!/bin/bash -e

dest="$HOME/.config/unity3d/Klei/Oxygen Not Included/mods/Dev/More Realism!"
set -x
mkdir -p "$dest"
#cp -f "bin/Debug/More Realism!.dll" "$dest"
ln -st "$dest" "$(pwd)/bin/Debug/More Realism!.dll"
