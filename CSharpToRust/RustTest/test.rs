use std::io::println;
use std::c_str::CString;
use std::libc::c_char;

#[no_mangle]
pub extern fn foorust() {
  println("hello from rust!");
}

#[no_mangle]
pub extern fn rust_add(op1: i32, op2: i32) -> i32 {
  return op1+op2;
}

#[no_mangle]
pub extern fn rust_strings(s: *c_char) -> i32{
    unsafe{
        let cs=CString::new(s, false);
        let st=cs.as_str();
        match(st){
            Some(ref ts) => {
                println(*ts);
                return 0;
            },
            None => println("Error!")
        }
    }
    return 1;

}

