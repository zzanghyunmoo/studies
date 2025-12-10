// 이 파일은 'main' 패키지에 속합니다. Go 프로그램은 패키지로 구성되며, 'main' 패키지는 실행 가능한(실행할 수 있는) 프로그램을 만듭니다.
package main

// "fmt" 패키지를 가져옵니다. "fmt"는 "format"의 줄임말로,
// 입출력(예: 화면에 텍스트 출력) 기능을 제공하는 표준 라이브러리입니다.
import "fmt"

// 'main' 함수는 Go 프로그램의 시작점입니다.
// 프로그램이 실행될 때 가장 먼저 호출되는 함수입니다.
func main() {
	// 'fmt' 패키지의 'Println' 함수를 사용하여 "Hello World!" 문자열을 화면에 출력합니다.
	// 'Println'은 괄호 안의 내용을 출력하고 새 줄(개행)을 추가합니다.
	fmt.Println("Hello World!")
}
