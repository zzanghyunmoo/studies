package main

import (
	"fmt"
	"os"
	"strings"
)

func echo() string {
	s := ""
	const SEPARATOR = "\n"

	s += strings.Join(os.Args[1:], SEPARATOR)
	return s
}

func main() {
	fmt.Println(echo())
}
