# Project HelloWorld Add-In for Autodesk Revit baby step

## Overview
This is my first Autodesk Revit add-in following the official **Revit API Developer's Guide HelloWorld Walkthrough**.
The goal of this project was to make me understand the basics of creating an external command, adding a custom button to the Revit ribbon, and interacting with the user through a simple message dialog. 

**Note:** This project is part of my journey as a BIM Drafter who decided to wander around the mysterious world of Revit API.
I have no idea where this road leads, but hey, at least I get to break Revit in interesting ways.

## Learning Objectives
- Set up a Revit add-in development environment (Visual Studio + RevitAPI references).
- Understand how 'ExternalCommand works in the Revit API.
- Learn how to create a custom Ribbon Panel and a PushButton
- Explore basic user interaction using 'TaskDialog'.

## Toold & Technologies
**Autodesk Revit 2021**
**Visual Studio 2022**
**C# (.NET Framework 4.8)**
**RevitAPI.dll & RevitAPIUI.dll)**

##Project Structure
Project_HelloWorld/
|
|--HelloWorld.addin/# .addin file to load add-in into Revit
|--Class1.cs# Implement IExternalCommand
|--Screenshot.png
|--Readme.md


## How to Use
1. Build the solution in Visual Studio.
2. Save the generated '.addin' file to:
   C:\ProgramData\Autodesk\Revit\Addins\{RevitYear}\
3. Debug the project.
4. Revit will launch.
5. Open any project and go to **Add-Ins → HelloWorld Panel** in External Tools drop down.
6. Choose the Hello World → A simple 'HelloWorld' message box will appear.

## Screenshots
[see screenshot](screenshot.png)

## Key Learnings
- How to create an external command using 'IExternalCommand'.
- How to customize the Revit Ribbon to include custom tools.
- The workflow of loading and testing Revit add-ins.
- Setting up foundation for future Revit API development.

---


