/// Trait for all salary strategies.
///
/// Based on parameters it will calculate new salary for worker using all parameters. Yeah useless comment :) 
pub trait CalculateSalary {
    fn calculate_salary(
        &self,
        base: f32, 
        sum_of_incomes: f32, 
        employee_income: f32, 
        important_calculation_factor: f32) -> f32;
}

/// Example strategy for workers.
pub struct WorkerService {
    pub avg_salary: f32
}

impl WorkerService {
    // This is: Creator method
    pub fn new(avg_salary: f32) -> WorkerService {
        WorkerService {
            avg_salary: avg_salary
        }
    }
}

/// Implementation of CalculateSalary trait.
/// 
/// The question is when to use it? 
/// I would recommend to use this approach when there is a state to use during calculation. 
/// If not I would go with passing pure function.
impl CalculateSalary for WorkerService {
    fn calculate_salary(
        &self,
        base: f32, 
        sum_of_incomes: f32, 
        employee_income: f32, 
        important_calculation_factor: f32) -> f32 {
            calculate_worker_salary(base, sum_of_incomes, employee_income, important_calculation_factor) - 0.5 * self.avg_salary 
        } 
}

/// Calculates salary for workers.
///
/// Based on parameters it will calculate new salary for worker using all parameters. Yeah useless comment :) 
///
/// ```
/// let result = calculate_worker_salary(100.0, 100.0, 1.0, 2.0)
/// assert_eq!(result, 102.0);
/// ```
pub fn calculate_worker_salary(
    base: f32, 
    _sum_of_incomes: f32, 
    employee_income: f32, 
    important_calculation_factor: f32) -> f32 {
        base + employee_income * important_calculation_factor
}
#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn should_calculate_salary_for_worker_fn() {
        assert_eq!(102.0, calculate_worker_salary(100.0, 100.0, 1.0, 2.0));
    }

    #[test]
    fn should_calculate_salary_for_worker_tr() {
        let worker_service : WorkerService = WorkerService::new(100.0);
        assert_eq!(52.0, worker_service.calculate_salary(100.0, 100.0, 1.0, 2.0));
    }
}