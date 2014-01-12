
default: libtest.so

libtest.so: 
	rustc --dylib test.rs
	cp libtest*.so ../RustCsharpTest/bin/libtest.so

clean: 
	rm -f libtest.so ../RustCsharpTest/bin/libtest.so

