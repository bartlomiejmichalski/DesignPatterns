let Order = function(customerId, amount, createdAt) {
    this.customerId = customerId;
    this.amount = amount;
    this.createdAt = createdAt;
}

let OrderBuilder = function () {
    let customerId;
    let amount;
    let createdAt;
    return {
        withCustomerId: function (customerId) {
            this.customerId = customerId;
            return this;
        },
        withAmount: function (amount) {
            this.amount = amount;
            return this;
        },
        withCreatedAt: function (createdAt) {
            this.createdAt = createdAt;
            return this;
        },
        build: function () {
            return new Order(this.customerId, this.amount, this.createdAt);
        }
    }
}
console.log(new Order(12345678, 100.0, new Date(2019, 5, 12)));

let task = new OrderBuilder()
    .withCustomerId('12345678')
    .withAmount('100.0') 
    .withCreatedAt(new Date(2019, 5, 12))
    .build();
console.log(task);
