package main

import (
	"fmt"
	"os"
	"strings"
)

func echo1() string {
	var s, sep string
	for i := 1; i < len(os.Args); i++ {
		s += sep + os.Args[i]
		sep = " "
	}
	return s
}

func echo2() string {
	s, sep := "", " "
	for _, arg := range os.Args[1:] {
		s += arg + sep
	}
	return s
}

func echo3() string {
	return strings.Join(os.Args[1:], " ")
}

func main() {
	fmt.Println("echo1:", echo1())
	fmt.Println("echo2:", echo2())
	fmt.Println("echo3:", echo3())
}
