fn main() {
    greet_world(); // greet_world 함수 호출한다.
}

fn greet_world() {
    println!("Hello, world!"); // !는 매크로 호출을 의미한다.

    let southern_germany = "Bavaria, Baden-Württemberg, Hesse"; // 러스트에서 할당문이다. let 키워드를 이용하여 변수를 바인딩한다.
    let korean = "안녕 세상아"; // 유니코드가 기본적으로 제공된다.
    let regions = [southern_germany, korean]; // 배열 리터럴을 표현할 때에는 대괄호를 쓴다.

    for region in regions.iter() {
        // 많은 타입에 이터레이터를 반환하는 iter() 메서드가 구현되어 있다.
        println!("{}", &region); // &는 영역 내의 값을 읽기 전용으로 borrow할 때 사용된다.
    }
}
