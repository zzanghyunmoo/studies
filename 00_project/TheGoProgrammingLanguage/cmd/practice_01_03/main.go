package main

import (
	"fmt"
	"os"
	"strings"
	"time"
)

func echo1() string {
	s := ""
	const SEPARATOR = " "

	s += strings.Join(os.Args[1:], SEPARATOR)
	return s
}

func echo2() string {
	s := ""
	const SEPARATOR = " "

	for _, arg := range os.Args[1:] {
		s += arg + SEPARATOR
	}
	return s
}

func measureTime(funcName string, f func() string) {
	before := time.Now()
	fmt.Println(f())
	after := time.Now()
	fmt.Println(funcName, "time:", after.Sub(before))
}

func main() {
	measureTime("echo1", echo1)
	measureTime("echo2", echo2)
}
