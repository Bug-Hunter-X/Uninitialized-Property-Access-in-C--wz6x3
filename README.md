# Uninitialized Property Access in C#

This repository demonstrates a common but easily overlooked error in C#: accessing an uninitialized property. Value types will default, but reference types cause exceptions.

## Bug.cs
Shows the different scenarios and the outcomes.

## BugSolution.cs
Provides the improved code to handle property initialization explicitly to avoid exceptions.

This example highlights the importance of initializing properties, particularly reference types, to avoid runtime errors.  Always initialize properties to a valid state before use.