use clap::{Arg, ArgAction, Command};

fn main() {
    let matches = Command::new("echor")
        .version("0.1.0")
        .author("Zzanghyunmoo <zzanghyunmoo@gmail.com>")
        .about("Rust version of `echo`")
        .arg(
            Arg::new("text")
                .value_name("TEXT")
                .help("Input text")
                .required(true)
                .num_args(1..),
        )
        .arg(
            Arg::new("omit_newline")
                .short('n')
                .action(ArgAction::SetTrue)
                .help("Do not print newline")
        )
        .get_matches();
    
    // 타입 지정은 : 뒤에 온다.
    // Iterator::collect는 여러 타입이 될 수 있으므로, 타입 지정이 필요.
    let text: Vec<String> = matches.get_many("text").unwrap().cloned().collect();
    let omit_newline = matches.get_flag("omit_newline");
    let ending = if omit_newline { "" } else { "\n" };
    print!("{}{ending}", text.join(" "));
}
