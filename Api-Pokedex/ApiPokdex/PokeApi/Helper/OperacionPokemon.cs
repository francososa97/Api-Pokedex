using PokeApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.Helper
{
    public class OperacionPokemon
    {
        public List<Pokemon> Pokedex = new List<Pokemon>()
        {
             new Pokemon() { Id = 1, Nombre = "Bulbasaur",Tipo = new List<string>{"planta","veneno" },Altura=Convert.ToDecimal("1.2"),Peso=Convert.ToDecimal("6,9")},
             new Pokemon() { Id = 2, Nombre = "Ivysaur",Tipo = new List<string>{"planta","veneno" },Altura=Convert.ToDecimal("1.0"),Peso=Convert.ToDecimal("13,0")},
             new Pokemon() { Id = 3, Nombre = "Venusaur",Tipo = new List<string>{"planta","veneno" },Altura=Convert.ToDecimal("2"),Peso=Convert.ToDecimal("100")},
             new Pokemon() { Id = 4, Nombre = "Charmander",Tipo = new List<string>{"Fuego" },Altura=Convert.ToDecimal("0,6 "),Peso=Convert.ToDecimal("8,5")},
             new Pokemon() { Id = 5, Nombre = "Charmeleon",Tipo = new List<string>{"Fuego" },Altura=Convert.ToDecimal("1.1"),Peso=Convert.ToDecimal("19.0")},
             new Pokemon() { Id = 6, Nombre = "Charizard",Tipo = new List<string>{ "Fuego", "Volador" },Altura=Convert.ToDecimal("1.7"),Peso=Convert.ToDecimal("90.5")},
             new Pokemon() { Id = 7, Nombre = "Squirtle",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("0,5"),Peso=Convert.ToDecimal("9,0")},
             new Pokemon() { Id = 8, Nombre = "Wartortle",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("22,5")},
             new Pokemon() { Id = 9, Nombre = "Blastoise",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("1,6"),Peso=Convert.ToDecimal("85,5")},
             new Pokemon() { Id = 10, Nombre = "Caterpie",Tipo = new List<string>{"Bicho" },Altura=Convert.ToDecimal("0.3"),Peso=Convert.ToDecimal("2,9")},
             new Pokemon() { Id = 11, Nombre = "Metapod",Tipo = new List<string>{"Bicho" },Altura=Convert.ToDecimal("0,7"),Peso=Convert.ToDecimal("9,9")},
             new Pokemon() { Id = 12, Nombre = "Butterfree",Tipo = new List<string>{ "Bicho", "Volador" },Altura=Convert.ToDecimal("1,1"),Peso=Convert.ToDecimal("32,0")},
             new Pokemon() { Id = 13, Nombre = "Weedle",Tipo = new List<string>{"Bicho","Veneno" },Altura=Convert.ToDecimal("0,3"),Peso=Convert.ToDecimal("3,2")},
             new Pokemon() { Id = 14, Nombre = "Kakuna",Tipo = new List<string>{ "Bicho", "veneno" },Altura=Convert.ToDecimal("0,6"),Peso=Convert.ToDecimal("10,0")},
             new Pokemon() { Id = 15, Nombre = "Beedrill",Tipo = new List<string>{ "Bicho", "veneno" },Altura=Convert.ToDecimal("1,0"),Peso=Convert.ToDecimal("29,5")},
             new Pokemon() { Id = 16, Nombre = "Pidgey",Tipo = new List<string>{"Normal","Volador" },Altura=Convert.ToDecimal("0,3"),Peso=Convert.ToDecimal("1,8 ")},
             new Pokemon() { Id = 17, Nombre = "Pidgeotto",Tipo = new List<string>{"Normal","Volador" },Altura=Convert.ToDecimal("1,5"),Peso=Convert.ToDecimal("30,5")},
             new Pokemon() { Id = 18, Nombre = "Pidgeot",Tipo = new List<string>{"Normal","Volador" },Altura=Convert.ToDecimal("1,5"),Peso=Convert.ToDecimal("30,5")},
             new Pokemon() { Id = 19, Nombre = "Rattata",Tipo = new List<string>{"Normal" },Altura=Convert.ToDecimal("0,3"),Peso=Convert.ToDecimal("3,5")},
             new Pokemon() { Id = 20, Nombre = "Raticate",Tipo = new List<string>{"Normal" },Altura=Convert.ToDecimal("0.7"),Peso=Convert.ToDecimal("18,5")},
             new Pokemon() { Id = 21, Nombre = "Spearow",Tipo = new List<string>{"Normal","Volador"},Altura=Convert.ToDecimal("0.3"),Peso=Convert.ToDecimal("2,0")},
             new Pokemon() { Id = 22, Nombre = "Fearow",Tipo = new List<string>{"Normal","Volador" },Altura=Convert.ToDecimal("1.2"),Peso=Convert.ToDecimal("38")},
             new Pokemon() { Id = 23, Nombre = "Ekans",Tipo = new List<string>{"Veneno" },Altura=Convert.ToDecimal("2.0"),Peso=Convert.ToDecimal("6.9")},
             new Pokemon() { Id = 24, Nombre = "Arbok ",Tipo = new List<string>{"Veneno" },Altura=Convert.ToDecimal("3.5"),Peso=Convert.ToDecimal("65")},
             new Pokemon() { Id = 25, Nombre = "Pikachu ",Tipo = new List<string>{"Eléctrico" },Altura=Convert.ToDecimal("0.4"),Peso=Convert.ToDecimal("6.0")},
             new Pokemon() { Id = 26, Nombre = "Raichu ",Tipo = new List<string>{"Eléctrico" },Altura=Convert.ToDecimal("0.8"),Peso=Convert.ToDecimal("30")},
             new Pokemon() { Id = 27, Nombre = "Sandshrew ",Tipo = new List<string>{"Tierra" },Altura=Convert.ToDecimal("0.6"),Peso=Convert.ToDecimal("12")},
             new Pokemon() { Id = 28, Nombre = "Sandslash ",Tipo = new List<string>{"Tierra" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("29.5")},
             new Pokemon() { Id = 29, Nombre = "Nidoran",Tipo = new List<string>{"veneno" },Altura=Convert.ToDecimal("0.4"),Peso=Convert.ToDecimal("7.0")},
             new Pokemon() { Id = 30, Nombre = "Nidorina ",Tipo = new List<string>{"veneno" },Altura=Convert.ToDecimal("0.8"),Peso=Convert.ToDecimal("20")},
             new Pokemon() { Id = 31, Nombre = "Nidoqueen ",Tipo = new List<string>{"veneno","tierra" },Altura=Convert.ToDecimal("1.3"),Peso=Convert.ToDecimal("59,5")},
             new Pokemon() { Id = 32, Nombre = "Nidoran",Tipo = new List<string>{"veneno" },Altura=Convert.ToDecimal("0.5"),Peso=Convert.ToDecimal("9.0")},
             new Pokemon() { Id = 33, Nombre = "Nidorino ",Tipo = new List<string>{"veneno" },Altura=Convert.ToDecimal("0.9"),Peso=Convert.ToDecimal("10,5")},
             new Pokemon() { Id = 34, Nombre = "Nidoking ",Tipo = new List<string>{"veneno","tierra" },Altura=Convert.ToDecimal("1.4"),Peso=Convert.ToDecimal("62")},
             new Pokemon() { Id = 35, Nombre = "Clefairy ",Tipo = new List<string>{"Hada" },Altura=Convert.ToDecimal("0.6"),Peso=Convert.ToDecimal("7.5")},
             new Pokemon() { Id = 36, Nombre = "Clefable ",Tipo = new List<string>{"Hada" },Altura=Convert.ToDecimal("1.3"),Peso=Convert.ToDecimal("40")},
             new Pokemon() { Id = 37, Nombre = "Vulpix",Tipo = new List<string>{"Fuego" },Altura=Convert.ToDecimal("0.6"),Peso=Convert.ToDecimal("9.9")},
             new Pokemon() { Id = 38, Nombre = "Ninetales",Tipo = new List<string>{"Fuego" },Altura=Convert.ToDecimal("1.1"),Peso=Convert.ToDecimal("19,9")},
             new Pokemon() { Id = 39, Nombre = "Jigglypuff",Tipo = new List<string>{"Normal","Hada" },Altura=Convert.ToDecimal("0.5"),Peso=Convert.ToDecimal("5,5")},
             new Pokemon() { Id = 40, Nombre = "Wigglytuff",Tipo = new List<string>{"Normal","Hada" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("12")},
             new Pokemon() { Id = 41, Nombre = "Zubat",Tipo = new List<string>{"veneno","volador" },Altura=Convert.ToDecimal("0.8"),Peso=Convert.ToDecimal("7,5")},
             new Pokemon() { Id = 42, Nombre = "Golbat",Tipo = new List<string>{"veneno","volador" },Altura=Convert.ToDecimal("1.6"),Peso=Convert.ToDecimal("55")},
             new Pokemon() { Id = 43, Nombre = "Oddish",Tipo = new List<string>{"Normal" },Altura=Convert.ToDecimal("0.7"),Peso=Convert.ToDecimal("18,5")},
             new Pokemon() { Id = 44, Nombre = "Gloom",Tipo = new List<string>{"Planta","Veneno" },Altura=Convert.ToDecimal("0.8"),Peso=Convert.ToDecimal("8.6")},
             new Pokemon() { Id = 45, Nombre = " Vileplume",Tipo = new List<string>{"Planta","Veneno" },Altura=Convert.ToDecimal("1.2"),Peso=Convert.ToDecimal("18.6")},
             new Pokemon() { Id = 46, Nombre = "Paras",Tipo = new List<string>{ "Planta", "Bicho" },Altura=Convert.ToDecimal("0.3"),Peso=Convert.ToDecimal("5.4")},
             new Pokemon() { Id = 47, Nombre = "Parasect",Tipo = new List<string>{ "Planta", "Bicho" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("29.5")},
             new Pokemon() { Id = 48, Nombre = "Venonat",Tipo = new List<string>{ "Bicho", "Veneno" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("30")},
             new Pokemon() { Id = 49, Nombre = "Venomoth",Tipo = new List<string>{ "Bicho", "Veneno" },Altura=Convert.ToDecimal("1.5"),Peso=Convert.ToDecimal("12.5")},
             new Pokemon() { Id = 50, Nombre = "Diglett",Tipo = new List<string>{"Tierra" },Altura=Convert.ToDecimal("0.2"),Peso=Convert.ToDecimal("0.8")},
             new Pokemon() { Id = 51, Nombre = "Dugtrio ",Tipo = new List<string>{"Tierra" },Altura=Convert.ToDecimal("0.7"),Peso=Convert.ToDecimal("33.3")},
             new Pokemon() { Id = 52, Nombre = "Meowth",Tipo = new List<string>{"Normal"},Altura=Convert.ToDecimal("0.4"),Peso=Convert.ToDecimal("4.2")},
             new Pokemon() { Id = 53, Nombre = " Persian",Tipo = new List<string>{ "Normal" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("32")},
             new Pokemon() { Id = 54, Nombre = " Psyduck",Tipo = new List<string>{"Agua"},Altura=Convert.ToDecimal("0.8"),Peso=Convert.ToDecimal("19.6")},
             new Pokemon() { Id = 55, Nombre = "Golduck",Tipo = new List<string>{ "Agua" },Altura=Convert.ToDecimal("1.7"),Peso=Convert.ToDecimal("76.6")},
             new Pokemon() { Id = 56, Nombre = "Mankey",Tipo = new List<string>{"Lucha"},Altura=Convert.ToDecimal("0.5"),Peso=Convert.ToDecimal("28")},
             new Pokemon() { Id = 57, Nombre = "Primeape",Tipo = new List<string>{"Lucha" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("32")},
             new Pokemon() { Id = 58, Nombre = "Growlithe",Tipo = new List<string>{"Fuego" },Altura=Convert.ToDecimal("0.7"),Peso=Convert.ToDecimal("19")},
             new Pokemon() { Id = 59, Nombre = " Arcanine",Tipo = new List<string>{"Fuego" },Altura=Convert.ToDecimal("1.9"),Peso=Convert.ToDecimal("155")},
             new Pokemon() { Id = 60, Nombre = "Poliwag ",Tipo = new List<string>{"Agua"},Altura=Convert.ToDecimal("0.6"),Peso=Convert.ToDecimal("12.4")},
             new Pokemon() { Id = 61, Nombre = "Poliwhirl ",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("20")},
             new Pokemon() { Id = 62, Nombre = " Poliwrath",Tipo = new List<string>{ "Agua", "Lucha" },Altura=Convert.ToDecimal("1.3"),Peso=Convert.ToDecimal("54")},
             new Pokemon() { Id = 63, Nombre = "Abra",Tipo = new List<string>{"Psiquico" },Altura=Convert.ToDecimal("0.9"),Peso=Convert.ToDecimal("19.5")},
             new Pokemon() { Id = 64, Nombre = "Kadabra",Tipo = new List<string>{"Psiquico" },Altura=Convert.ToDecimal("0.9"),Peso=Convert.ToDecimal("56.5")},
             new Pokemon() { Id = 65, Nombre = "Alakazam",Tipo = new List<string>{"Psiquico" },Altura=Convert.ToDecimal("1.3"),Peso=Convert.ToDecimal("56.5")},
             new Pokemon() { Id = 66, Nombre = "Machop",Tipo = new List<string>{"Lucha" },Altura=Convert.ToDecimal("1.5"),Peso=Convert.ToDecimal("48")},
             new Pokemon() { Id = 67, Nombre = "Machoke",Tipo = new List<string>{"Lucha" },Altura=Convert.ToDecimal("0.8"),Peso=Convert.ToDecimal("19.5")},
             new Pokemon() { Id = 68, Nombre = "Machamp",Tipo = new List<string>{"Lucha" },Altura=Convert.ToDecimal("1.5"),Peso=Convert.ToDecimal("70.5")},
             new Pokemon() { Id = 69, Nombre = "Bellsprout",Tipo = new List<string>{"Planta","Veneno" },Altura=Convert.ToDecimal("1.6"),Peso=Convert.ToDecimal("130")},
             new Pokemon() { Id = 70, Nombre = "Weepinbell ",Tipo = new List<string>{"Planta","Veneno" },Altura=Convert.ToDecimal("0.7"),Peso=Convert.ToDecimal("4")},
             new Pokemon() { Id = 71, Nombre = " Victreebel",Tipo = new List<string>{"Planta","Veneno" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("6.4")},
             new Pokemon() { Id = 72, Nombre = "Tentacool",Tipo = new List<string>{ "Agua", "Veneno" },Altura=Convert.ToDecimal("1.7"),Peso=Convert.ToDecimal("15.5")},
             new Pokemon() { Id = 73, Nombre = "Tentacruel",Tipo = new List<string>{ "Agua", "Veneno" },Altura=Convert.ToDecimal("0.9"),Peso=Convert.ToDecimal("45.5")},
             new Pokemon() { Id = 74, Nombre = "Geodude",Tipo = new List<string>{ "Roca", "Tierra" },Altura=Convert.ToDecimal("1.6"),Peso=Convert.ToDecimal("55")},
             new Pokemon() { Id = 75, Nombre = "Graveler",Tipo = new List<string>{"Roca", "Tierra" },Altura=Convert.ToDecimal("0.4"),Peso=Convert.ToDecimal("20")},
             new Pokemon() { Id = 76, Nombre = "Golem",Tipo = new List<string>{"Roca", "Tierra" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("105")},
             new Pokemon() { Id = 77, Nombre = "Ponyta",Tipo = new List<string>{"Fuego" },Altura=Convert.ToDecimal("1.4"),Peso=Convert.ToDecimal("300")},
             new Pokemon() { Id = 78, Nombre = "Rapidash",Tipo = new List<string>{"Fuego" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("30")},
             new Pokemon() { Id = 79, Nombre = "Slowpoke",Tipo = new List<string>{ "Agua", "Psiquico" },Altura=Convert.ToDecimal("1.7"),Peso=Convert.ToDecimal("95")},
             new Pokemon() { Id = 80, Nombre = "Slowbro",Tipo = new List<string>{ "Agua", "Psiquico" },Altura=Convert.ToDecimal("1.2"),Peso=Convert.ToDecimal("36")},
             new Pokemon() { Id = 81, Nombre = "Magnemite",Tipo = new List<string>{"Electrico","Acero" },Altura=Convert.ToDecimal("1.6"),Peso=Convert.ToDecimal("78.5")},
             new Pokemon() { Id = 82, Nombre = "Magneton",Tipo = new List<string>{"Electrico","Acero" },Altura=Convert.ToDecimal("0.3"),Peso=Convert.ToDecimal("6")},
             new Pokemon() { Id = 83, Nombre = "Farfetch'd",Tipo = new List<string>{"Normal","Volador" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("6.0")},
             new Pokemon() { Id = 84, Nombre = "Doduo",Tipo = new List<string>{"Normal","Volador" },Altura=Convert.ToDecimal("0.8"),Peso=Convert.ToDecimal("15")},
             new Pokemon() { Id = 85, Nombre = "Dodrio",Tipo = new List<string>{"Normal","Volador" },Altura=Convert.ToDecimal("1.4"),Peso=Convert.ToDecimal("39.2")},
             new Pokemon() { Id = 86, Nombre = "Seel",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("1.8"),Peso=Convert.ToDecimal("85.2")},
             new Pokemon() { Id = 87, Nombre = "Dewgong",Tipo = new List<string>{"Agua","Hielo"},Altura=Convert.ToDecimal("1.1"),Peso=Convert.ToDecimal("90")},
             new Pokemon() { Id = 88, Nombre = "Grimer ",Tipo = new List<string>{"Veneno" },Altura=Convert.ToDecimal("1.7"),Peso=Convert.ToDecimal("120")},
             new Pokemon() { Id = 89, Nombre = "Muk",Tipo = new List<string>{"Veneno" },Altura=Convert.ToDecimal("0.9"),Peso=Convert.ToDecimal("30")},
             new Pokemon() { Id = 90, Nombre = "Shellder",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("1.2"),Peso=Convert.ToDecimal("30")},
             new Pokemon() { Id = 91, Nombre = "Cloyster",Tipo = new List<string>{"Agua","Hielo" },Altura=Convert.ToDecimal("0.3"),Peso=Convert.ToDecimal("4")},
             new Pokemon() { Id = 92, Nombre = "Gastly",Tipo = new List<string>{"Fantasma","Veneno" },Altura=Convert.ToDecimal("1.5"),Peso=Convert.ToDecimal("132.5")},
             new Pokemon() { Id = 93, Nombre = "Haunter",Tipo = new List<string>{"Fantasma","Veneno" },Altura=Convert.ToDecimal("1.3"),Peso=Convert.ToDecimal("0.1")},
             new Pokemon() { Id = 94, Nombre = "Gengar",Tipo = new List<string>{"Fantasma","Veneno" },Altura=Convert.ToDecimal("1.6"),Peso=Convert.ToDecimal("0.1")},
             new Pokemon() { Id = 95, Nombre = "Onix",Tipo = new List<string>{"Roca","Tierra" },Altura=Convert.ToDecimal("1.5"),Peso=Convert.ToDecimal("40.5")},
             new Pokemon() { Id = 96, Nombre = "Drowzee",Tipo = new List<string>{"Psiquico"},Altura=Convert.ToDecimal("8.8"),Peso=Convert.ToDecimal("210")},
             new Pokemon() { Id = 97, Nombre = "Hypno",Tipo = new List<string>{"Drowzee" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("32.4")},
             new Pokemon() { Id = 98, Nombre = "Krabby",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("1.6"),Peso=Convert.ToDecimal("75.6")},
             new Pokemon() { Id = 99, Nombre = "Kingler",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("0.4"),Peso=Convert.ToDecimal("6.5")},
             new Pokemon() { Id = 100, Nombre = "Voltorb",Tipo = new List<string>{"Electrico" },Altura=Convert.ToDecimal("1.3"),Peso=Convert.ToDecimal("60")},
             new Pokemon() { Id = 101, Nombre = "Electrode",Tipo = new List<string>{"Electrico"},Altura=Convert.ToDecimal("0.5"),Peso=Convert.ToDecimal("10.4")},
             new Pokemon() { Id = 102, Nombre = "Exeggcute",Tipo = new List<string>{"Planta","Psiquico" },Altura=Convert.ToDecimal("1.2"),Peso=Convert.ToDecimal("66.6")},
             new Pokemon() { Id = 103, Nombre = "Exeggutor",Tipo = new List<string>{ "Planta", "Psiquico" },Altura=Convert.ToDecimal("0.4"),Peso=Convert.ToDecimal("2.5")},
             new Pokemon() { Id = 104, Nombre = "Cubone",Tipo = new List<string>{"Tierra" },Altura=Convert.ToDecimal("2"),Peso=Convert.ToDecimal("120")},
             new Pokemon() { Id = 105, Nombre = "Marowak",Tipo = new List<string>{"Tierra" },Altura=Convert.ToDecimal("0.4"),Peso=Convert.ToDecimal("6.5")},
             new Pokemon() { Id = 106, Nombre = "Hitmonlee",Tipo = new List<string>{"Lucha"},Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("45")},
             new Pokemon() { Id = 107, Nombre = "Hitmonchan",Tipo = new List<string>{"Lucha" },Altura=Convert.ToDecimal("1.5"),Peso=Convert.ToDecimal("49.8")},
             new Pokemon() { Id = 108, Nombre = "Lickitung",Tipo = new List<string>{"Normal"},Altura=Convert.ToDecimal("1.4"),Peso=Convert.ToDecimal("50.2")},
             new Pokemon() { Id = 109, Nombre = "Koffing",Tipo = new List<string>{"Veneno" },Altura=Convert.ToDecimal("1.2"),Peso=Convert.ToDecimal("65.5")},
             new Pokemon() { Id = 110, Nombre = "Weezing",Tipo = new List<string>{"Veneno" },Altura=Convert.ToDecimal("0.6"),Peso=Convert.ToDecimal("1")},
             new Pokemon() { Id = 111, Nombre = "Rhyhorn",Tipo = new List<string>{"Roca","Tierra" },Altura=Convert.ToDecimal("1.2"),Peso=Convert.ToDecimal("9.5")},
             new Pokemon() { Id = 112, Nombre = "Rhydon",Tipo = new List<string>{ "Roca", "Tierra" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("115")},
             new Pokemon() { Id = 113, Nombre = "Chansey",Tipo = new List<string>{"Normal" },Altura=Convert.ToDecimal("1.9"),Peso=Convert.ToDecimal("120")},
             new Pokemon() { Id = 114, Nombre = "Tangela",Tipo = new List<string>{"Planta" },Altura=Convert.ToDecimal("1.1"),Peso=Convert.ToDecimal("34.6")},
             new Pokemon() { Id = 115, Nombre = "Kangaskhan",Tipo = new List<string>{"Normal" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("35")},
             new Pokemon() { Id = 116, Nombre = "Horsea",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("2.2"),Peso=Convert.ToDecimal("80")},
             new Pokemon() { Id = 117, Nombre = "Seadra",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("0.4"),Peso=Convert.ToDecimal("8")},
             new Pokemon() { Id = 118, Nombre = "Goldeen",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("1.2"),Peso=Convert.ToDecimal("25")},
             new Pokemon() { Id = 119, Nombre = "Seaking",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("0.6"),Peso=Convert.ToDecimal("15")},
             new Pokemon() { Id = 120, Nombre = "Staryu",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("1.3"),Peso=Convert.ToDecimal("39")},
             new Pokemon() { Id = 121, Nombre = "Starmie",Tipo = new List<string>{ "Agua", "Psiquico" },Altura=Convert.ToDecimal("0.8"),Peso=Convert.ToDecimal("34.5")},
             new Pokemon() { Id = 122, Nombre = "Mr. Mime",Tipo = new List<string>{"Hada","Psiquico" },Altura=Convert.ToDecimal("1.1"),Peso=Convert.ToDecimal("80")},
             new Pokemon() { Id = 123, Nombre = "Scyther",Tipo = new List<string>{"Bicho","Volador" },Altura=Convert.ToDecimal("1.3"),Peso=Convert.ToDecimal("54.5")},
             new Pokemon() { Id = 124, Nombre = "Jynx",Tipo = new List<string>{"Hada","Psiquico" },Altura=Convert.ToDecimal("1.5"),Peso=Convert.ToDecimal("56")},
             new Pokemon() { Id = 125, Nombre = "Electabuzz",Tipo = new List<string>{"Electrico" },Altura=Convert.ToDecimal("1.4"),Peso=Convert.ToDecimal("40.6")},
             new Pokemon() { Id = 126, Nombre = "Magmar",Tipo = new List<string>{"Fuego" },Altura=Convert.ToDecimal("1.1"),Peso=Convert.ToDecimal("30")},
             new Pokemon() { Id = 127, Nombre = "Pinsir",Tipo = new List<string>{"Bicho" },Altura=Convert.ToDecimal("1.3"),Peso=Convert.ToDecimal("44.5")},
             new Pokemon() { Id = 128, Nombre = "Tauros",Tipo = new List<string>{"Normal" },Altura=Convert.ToDecimal("1.5"),Peso=Convert.ToDecimal("55")},
             new Pokemon() { Id = 129, Nombre = "Magikarp",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("1.4"),Peso=Convert.ToDecimal("88.4")},
             new Pokemon() { Id = 130, Nombre = "Gyarados",Tipo = new List<string>{"Agua" },Altura=Convert.ToDecimal("6.5"),Peso=Convert.ToDecimal("235")},
             new Pokemon() { Id = 131, Nombre = "Lapras",Tipo = new List<string>{ "Agua", "Hielo" },Altura=Convert.ToDecimal("6.5"),Peso=Convert.ToDecimal("235")},
             new Pokemon() { Id = 132, Nombre = "Ditto",Tipo = new List<string>{"Normal" },Altura=Convert.ToDecimal("2.5"),Peso=Convert.ToDecimal("220")},
             new Pokemon() { Id = 133, Nombre = "Eevee",Tipo = new List<string>{"Normal" },Altura=Convert.ToDecimal("0.3"),Peso=Convert.ToDecimal("4")},
             new Pokemon() { Id = 134, Nombre = "Vaporeon",Tipo = new List<string>{ "Agua"},Altura=Convert.ToDecimal("0.3"),Peso=Convert.ToDecimal("6.5")},
             new Pokemon() { Id = 135, Nombre = "Jolteon",Tipo = new List<string>{"Electrico" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("29")},
             new Pokemon() { Id = 136, Nombre = "Flareon",Tipo = new List<string>{"Fuego" },Altura=Convert.ToDecimal("0.8"),Peso=Convert.ToDecimal("24.5")},
             new Pokemon() { Id = 137, Nombre = "Porygon",Tipo = new List<string>{"Normal" },Altura=Convert.ToDecimal("0.8"),Peso=Convert.ToDecimal("36.5")},
             new Pokemon() { Id = 138, Nombre = "Omanyte",Tipo = new List<string>{"Agua","Tierra" },Altura=Convert.ToDecimal("0.4"),Peso=Convert.ToDecimal("7.5")},
             new Pokemon() { Id = 139, Nombre = "Omastar",Tipo = new List<string>{"Agua","Tierra" },Altura=Convert.ToDecimal("1"),Peso=Convert.ToDecimal("35")},
             new Pokemon() { Id = 140, Nombre = "Kabuto",Tipo = new List<string>{"Agua","Roca" },Altura=Convert.ToDecimal("0.5"),Peso=Convert.ToDecimal("11.5")},
             new Pokemon() { Id = 141, Nombre = "Kabutops",Tipo = new List<string>{"Agua","Roca" },Altura=Convert.ToDecimal("1.3"),Peso=Convert.ToDecimal("40.5")},
             new Pokemon() { Id = 142, Nombre = "Aerodactyl",Tipo = new List<string>{ "Roca", "Volador" },Altura=Convert.ToDecimal("1.8"),Peso=Convert.ToDecimal("59")},
             new Pokemon() { Id = 143, Nombre = "Snorlax",Tipo = new List<string>{"Normal" },Altura=Convert.ToDecimal("2.1"),Peso=Convert.ToDecimal("466")},
             new Pokemon() { Id = 144, Nombre = "Articuno",Tipo = new List<string>{"Hielo","Volador" },Altura=Convert.ToDecimal("1.7"),Peso=Convert.ToDecimal("55.4")},
             new Pokemon() { Id = 145, Nombre = "Zapdos",Tipo = new List<string>{"Electrico","volador" },Altura=Convert.ToDecimal("1.6"),Peso=Convert.ToDecimal("52.6")},
             new Pokemon() { Id = 146, Nombre = "Moltres",Tipo = new List<string>{"Fuego","Tierra" },Altura=Convert.ToDecimal("2"),Peso=Convert.ToDecimal("60")},
             new Pokemon() { Id = 147, Nombre = "Dratini",Tipo = new List<string>{"Dragon" },Altura=Convert.ToDecimal("1.8"),Peso=Convert.ToDecimal("3.3")},
             new Pokemon() { Id = 148, Nombre = "Dragonair",Tipo = new List<string>{"Dragon" },Altura=Convert.ToDecimal("4"),Peso=Convert.ToDecimal("16.5")},
             new Pokemon() { Id = 149, Nombre = "Dragonite",Tipo = new List<string>{"Dragon" },Altura=Convert.ToDecimal("2.2"),Peso=Convert.ToDecimal("210")},
             new Pokemon() { Id = 150, Nombre = "Mewtwo",Tipo = new List<string>{"Psiquico" },Altura=Convert.ToDecimal("2"),Peso=Convert.ToDecimal("122")},
             new Pokemon() { Id = 151, Nombre = "Mew",Tipo = new List<string>{"Psiquico"},Altura=Convert.ToDecimal("0,4"),Peso=Convert.ToDecimal("4")},
        };

        public IEnumerable<Pokemon> GetPokedex()
        {
            return Pokedex;
        }

        public Pokemon GetPokedex(int id)
        {
            var cliente = Pokedex.Where(cli => cli.Id == id);

            return cliente.FirstOrDefault();
        }

        public void AddPokedex(Pokemon nuevoCliente)
        {
            Pokedex.Add(nuevoCliente);
            //validar por id
        }
        public bool DeletePokemon(int id)
        {
            var pokemon = Pokedex.Where(pokemon => pokemon.Id == id).FirstOrDefault();
            Pokedex.Remove(pokemon);

            var verificacion = Pokedex.Where(pokemon => pokemon.Id == id).FirstOrDefault();

            if (verificacion == null)
                return true;
            else
                return false;
        }

        public IEnumerable<Pokemon> GetTipoPokedex(string Tipo)
        {
            var tipoFormateado = Tipo.ToLower();
            List<Pokemon> Resultado = new List<Pokemon>();
            foreach (var pokemon in Pokedex)
            {
                bool EsTipoSeleccionado = false;
                pokemon.Tipo.ForEach(tipoPokemon => {
                    tipoPokemon = tipoPokemon.ToLower();
                    EsTipoSeleccionado = tipoPokemon == tipoFormateado ? true : false;
                });

                if (EsTipoSeleccionado)
                    Resultado.Add(pokemon);

            }
            return Resultado;
        }

    }
}
