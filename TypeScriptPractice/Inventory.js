"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var inventory = [
    {
        product: {
            name: "motor",
            price: 10.00
        },
        quantity: 10
    },
    {
        product: {
            name: "sensor",
            price: 12.50
        },
        quantity: 4
    },
    {
        product: {
            name: "LED",
            price: 1.00
        },
        quantity: 20
    }
];
var calcInventoryValue = function (array) {
    var total = 0;
    array.forEach(function (item) {
        total += (item.product.price * item.quantity);
    });
    return total;
};
var inventoryTotal = calcInventoryValue(inventory);
console.log(inventoryTotal);
