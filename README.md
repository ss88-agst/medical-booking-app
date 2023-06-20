# Medical Clinic Appointment Booking App

This is an appointment booking app for receptionists at a medical clinic. This app was made using Blazor.
This project was done along with 3 other group members for my CPSC481 course in uni.

## Running the program

In order to run the program, you must first clone the repo. After having cloned the repo, open Visual Studio and open the project solution that will be at the location where you have cloned this repo.

After opening the solution on Visual Studio, you can click on the "Start without debugging" green arrow button in the top tool bar (you can also press Ctrl+F5). This will build the program, and should launch a browser window with the program and start at the sign-in page.

## Implemented cases

The features that were implemented are:

- Signing in and logging out as both a receptionist and an admin
- Adding, removing, and editing receptionist accounts as an admin
- Looking at the appointments of each doctor
- Searching up patients
- Adding new patients
- Choosing a patient
- Modifying patient details
- An upcoming appointments view for the receptionist
- Adding appointments
- Modifying appointments
- Deleting appointments
- Scrolling through weeks in the calendar
- Jumping to dates on calendar
- Jump to current week on calendar

### Signing in and logging out, and editing receptionist accounts

We first arrive at the sign in page. Let's first try signing in as an admin. Type "admin@admin.com" into the email field and "admin" in the password field and click "SIGN IN". This will take you to the admin page, where an admin can manage receptionist accounts.

Click on the "ADD NEW RECEPTIONIST" button. This will open a form that allows you to create a new receptionist. Type "Bob Smithsmonian" in the name field, "bs@gmail.com" into the email field, and "bs" into the password field, and then click the add button. This will create a new card showing the new receptionist account details.

Let's check out this card. Click on the "CHANGE NAME" button and type in the new name "Alice Smithsonian" and click change. Similarly, click on the "CHANGE EMAIL" button and type in "as@gmail.com", click change, and finally click on the "CHANGE PASSWORD" button and type in "as" and click change.

Now press the "LOG OUT" button in the top left. This will take you back to the sign in page. Let's log in as a receptionist this time. We're going to use the first receptionist's details. Type "Nancyapplewood@gmail.com" into the email field and "qewrty" into the password field and click "SIGN IN"

### Looking at the appointments of each doctor

After logging in as the receptionist, we come to the main page where we will spend most of our time. To filter the calendar by doctor, locate the "ALL DOCTORS" menu button to the top left of the calendar. Click on the drop down part of the button to see each doctor. Click on "Dr. Miller" to see his appointments.

### Searching up patients

To the left of the page, we see the patient search functionality. To search patients, we type in their first name in the first name field, their last name in the last name fields, and we input their date of birth by choosing their birth year, month, and day in each of their respective fields.

### Adding new patients

Let's try it now. Type "Andrew" into the first name field, "Sanchez" into the last name field, and leave the date of birth pickers as is. Now click on the "SEARCH PATIENT" button. Now this patient does not currently exist in the program, so an "Add Patient" dialog will show up. Now we can add this patient's details in. Type in "4038901234" into the patient's phone number field, and "asanchez@gmail.com" into the patient's email address field. Using the patient doctor menu, assign "Dr. Fortier" as his doctor. Now click on the create new patient button. This will have created a new patient and selected him as a patient, which allows the receptionist to book appointments for him.

### Choosing a patient

Let's deselect this new patient. Click on the "x" button at the top right of the card that display's the patient's details on the left of the screen. We'll try searching up and existing patient now. Type in "Sarah" in the patient first name field, "Gomez" in the patient last name field, and choose November 15, 2000 as the patient's date of birth using the select fields for month, day, and year. Now click on the "SEARCH PATIENT" button. This will show a dialog that says "Patient Found" and display Sarah Gomez's patient details. Click on the select button to choose this patient.

### Modifying patient details

Now let's change some of Sarah's details. Click on the "MODIFY PATIENT" button that is in the card with all the patient information. This opens a dialog that allows the receptionist to change a patient's details. Notice that all of the patient's details are already filled out, so that the receptionist doesn't need to go back and forth to fill out the details that don't have to change. Let's assume that Sarah has changed her email and asked the receptionist to change it in ther system. GO to the field that has Sarah's email and replace it with "sgomez@gmail.com". Now click the "CONFIRM CHANGES" button. This will close the dialog, and we can now see Sarah's new details on the patient card on the left.

### Upcoming appointments view

When a patient like Sarah is selected, the receptionist can see that patient's upcoming appointments right beneath the card that displays that patient's details. This allows the receptionist to see at a glance what type of things the patient has already been booked to come in for, as well as what doctor that appointment is with and what day and time. This allows the receptionist to quickly jump to whichever day and time these appointments are at if anything needs to be changed.

### Adding appointments

Let's add a new appointment for Sarah. Click on the "BOOK APPOINTMENT" button located below the calendar. This opens up a new dialog to allow the receptionist to book an appointment. The doctor field is already filled with Sarah's usual doctor. Choose "Check up" in the appointment type, and use the date field to select December 27, 2022. Choose hour 10 and minute 0 to set it at 10:00. Now click on the "CONFIRM" button. This will have booked the appointment. You will also see this new appointment in the Upcoming appointments section by scrolling down.

### Scrolling through weeks on calendar

Let's go to the week that newly booked appointment is in. Click on the "NEXT WEEK" button located to the top right of the calendar until you arrive at the week that has December 27. This allows the receptionist to quickly go to weeks that are not that far ahead or back in time.

### Modifying appointments

Now let's modify this newly created appointment. Click on the appointment in the calendar on December 27 at 10:00 am. This opens a popover that displays the appointment. You can click on "DELETE" to delete this appointment, "MODIFY" to modify it, or the "x" button to close this popover. Click on "MODIFY". This will open up the dialog that allows the receptionist to modify a booking. Modifying appointments does not allow you to change the doctor, for that you must delete the appointment, then create a new appointment with the new doctor.

Choose "Consultation" as the appointment type, and use the date picker to choose May 10, 2023. Set the hour to 10 and minute to 0 for 10:00 am, and click "CONFIRM". This will modify the appointment.

### Jumping to dates on calendar

May 10, 2023 is quite far away (as of writing) and would require a lot of clicks on "NEXT WEEK" to get to, which is cumbersome. Instead we can use the "Jump to" field at the top of the screen to go there quickly. Click on the "Jump to" input and select May 10, 2023. This will put the calendar on the week that contains May 10, 2023. We can now see the newly modified appoinment.

### Deleting appointments

Let's delete this appointment now. Click on the appointment on May 10, 2023 at 10:00 am, which again shows the popover displaying the appointment. Click on the red "DELETE" button, which deletes this appointment. Now the appointment has been removed.

### Jump to current week

Having deleted a far off appointment, the receptionist can quickly get back to the current week to deal with appointments that are closer in time. Click on the "JUMP TO PRESENT" button above the calendar to jump to the current week.
