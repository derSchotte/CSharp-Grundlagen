﻿using Grundlagen.kleineProgramme;

Console.WriteLine( "Geben Sie eines der folgenden Programm Namen ein!" );
Console.WriteLine( "[1]HelloWorld, [2]FizzBuzz, [3]AtoO, [4]BinToDez, [5]BinToDez2, [6]Noten, " +
    "\n[7]ReverseInput, [8]Taschenrechner, [9]Vererbung, [10]PerlinNoise, [11]<List>Noten2, [12]HackNSlay, " +
    "\n[13]Password, [14]Check Email, [15]NewPassword, [16]LottoZahlen" );
Console.Write( "Eingabe Zahl: " );
string input = Console.ReadLine();
Console.Clear();

switch( input ) {
    case "1":
    HelloWorld.runHelloWorld();
    break;
    case "2":
    FizzBuzz.runFizzBuzz();
    break;
    case "3":
    AtoO.runAtoO();
    break;
    case "4":
    BinToDez.runBinToDezimal();
    break;
    case "5":
    BinToDez2.runBinToDezimal2();
    break;
    case "6":
    Noten.runNoten();
    break;
    case "7":
    ReverseInput.runReverseInput();
    break;
    case "8":
    Taschenrechner.runTaschenrechner();
    break;
    case "9":
    Tiere.runDasTier();
    break;
    case "10":
    PerlinNoise.runPerlinNoise();
    break;
    case "11":
    noten2.runNoten2();
    break;
    case "12":
    HackNSlay.runHackNSlay();
    break;
    case "13":
    Password.runPassword();
    break;
    case "14":
    CheckEmail.runCheckEmail();
    break;
    case "15":
    NewPassword.runNewPassword();
    break;
    case "16":
    LottoGenerator.runLottoGenerator();
    break;
    default:
    Console.WriteLine( "Sie haben nicht das eingegeben was gebraucht wird!" );
    break;
}
Console.ForegroundColor = ConsoleColor.DarkGray;
