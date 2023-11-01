var mountainArray = [
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
];
var findNameOfTallestMountain = function (array) {
    var tallest = { name: "", height: 0 };
    for (var i = 0; i < array.length; i++) {
        if (array[i].height > tallest.height) {
            tallest = array[i];
        }
    }
    return "Tallest mountain is ".concat(tallest.name);
};
var tallest;
tallest = findNameOfTallestMountain(mountainArray);
console.log(tallest);
