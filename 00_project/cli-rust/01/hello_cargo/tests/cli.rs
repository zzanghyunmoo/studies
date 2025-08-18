use assert_cmd::Command;
use pretty_assertions::assert_eq;

#[test]
fn run_hello_cargo() {
    let mut cmd = Command::cargo_bin("hello_cargo").unwrap();
    let output = cmd.output().expect("fail");
    assert!(output.status.success());

    let stdout = String::from_utf8(output.stdout).expect("invalid UTF-8");
    assert_eq!(stdout.trim(), "Hello, Cargo!");
}

#[test]
fn run_true() {
    let mut cmd = Command::cargo_bin("true").unwrap();
    cmd.assert().success();
}

#[test]
fn run_false() {
    let mut cmd = Command::cargo_bin("false").unwrap();
    cmd.assert().failure();
}