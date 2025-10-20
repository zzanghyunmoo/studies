package main

import (
	"fmt"
	"os"
)

func echo() string {
	var s, sep string
	for i := range len(os.Args) {
		s += sep + os.Args[i]
		sep = " "
	}
	return s
}

func main() {
	fmt.Println(echo())
}
