// 프로젝트를 실행하기 위해서는 main 함수가 필요하다.
fn main() {
    // 뒤에 오는 줄바꿈을 피한다.
    let penguins_data = r#"\ 
    common name,length (cm)
    Little penguin,33
    Yellow-eyed penguin,65
    Fiordland penguin,60
    Invalid,data
    "#;
    let records = penguins_data.lines();

    for (i, record) in records.enumerate() {
        // 제목과 공백이 있는 줄은 처리하지 않는다.
        if i == 0 || record.trim().len() == 0 {
            continue;
        }

        let fields: Vec<_> = record // 한 줄 텍스트로 시작한다.
            .split(',') // record를 ,로 나눈다.
            .map(|field| field.trim()) // 각 필드의 양 끝 공백을 제거한다.
            .collect(); // field 모음을 벡터 하나로 합친다.

        // cfg!는 컴파일 시 주어진 환경 설정을 검사한다.
        if cfg!(debug_assertions) {
            eprintln!("debug: {:?} -> {:?}", record, fields); // eprintln!은 표준 오류로 내용을 출력한다. 
        }

        let name = fields[0];
        if let Ok(length) = fields[1].parse::<f32>() {
            // 해당 필드를 소수점 수로 파싱을 시도한다.
            // 파싱이 성공했을 때, 이름, 길이를 출력한다.
            println!("{}, {}cm", name, length);
        }
    }
}
