# Assignment 01 - Advanced C#

## Overview

This console application contains solutions for all six requirements in Assignment 01.

## Requirements Covered

### 1. Optimized Bubble Sort
The implementation uses a `swapped` flag. If a complete pass makes no swaps, the algorithm stops early because the array is already sorted.

### 2. Generic Range<T>
`Range<T>` accepts a minimum and maximum value and uses `IComparable<T>` for range comparisons. It provides `IsInRange()` and `Length()`.

### 3. Reverse ArrayList
The ArrayList is reversed in-place by swapping elements from the two ends. The built-in `Reverse()` method is not used.

### 4. Even Numbers
A new `List<int>` is created containing only the even values from the original list.

### 5. FixedSizeList<T>
The custom generic list has a fixed capacity. `Add()` throws an exception when the capacity has been reached, and `Get()` throws an exception for an invalid index.

### 6. First Non-Repeated Character
A dictionary is used to count character frequencies, followed by a second pass to locate the first character whose frequency is one.

## Run

Open `Assignment 01.slnx` in Visual Studio, build the solution, and run the console application.
