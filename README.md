# Hierarchy in Blazor DataGrid Component

## Overview

This sample demonstrates how to display hierarchical data using the Syncfusion [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid). The implementation presents related records in a parent-child grid structure where child grids can be displayed or hidden by using the expand and collapse functionality. This approach helps organize related datasets and allows users to navigate hierarchical information without leaving the current grid view.

## Key Features

- Displays data in a hierarchical grid structure.
- Shows child records within expandable parent rows.
- Allows users to expand and collapse hierarchy rows on demand.
- Demonstrates parent-child data relationships using nested DataGrid layouts.
- Organizes related information without requiring page navigation.
- Uses the Syncfusion Blazor DataGrid component for hierarchy visualization.
- Provides a reference implementation for displaying relational data in a hierarchical format.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download the repository.
2. Open the solution file `HierarchyGridSample.sln`.
3. Restore all NuGet packages.
4. Set the `Server` project as the startup project if required.
5. Build the solution.
6. Run the application using `Ctrl+F5`.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the Server project directory.

```bash
cd Server
dotnet restore
dotnet run
```

4. Open the local URL displayed in the terminal after the application starts.

## Project Structure

- `Client/Pages/Index.razor` — contains the hierarchy grid implementation and parent-child grid configuration.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For feature documentation, see the Syncfusion Blazor DataGrid Hierarchy Grid documentation: https://help.syncfusion.com/grid-sdk/blazor/data-grid/detail-template

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.
