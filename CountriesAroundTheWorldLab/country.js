

class Country{
    constructor(name, lang, greeting, colors){
        this.name = name;
        this.lang = lang;
        this.greeting = greeting;
        this.colors = colors;
    }

    DisplayColors() {
        
        for(let i = 0; i < this.colors.length; i ++){
            console.log(this.colors[i])
            document.getElementById(`Color${i + 1}`).style.backgroundColor = this.colors[i];
        }
        document.getElementById("CountryName").innerHTML = this.name;
        document.getElementById("OfficialLanguage").innerHTML = this.lang;
        document.getElementById("HelloWorld").innerHTML = this.greeting;
    }
}

let America = new Country("America", "English", "Hello World!", ["red", "white", "blue"] );
let Japan = new Country("Japan", "Japenses", "「こんにちは世界」", ["red", "white", "white"] );
let Germany = new Country("Germany", "German", "Hallo Welt!", ["black", "red", "gold"]);
let Ireland = new Country("Ireland", "Irish", "Dia duit Domhanda!", ["green", "white", "orange"] );
let Sweden = new Country("Sweden", "Swedish", "Hej världen!", ["blue", "yellow", "yellow"] );

function SwitchCountry() {
    let country = document.getElementById("CountryList").value;

    switch(country){
        case "Japan":
            Japan.DisplayColors();
            break;
        
        case "Germany":
            Germany.DisplayColors();
            break;

        case "Ireland":
            Ireland.DisplayColors();
            break;
        case "Sweden":
            Sweden.DisplayColors();
            break;
        default:
            America.DisplayColors();
            break;
    }
}