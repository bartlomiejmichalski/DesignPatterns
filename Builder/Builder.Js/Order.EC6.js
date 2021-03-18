class Order {
    constructor(build) {
       this.customerId = build.customerId;
       this.amount = build.amount;
       this.createdAt = build.createdAt;
    }
    static get CreateBuilder() {
       class Builder {
          constructor() {
             this.createdAt = Date.now();
          }
          withCustomerId(customerId) {
             this.customerId = customerId;
             return this;
          }
          withAmount(amount) {
             this.amount = amount;
             return this;
          }
          build() {
             return new Order(this);
          }
       }
       return new Builder();
    }
 }
 let orderBuilder = Order.CreateBuilder.withAmount(100);
 let order = orderBuilder.build();
 console.log(order);