# _Pierre's Bakery_

#### _A console application for Pierre's Bakery_

#### By _**Morgan Bradford**_

## Technologies Used

* _C#_
* _.NET5.0_

## Description

This console application allows you to select a quantity of bread and/or pastries to purchase from the fictitious bakery: Pierre's Bakery. After your selections are made, you will see your total displayed in the console.

## Setup/Installation Requirements

* _Clone this repository_
* _Navigate to PierresBakery.Solution/Bakery_
* _Run the command 'dotnet run'_


_Instructions_: using terminal, navigate to the directory you would like to download this directory to. For this example we will be navigating to desktop. For any commands, type what is in between the 'single' quotation marks. To navigate to desktop, type 'cd ~/desktop'. To confirm your location enter 'pwd'. You should receive a message similar to "/c/Users/vampi/desktop" in this instance my location translates to "/hard drive c/Users folder/user/desktop". The last entry "desktop" is my current directory, and just happens to be inside of the other directories previously listed.

**Note: If you have a directory named PierresBakery.Solution located here before using this next command, you may run into issues. To see a list of directories in your current location enter 'ls' in the terminal.**

Next, enter the following command 'git clone https://github.com/MorganJBradford/PierresBakery.Solution.git'

The terminal should return with something similar to:

>Cloning into 'PierresBakery.Solution'...
>remote: Enumerating objects: 208, done.
>remote: Counting objects: 100% (208/208), done.
>remote: Compressing objects: 100% (139/139), done.
>remote: Total 208 (delta 80), reused 195 (delta 67), pack-reused 0
>Receiving objects: 100% (208/208), 23.00 KiB | 2.09 MiB/s, done.
>Resolving deltas: 100% (80/80), done.

Next enter the command 'ls' which should return with a list of files and directories. Mine returned with:

desktop.ini icebreaker/ portfolio/ PierresBakery.Solution/

Because I did not have a directory named PierresBakery.Solution, I know it downloaded successfully.

Next enter the directory with the command 'cd PierresBakery.Solution/Bakery'. 

Next, enter 'dotnet run'.

Finally, follow the instructions in your terminal.

## Testing

If you have installed this repo and would like to utilize the testing, follow these steps:

To Navigate to the testing directory from the directory you downloaded the program to enter cd PierresBakery.Solution/BakeryTests'. One in this directory, enter 'dotnet restore' to install the dependencies required to utilize the testing. Lastly, enter 'dotnet test' to run the tests.

## Known Bugs

* _No error handing for non-integer inputs_

## License

[MIT](LICENSE.txt)

## Contact Information

_Morgan Bradford_: [morganjbradford95@gmail.com](mailto:morganjbradford95@gmail.com)