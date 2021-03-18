
#[allow(dead_code)]
pub struct Order {
    customer_id: String,
    amount: f32,
}

pub struct OrderBuilder {   
    customer_id: std::option::Option<String>,
    amount: std::option::Option<f32>,
}

impl OrderBuilder {
    pub fn customer_id(&mut self, customer_id: String) -> &mut Self {
        self.customer_id = Some(customer_id);
        self
    }
    pub fn amount(&mut self, amount: f32) -> &mut Self {
        self.amount = Some(amount);
        self
    }
    pub fn build(&mut self) -> Result<Order, Box<dyn std::error::Error>> {
        Ok(Order {
            customer_id: self.customer_id.clone().ok_or("customer_id is not set")?,
            amount: self.amount.clone().ok_or("amount is not set")?,
        })
    }
}

impl Order {
    fn builder() -> OrderBuilder {
        OrderBuilder {
            customer_id: None,
            amount: None,
        }
    }
}

fn main() {
    let _order = Order::builder()
        .customer_id("123".to_owned())
        .amount(123.0)
        .build()
        .unwrap();
}