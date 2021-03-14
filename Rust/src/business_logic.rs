use super::*;

pub fn calculate_workers_salary_with_function(
    number_of_workers: i32, 
    base: f32, 
    sum_of_incomes: f32, 
    employee_income: f32, 
    important_calculation_factor: f32,
    calculate_salary: fn(f32, f32, f32, f32) -> f32 ) -> f32 {
        number_of_workers as f32 
        * calculate_salary(base, sum_of_incomes, employee_income, important_calculation_factor)
}

pub fn calculate_workers_salary_with_trait(
    number_of_workers: i32, 
    base: f32, 
    sum_of_incomes: f32, 
    employee_income: f32, 
    important_calculation_factor: f32,
    calculator: impl CalculateSalary) -> f32 {
        number_of_workers as f32 
        * calculator.calculate_salary(
            base, 
            sum_of_incomes, 
            employee_income, 
            important_calculation_factor)
}

pub fn calculate_workers_but_with_factory_method(
    number_of_workers: i32, 
    base: f32, 
    sum_of_incomes: f32, 
    employee_income: f32, 
    important_calculation_factor: f32,
    create_calculator: fn(f32) -> WorkerService ) -> f32 {
        // If create_calculator can be done once in lifetime, we cane simply change our approach to use
        // save this state somewhere. 
        // It can be done in higher level module function and it will be borrowed to lower level function by parameter.
        // We can create struct to hold this state as its own. 
        // Or we can do as it was done here. Create this calculator each time. 
        // It pretty much depends on current state.
        number_of_workers as f32 
        * create_calculator(100.0) 
            .calculate_salary(
                base, 
                sum_of_incomes, 
                employee_income, 
                important_calculation_factor)
}