import {Product} from "./Products";


interface InventoryItem {
    product: Product,
    quantity: number
}

let inventory:InventoryItem[] = [
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
]

const calcInventoryValue = (array: InventoryItem[]) : number => {
    let total = 0;
    array.forEach((item) => {
        total += (item.product.price * item.quantity);
    })

    return total;
}

let inventoryTotal = calcInventoryValue(inventory);

console.log(inventoryTotal);