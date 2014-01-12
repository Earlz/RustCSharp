
default: libtest.so

libtest.so: 
	rustc --dylib -o libtest.so test.rs
	cp ../RustCSharpTest/bin/

clean: 
	rm -f libtest.so ../RustCSharpTest/bin/libtest.so

