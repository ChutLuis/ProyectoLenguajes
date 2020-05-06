using System;
using System.Text;
namespace Prueba
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Ingrese la Palabra a probar: ");
string palabra = Console.ReadLine();
var Palabraascii = Encoding.ASCII.GetBytes(palabra);
string estado = "";
bool ProcederaAutomata = true;
for (int i = 0; i < Palabraascii.Length; i++)
{
if (Palabraascii[i]==32)
{
estado = "1, 3, 6, 9, 10, 12, 13, 14, 16, 18, 19, 20, 22, 23, 26, 29, 32, 35, 37, 39, 40, 41, 42, 43, 44, 45, 46, 47, 49, 50, 51, 53";
ProcederaAutomata = false;
}
else
{
ProcederaAutomata = true;
}
if (ProcederaAutomata)
{
if (estado.CompareTo("-----")!=0)
{
switch (estado)
{
case"1,3,6,9,10,12,13,14,16,18,19,20,22,23,26,29,32,35,37,39,40,41,42,43,44,45,46,47,49,50,51,53":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "2,56";
}
else if(Palabraascii[i]==34)
{
estado = "4";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "7";
}
else if(Palabraascii[i]==61)
{
estado = "56";
}
else if(Palabraascii[i]==60)
{
estado = "11,17,56";
}
else if(Palabraascii[i]==62)
{
estado = "15,56";
}
else if(Palabraascii[i]==43)
{
estado = "56";
}
else if(Palabraascii[i]==45)
{
estado = "56";
}
else if(Palabraascii[i]==79)
{
estado = "21";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "38,56";
}
else if(Palabraascii[i]==65)
{
estado = "24";
}
else if(Palabraascii[i]==78)
{
estado = "33";
}
else if(Palabraascii[i]==68)
{
estado = "30";
}
else if(Palabraascii[i]==77)
{
estado = "27";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "36,56";
}
else if(Palabraascii[i]==41)
{
estado = "56";
}
else if(Palabraascii[i]==59)
{
estado = "56";
}
else if(Palabraascii[i]==46)
{
estado = "48,56";
}
else if(Palabraascii[i]==123)
{
estado = "56";
}
else if(Palabraascii[i]==125)
{
estado = "56";
}
else if(Palabraascii[i]==91)
{
estado = "56";
}
else if(Palabraascii[i]==93)
{
estado = "56";
}
else if(Palabraascii[i]==58)
{
estado = "52,56";
}
else if(Palabraascii[i]==44)
{
estado = "56";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "54,55,56";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "54,55,56";
}
else if(Palabraascii[i]==95)
{
estado = "54,55,56";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"2,56":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "2,56";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"4":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "5";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"7":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "8";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"56":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"11,17,56":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "56";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "56";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"15,56":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "56";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"21":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "56";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"38,56":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "56";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"24":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "25";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"33":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "34";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"30":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "31";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"27":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "28";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"36,56":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "56";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"48,56":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "56";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"52,56":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "56";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"54,55,56":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "54,55,56";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "54,55,56";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "54,55,56";
}
else if(Palabraascii[i]==95)
{
estado = "54,55,56";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"5":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "56";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"8":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "56";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"25":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "56";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"34":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "56";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"31":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "-----";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "56";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
case"28":
if(Palabraascii[i]>=48&&Palabraascii[i]<=57)
{
estado = "-----";
}
else if(Palabraascii[i]==34)
{
estado = "-----";
}
else if(Palabraascii[i]>=32&&Palabraascii[i]<=254)
{
estado = "-----";
}
else if(Palabraascii[i]==39)
{
estado = "-----";
}
else if(Palabraascii[i]==61)
{
estado = "-----";
}
else if(Palabraascii[i]==60)
{
estado = "-----";
}
else if(Palabraascii[i]==62)
{
estado = "-----";
}
else if(Palabraascii[i]==43)
{
estado = "-----";
}
else if(Palabraascii[i]==45)
{
estado = "-----";
}
else if(Palabraascii[i]==79)
{
estado = "-----";
}
else if(Palabraascii[i]==82)
{
estado = "-----";
}
else if(Palabraascii[i]==42)
{
estado = "-----";
}
else if(Palabraascii[i]==65)
{
estado = "-----";
}
else if(Palabraascii[i]==78)
{
estado = "-----";
}
else if(Palabraascii[i]==68)
{
estado = "56";
}
else if(Palabraascii[i]==77)
{
estado = "-----";
}
else if(Palabraascii[i]==73)
{
estado = "-----";
}
else if(Palabraascii[i]==86)
{
estado = "-----";
}
else if(Palabraascii[i]==84)
{
estado = "-----";
}
else if(Palabraascii[i]==40)
{
estado = "-----";
}
else if(Palabraascii[i]==41)
{
estado = "-----";
}
else if(Palabraascii[i]==59)
{
estado = "-----";
}
else if(Palabraascii[i]==46)
{
estado = "-----";
}
else if(Palabraascii[i]==123)
{
estado = "-----";
}
else if(Palabraascii[i]==125)
{
estado = "-----";
}
else if(Palabraascii[i]==91)
{
estado = "-----";
}
else if(Palabraascii[i]==93)
{
estado = "-----";
}
else if(Palabraascii[i]==58)
{
estado = "-----";
}
else if(Palabraascii[i]==44)
{
estado = "-----";
}
else if(Palabraascii[i]>=65&&Palabraascii[i]<=90)
{
estado = "-----";
}
else if(Palabraascii[i]>=97&&Palabraascii[i]<=122)
{
estado = "-----";
}
else if(Palabraascii[i]==95)
{
estado = "-----";
}
else if(Palabraascii[i]==35)
{
estado = "-----";
}
break;
}
}
else
{
Console.WriteLine("La cadena no cumple con el Automata");
break;
}
}
}
Console.WriteLine("Cadena Aceptada");
Console.ReadKey();
}
}
}
