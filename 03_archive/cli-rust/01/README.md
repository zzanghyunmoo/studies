# 1장 위험한 진실 true와 false

## Hello Rust!

적당한 디렉토리에 `main.rs`를 다음과 같이 작성.

```rs
fn main() {
    println!("Hello, Rust!");
}
```

다음 명령어로 컴파일

```bash
# rustc <main 함수가 들어 있는 rust 파일>
rustc main.rs
```

그럼 `main` 실행 파일이 생겨남. 보통 별도 옵션을 주지 않는다면, 컴파일 타켓이 된 파일 이름을 따라감. 파일을 실행하려면 다음 명령어 이용

```bash
./main
Hello, Rust!
```


## Hello Cargo

러스트는 빌드 도구로 `cargo`라는 것을 제공함. 프로젝트를 생성하려면 적당한 디렉토리에서 다음 명령어 실행

```bash
# cargo new <프로젝트 이름>
cargo new hello_cargo
```

프로젝트 이동하려면 다음 명령어 이용.

```bash
# cd <프로젝트 이름>
cd hello_cargo 
```

그럼 다음과 같이 파일이 생성됨

```bash
tree
.
├── Cargo.toml
├── src
    └── main.rs
```

`main.rs`에서는 다음과 같은 러스트 코드가 작성되어 있음.

```rs
fn main() {
    println!("Hello, world!");
}
```

프로젝트를 실행하려면 프로젝트 루트 디렉토리에서 다음 명령어를 입력하면 됨.
```bash
# cargo run
cargo run
...
Hello, world!
```

여기서 `target/debug`에 실행 파일이 생성됨. 특이한 건 `main`이 아닌 프로젝트 이름인 `hello_cargo`임. 이유는 `Cargo.toml`에 있음.

```toml
[package]
name = "hello_cargo" # 프로젝트 이름이자 실행 파일의 이름.
version = "0.1.0"    # 프로젝트 버전. x.y.z 일때, x는 메이저, y는 마이너, z는 패치 버전을 의미함.
edition = "2024"     # 러스트 에디션

[dependencies]       # 외부 의존성을 나열하는 곳. rust에서는 이를 crate라고 부름.
```

## 단위 테스트 작성하기

프로젝트 루트 디렉토리에서 `tests` 라는 디렉토리를 만든다.

```bash
mkdir -p hello_cargo/tests
```

여기서 `cli.rs`를 다음과 같이 생성

```rs
use std::process::Command;                      // 표준 라이브러리 Command 라이브러리를 import 합니다. 

#[test]
fn run_hello_cargo(){
    let mut cmd = Command::new("ls");           // ls 명령어를 실행할 Command 개체를 생성합니다.
    let res = cmd.output();                     // 명령을 실행하고 결과를 가져옵니다.
    assert!(res.is_ok());                       // 결과 작업이 성공했는지 검사합니다.
}
```

테스트는 다음과 같이 실행할 수 있다.

```bash
cargo test
...
running 1 test
test run_hello_cargo ... ok
```

## 프로젝트에 외부 의존성 추가

`rust`는 `crate`라고 불리우는 외부 라이브러리를 `cargo`를 이용해서 손쉽게 가져올 수 있다. `Cargo.toml`에 다음을 추가한다.

```toml
[package]
name = "hello_cargo"
version = "0.1.0"
edition = "2024"

[dependencies]

[dev-dependencies]           # <- 개발 시, 테스트 구동할 때만 쓰이는 외부 라이브러리 목록을 나열하는 곳.
assert_cmd = "2.0.13"        # <- 외부 라이브러리 `assert_cmd`를 추가. 카고 바이너리 디렉토리를 들여다보는 `Command` 개체를 생성할 수 있다.
pretty_assertions = "1.4.0"  # <- 외부 라이브러릴 `pretty_assertions`를 추가. 기본 버전의 `assert_eq!` 같이, 기존 `assert!` 문 보다 더 차이를 잘 보여주는 테스트 유틸 라이브러리.
```

이제 `cli.rs`를 다음과 같이 수정한다.

```rust
use assert_cmd::Command;                                                    // 프로젝트에서 생성한 바이너리 파일을 읽을 수 있는 Command 개체를 위해 import 합니다.
use pretty_assertions::assert_eq;                                           // 조금 더 이쁘게 테스트를 할 수 있는 assert_eq 매크로를 import 합니다.

#[test]
fn run_hello_cargo() {
    let mut cmd = Command::cargo_bin("hello_cargo").unwrap();               // hello_cargo 명령어를 실행할 Command 개체를 생성합니다.
    let output = cmd.output().expect("fail");                               // .output() 은 hello_cargo 명령어를 실행합니다. .expect()는 그 결과를 정상이면 명령어 실행 결과를, 실패하면 fail이라는 문자열을 가져옵니다.
    assert!(output.status.success());                                       // 명령이 성공했는지 확인합니다.

    let stdout = String::from_utf8(output.stdout).expect("invalid UTF-8");  // 프로그램 출력을 UTF-8으로 변경합니다. 역시 실패시에는 "invalid UTF-8"이라는 문자열이 반환됨
    assert_eq!(stdout.trim(), "Hello, Cargo!");                             // 실제 결과와, 예상 값을 비교합니다. 성공하면, 테스트는 성공합니다.
}

```