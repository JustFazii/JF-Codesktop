# Codesktop
Codesktop is a forum builded in C# based on .NET Framework

**CODESKTOP FORUM**

**1. INSTALLATION GUIDE:**
1. Downloads:
[Visual Studio 2022 Community Edition](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false)
[SQL Server Management Studio](https://aka.ms/ssmsfullsetup)
[Our Database Backup](https://www.mediafire.com/file/234zzj0z2ky0k0z/Codesktop.Dev.bak/file)


2. SQL Server Management Studio

Here we are going to import backup from our database to your project to avoid errors.

- Launch Microsoft SQL Server Management Studio
- In "Connect to Server" window use this data: 
- Server Name: (localdb)\MSSQLLocalDB
- Authentication: Windows Authentication
- Press "Connect"
- Right-click on folder named "Databases" and use "Restore Database" option
- In pop-out window use this settings:
- **Device:**
- In device press on **3 dots** on left side of the window.
- Make sure you have **"Backup media type:" as File**
- Click **"Add"**
- Select our file named: **_Codesktop.Dev.bak_**
- Press OK, and OK in main window
- wait until you can see Codesktop.Dev database

**You are finished importing our backup to your project!**

3. Visual Studio 2022 Community Edition 

Here we are going to inject our project to your Visual Studio so u can launch project

- In installation of Visual Studio make sure u checked: "ASP.NET and web development"
- Press "Install"
- After Visual is finished in download you will be asked 2 questions: If you want to login on your Microsoft Account (you can press "Later") and what style of software you want to use.
- After initialization you are going to be asked what u want to do. Press clone repository and paste this link: https://github.com/JustFazii/Codesktop.git
- After this u need to wait a while. Software is going to clone any file from my repository to your program, and u will be ready to change what u want
- If you want to launch forum u need to do 2 things:
👍 Close Visual Studio Installer, that remain open in background
👍 Press install .NET Framework up on the Solution Explorer (Left side of the screen, orange box) [If you receive error you have to close  Visual Studio Installer]

After installation of .NET Visual Studio will be open back with this project. Everything what you have to do just press ISS Express button, and accept 2 pop-out windows with certificate (just press yes and install). Wait a while and new tab in browser should pop-out and you will be able to use this app.

**Basic accounts:**

Format:
username - password

ForumAdmin - admin
user1 - zaq1@WSX


**Basic informations:**

- Program is builded using framework .NET Core 2.0 (little old but still works)
- Its took me around 80h from 0 to this state

**What is done:**

- Adding Posts, Replies, User Profiles
- As Admin u can add Forums, and see all users in list
