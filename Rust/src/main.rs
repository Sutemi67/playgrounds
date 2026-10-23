use std::io::{self, BufRead};

fn main() {
    let mut handle = io::stdin().lock();
    let mut input = String::new();
    handle.read_line(&mut input).unwrap();
    let numbers_strings: Vec<&str> = input.trim().split(" ").collect();
    let mut numbers: Vec<i32> = Vec::new();
    for num in numbers_strings {
        numbers.push(num.trim().parse::<i32>().unwrap());
    }
    numbers.sort();

    println!("{:?}", numbers);
    println!("{:?}", numbers[1])
}
