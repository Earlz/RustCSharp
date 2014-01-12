use std::io::println;

#[no_mangle]
pub extern fn foorust() {
  println("hello from rust!");
}
