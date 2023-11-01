"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var products = [
    {
        name: "pizza",
        price: 10.98
    },
    {
        name: "coca-cola",
        price: 2.51
    },
    {
        name: "beans",
        price: 6.52
    }
];
var calcAverageProductPrice = function (productArray) {
    var rawAverage = 0;
    productArray.forEach(function (product) {
        rawAverage += product.price;
    });
    return rawAverage / productArray.length;
};
var average = calcAverageProductPrice(products);
console.log(average);
