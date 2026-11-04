# Barber Register

Barber Register is a hairstyle catalog for clients exploring haircut
options and barbers presenting their services. Visitors can compare
hairstyles, view pricing and appointment lengths, and read or submit
customer reviews.

## Live Application

https://barber-reg-aperez.azurewebsites.net

## Features

- Browse hairstyles in a card-based catalog.
- View descriptions, hair lengths, starting prices, and service times.
- See whether a hairstyle includes beard service.
- Add, edit, and delete hairstyles.
- View review counts and customer reviews for each hairstyle.
- Submit reviews with a hairstyle selection, reviewer name, rating,
  comments, and review date.
- Display a helpful message and an action link when no hairstyles exist.
- Invite visitors to write the first review when a hairstyle has no reviews.

## Technologies

- C#
- ASP.NET Core MVC
- Razor views
- Entity Framework Core
- SQL Server
- Bootstrap
- Azure App Service

## Run Locally

1. Install the .NET 10 SDK.

2. Clone the repository:

   git clone https://github.com/abramperez795-art/Week-4-Homework-BarberRegister.git

3. Open a terminal in the directory containing `BarberRegister.csproj`.

4. Restore the project dependencies:

   dotnet restore

5. Configure a SQL Server connection using the configuration key:

   ConnectionStrings:BarberRegisterContext

   Keep database credentials outside source control.

6. With the Entity Framework Core CLI installed, apply the existing
   database migrations:

   dotnet ef database update

7. Start the application:

   dotnet watch

8. Open the localhost address printed in the terminal.

## My Three Week 10 Improvements

### 1. Clearer Hairstyle Browsing

The hairstyle list explains what visitors can compare and presents each
style in a card with its description, starting price, typical service
time, and review count.

Each card includes a descriptive "View [hairstyle name]" link. These
details help visitors compare services and understand where each link
will take them.

### 2. Helpful Empty Hairstyle Catalog

When the catalog contains no hairstyles, the list displays:

"No hairstyles have been added yet."

The page explains how to get started and includes an "Add the first
hairstyle" link. This gives visitors a clear next step instead of leaving
an empty content area.

### 3. Helpful Empty Review Section

When a hairstyle has no reviews, its details page displays a message
naming the hairstyle and invites visitors to share their experience.

A "Write the first review" link passes the current hairstyle's ID to
the review creation action, providing a clear next step from the
details page.

## Verification

### Completed Checks

- The deployed Week 10 checker walked 9 pages from `/HairStyles` and
  reported no findings.
- A database check showed that hairstyle 2 contained Taylor's review
  and no longer contained the test review.
- Source review confirmed that the hairstyle list includes an empty-state
  message and an action link.
- Source review confirmed that the hairstyle details page includes a
  no-reviews message and an action link.
- The checker received an HTTP 404 response for
  `/HairStyles/Details/1004`.

The automated checker reports findings rather than a grade. A clean
report does not replace manual testing or the assignment rubric.

### Manual Checks Still Pending

- Complete a deployed desktop walkthrough of navigation and forms.
- Complete a deployed phone walkthrough for readability, navigation,
  and form usability.
- Verify the empty hairstyle catalog in the browser.
- Verify a hairstyle with no reviews in the browser.
- Visually confirm that a wrong-ID request displays the custom Missing
  page with helpful navigation.

## Current Limitation

Authentication is not implemented in this version. Visitors can access
record-management actions.

Do not enter sensitive information.

## What I Would Improve Next

I would add authentication and authorization so only permitted users
can add, edit, or delete hairstyles. This would address the current
limitation that visitors can access record-management actions.

- Tested the empty hairstyle catalog locally using a temporary empty
  model without deleting database records. Confirmed the helpful message
  appeared and the creation form opened. Restored the normal database
  query and confirmed the hairstyle cards returned.