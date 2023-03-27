# WPFAppointmentScheduler

![WPF Appointment Scheduler Screenshot](/PatientBooker/bin/PreviewWPFAppointment.PNG)

WPF Appointment Scheduler is a simple yet powerful C# Windows Presentation Foundation (WPF) application designed to help users book and view appointments. This application makes it easy to create, view, and edit appointments, as well as view them in a calendar format.

## Table of Contents

1. [Features](#features)
2. [Requirements](#requirements)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)

## Features

- User-friendly interface
- Create, edit, and delete appointments
- Calendar view with day, week, and month options
- Appointment reminders
- Search and filter functionality
- Data persistence using local storage

## Requirements

- Windows OS
- .NET Framework 4.7.2 or higher
- Visual Studio 2017 or newer (recommended)

## Installation

1. Clone the repository:

2. Open the solution file `WPFAppointmentScheduler.sln` in Visual Studio.

3. Restore NuGet packages if prompted. To do this, right-click on the solution and select "Restore NuGet Packages."

4. Build the solution by pressing `Ctrl + Shift + B` or by selecting "Build Solution" from the "Build" menu.

5. Run the application by pressing `F5` or by selecting "Start Debugging" from the "Debug" menu.

## Usage

1. Add a new appointment:
- Fill in the appointment details (title, date, time, duration, and description).
- Click the "Book Appointment" button to create the appointment.

2. Prefill an example appointment:
- Click Prefill Fields on the appointment booking page.
- View the new prefilled fields.
- Click "Book Appointment" to apply the changes.

3. Reset appointment fields:
- Click on the Reset Fields button.
- Enter in new appointment details.

4. Navigate the calendar view:
- Use the arrows to move between days, weeks, or months.
- Choose the desired calendar view by selecting "Day," "Week," or "Month."

5. Write List of Records to txt file:
- Click Print to print all locally loaded records to file.
- Navigate to bin/Debug to access file.

## License

WPF Appointment Scheduler is released under the [MIT License](./LICENSE).
