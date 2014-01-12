use std::io::println;

#[no_mangle]
pub extern fn foorust() {
  println("hello from rust!");
}

#[no_mangle]
pub extern fn rust_add(op1: i32, op2: i32) -> i32 {
  return op1+op2;
}

