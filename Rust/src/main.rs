mod business_logic;
mod salary_strategy;
mod salary_strategy_factory;

use business_logic::{
    calculate_workers_salary_with_function, 
    calculate_workers_salary_with_trait,
    calculate_workers_but_with_factory_method};
#[allow(unused_imports)]
use salary_strategy::{calculate_worker_salary, WorkerService, CalculateSalary};
use salary_strategy_factory::create_worker_service;

fn main() {
    let worker_service : WorkerService = WorkerService::new(100.00);
    println!("Tr: New simulated salary is {}", 
        calculate_workers_salary_with_trait(100, 100.0, 100.0, 1.0, 2.0, worker_service));

    println!("Fn: New simulated salary is {}", 
        calculate_workers_salary_with_function(100, 100.0, 100.0, 1.0, 2.0, calculate_worker_salary));

        println!("Fn: New simulated salary is {}", 
        calculate_workers_but_with_factory_method(100, 100.0, 100.0, 1.0, 2.0, create_worker_service));    
}