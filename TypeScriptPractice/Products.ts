
export interface Product{
    name: string,
    price: number
}

let products : Product[] = [
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
]

const calcAverageProductPrice = (productArray :Product[]):number => {
    let rawAverage = 0;
    productArray.forEach((product) => {
        rawAverage += product.price;
    });

    return rawAverage / productArray.length;
}

let average = calcAverageProductPrice(products);

console.log(average);
