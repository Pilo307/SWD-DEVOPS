// See https://aka.ms/new-console-template for more information

using Lecture10_1;


class Program
{
    static int Main()
    {

        Flashlight myFlashlight = new Flashlight();

        myFlashlight.PowerPressed(); //off
        myFlashlight.PowerPressed(); //on
        myFlashlight.PowerPressed(); //off
        myFlashlight.PowerPressed(); //on
        myFlashlight.PowerPressed(); //off
        myFlashlight.PowerPressed(); //on


        myFlashlight.ModePressed();
        myFlashlight.ModePressed();
        myFlashlight.ModePressed();

        myFlashlight.PowerPressed(); //off

        myFlashlight.ModePressed();






        return 0;
    }
}