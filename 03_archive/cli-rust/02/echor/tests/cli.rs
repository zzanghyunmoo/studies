use std::fs;

use assert_cmd::Command;
use predicates::prelude::*;

#[test]
fn dies_no_args() {
    let mut cmd = Command::cargo_bin("echor").unwrap();
    cmd.assert()
        .failure()
        .stderr(predicate::str::contains("Usage"));
}

#[test]
fn hello1() {
    let out_file = "tests/expected/hello1.txt";
    let expected = fs::read_to_string(out_file).unwrap();
    println!("Expected: {}", expected);
    let mut cmd = Command::cargo_bin("echor").unwrap();
    cmd.arg("Hello there").assert().success().stdout(expected);
}