
interface Mountain{
    name: string,
    height: number
}

let mountainArray :Mountain[] = [
    {
        name: "Kilimanjaro",
        height: 19341
    },
    {
        name: "Everest",
        height: 29029
    },
    {
        name: "Denali",
        height: 20310
    }
]

const findNameOfTallestMountain = (array: Mountain[]) :string=> {
        let tallest:Mountain = {name: "", height: 0}

        for(let i = 0; i < array.length; i++){
            if(array[i].height > tallest.height){
                tallest = array[i]
            }
        }

        return `Tallest mountain is ${tallest.name}`;
}

let tallest;
tallest = findNameOfTallestMountain(mountainArray);

console.log(tallest);