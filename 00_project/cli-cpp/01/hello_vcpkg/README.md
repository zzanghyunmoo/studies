# 1장 CPP 단위테스트 환경 구축하기

## vcpkg 설치하기

`vcpkg`란 마이크로소프트에서 만든 C/C++을 위한 패키지 매니저이다.

다음 [문서](https://learn.microsoft.com/ko-kr/vcpkg/get_started/get-started?pivots=shell-bash) 참조하여 설치한다.

필수 조건
* c++ 
* cmake
* ninja-build
* git

다음 명령어 이용하여 설치한다.

```bash
git clone https://github.com/microsoft/vcpkg.git
cd vcpkg && ./bootstrap-vcpkg.sh
```

환경 변수를 등록한다.

```bash
echo "VCPKG_ROOT=$PWD" >> ~/.bashrc
echo "export PATH=\$PATH:$VCPKG_ROOT" >> ~/.bashrc

source ~/.bashrc
```

다음 명령어를 이용하여 설치를 확인한다.

```bash
# vcpkg version
vcpkg version 
# 다음이 출력됨    
vcpkg package management program version 2025-07-21-d4b65a2b83ae6c3526acd1c6f3b51aff2a884533

See LICENSE.txt for license information.
```

## vcpkg, cmake를 이용하여, 프로젝트 만들기

[MS 공식 문서](https://learn.microsoft.com/ko-kr/vcpkg/get_started/get-started?pivots=shell-bash)에서 관련해서 자세한 내용이 적혀 있다. 먼저 프로젝트 디렉토리를 생성한다.

```bash
mkdir hello_vcpkg && cd hello_vcpkg
```

그 후 `vcpkg new` 명령어를 이용하여, 메니페스트 파일 `vcpkg.json`을 생성한다.

```bash
vcpkg new --application
```

그 후 다음 명령어로 `fmt` 라이브러리를 추가한다.

```bash
# vcpkg add port <라이브러리 이름>
vcpkg add port fmt
```

그럼 `vcpkg.json`에 다음 내용이 추가된다.

```json
{
  "dependencies": [
    "fmt"
  ]
}
```

이제 `CMakeLists.txt` 파일을 다음과 같이 생성한다.

```txt
cmake_minimum_required(VERSION 3.10)                 # 프로젝트를 빌드하는 데 필요한 CMake의 최소 버전이 3.10임을 지정
project(hello_vcpkg)                                 # 프로젝트 이름
find_package(fmt CONFIG REQUIRED)                    # fmt 라이브러리가 있는지 확인
add_executable(hello_vcpkg src/main.cpp)             # 소스 파일 src/main.cpp 로부터 hello_vcpkg 실행 파일을 만들게 한다.
target_link_libraries(hello_vcpkg PRIVATE fmt::fmt)  # 실행 파일 hello_vcpkg에 fmt 라이브러리를 링킹합니다.
```

그 후 `src` 디렉토리를 만들고 `main.cpp` 를 생성한 후 다음과 같이 작성한다.

```cpp
#include <fmt/core.h>
#include "hello.h"

int main() {
    fmt::print("Hello Vcpkg!\n");
    return 0;
}
```

그 후 루트 디렉토리에 `CMakePresets.json`을 다음과 같이 작성한다.

```json
{
  "version": 2,
  "configurePresets": [
    {
      "name": "vcpkg",
      "generator": "Ninja",
      "binaryDir": "${sourceDir}/build",
      "cacheVariables": {
        "CMAKE_TOOLCHAIN_FILE": "$env{VCPKG_ROOT}/scripts/buildsystems/vcpkg.cmake"
      }
    }
  ]
}
```

그 후 다음 명령어를 입력하여 빌드를 구성한다.

```bash
cmake --preset=vcpkg
```

그 후 다음 명령어로 프로젝트를 빌드할 수 있다.

```bash
cmake --build build
```

애플리케이션 실행은 다음 명령어를 실행하면 된다.

```bash
./build/hello_vcpkg

# 다음이 출력됨
Hello Vcpkg!
```

## 단위테스트 할 수 있도록 리팩토링하기

테스트를 더 쉽게 하기 위해서 리팩토링을 먼저 진행한다. (보통은 테스트를 작성한 후 리팩토링을 하는 것이 일반적이다.) `src` 디렉토리 밑에 `utils` 디렉토리를 만든다. 그 후, `hello.h`를 다음과 같이 작성한다.

```h
#pragma once
#include <string>

std::string getHelloMessage();
```

그 후 함수 본문을 작성하기 위해서 `hello.cpp`를 작성한다.

```cpp
#include "hello.h"

std::string getHelloMessage() {
    return "Hello Vcpkg!\n";
}
```

이후 `utils` 디렉토리에 대해서 `cmake` 빌드에 들어갈 수 있도록 `CMakeLists.txt`를 `utils` 디렉토리 밑에 하나 생성한다.

```txt
# utils 라이브러리 생성
# 여기에는 "<라이브러리 이름> <등록할 cpp 파일 1> <등록할 cpp 파일 2> ..." 이렇게 작성한다. 
add_library(utils hello.cpp)              

# utils 디렉토리 하위에 작성된 헤더들을 찾을 수 있게 하는 설정입니다.
target_include_directories(utils PUBLIC  
    ${CMAKE_CURRENT_SOURCE_DIR}
)
```

그리고 루트 `CMakeLists.txt`를 다음과 같이 수정한다.

```txt
cmake_minimum_required(VERSION 3.10)
project(hello_vcpkg)

set(CMAKE_CXX_STANDARD 17)

# utils 라이브러리 등록
add_subdirectory(src/utils)

find_package(fmt CONFIG REQUIRED)
add_executable(hello_vcpkg src/main.cpp)

# fmt와 함께 utils 라이브러리 등록
target_link_libraries(hello_vcpkg 
    PRIVATE
        fmt::fmt utils
)
target_include_directories(hello_vcpkg 
    PUBLIC
        "${PROJECT_BINARY_DIR}"
        "${PROJECT_SOURCE_DIR}/utils"
)
```

이제 `src/main.cpp`를 다음과 같이 수정한다.
```cpp
#include <fmt/core.h>
#include "hello.h"

int main() {
    auto message = getHelloMessage();
    fmt::print(message);
    return 0;
}
```

그 다음 빌드하여, 정사 결과가 반환되는지 확인합니다.

```bash
# 라이브러리 추가 후 빌드 재구성
cmake --preset=vcpkg       

# 빌드
cmake --build build

# 실행 파일 실행
./build/hello_vcpkg
```

## Google Test 라이브러리를 이용하여 단위 테스트 환경 구축하기

이제 `gtest(Google Test)` 라이브러리를 이용하여 단위 테스트 환경을 구축할 것이다. 다음 명령어를 입력한다.

```bash
vcpkg add port gtest
```


그럼 `vcpkg.json`에 다음 내용이 추가된다.

```json
{
  "dependencies": [
    "fmt",
    "gtest" // <- 추가
  ]
}
```

그 후 `tests` 디렉토리를 만들고 `main_test.cpp`를 다음과 같이 작성한다.

```cpp
#include <gtest/gtest.h>
#include "hello.h"

TEST(MainTest, ReturnsHelloVcpkg) {                 // TEST 매크로는 테스트를 실행하는 함수를 의미한다. 첫 번째 인수는 TestSuitName, 두 번쨰 인수는 TestName이다. 간단하게 말하면, MainTest는 실행할 테스트 클래스, ReturnsHelloVcpkg는 테스트 메소드 이름이다.
    auto message = getHelloMessage();
    EXPECT_EQ(message, "Hello Vcpkg!\n");
}


int main(int argc, char **argv) {                   // gtest 실행 메인 함수이다. 테스트 실행 시, 엔드리포인트가 된다.
    ::testing::InitGoogleTest(&argc, argv);
    return RUN_ALL_TESTS();
}
```

그 후 `CMakeLists.txt`에 다음 내용을 추가한다.

```txt
cmake_minimum_required(VERSION 3.10)
project(hello_vcpkg)
set(CMAKE_CXX_STANDARD 17)

add_subdirectory(src/utils)

find_package(fmt CONFIG REQUIRED)
add_executable(hello_vcpkg src/main.cpp)
target_link_libraries(hello_vcpkg 
    PRIVATE
        fmt::fmt utils
)
target_include_directories(hello_vcpkg 
    PUBLIC
        "${PROJECT_BINARY_DIR}"
        "${PROJECT_SOURCE_DIR}/utils"
)

# 추가된 내용
enable_testing()
find_package(GTest CONFIG REQUIRED)
add_executable(hello_vcpkg_tests tests/main_test.cpp)
target_link_libraries(hello_vcpkg_tests 
    PRIVATE 
        GTest::gtest GTest::gtest_main fmt::fmt pthread utils
)
target_include_directories(hello_vcpkg_tests
    PUBLIC
        "${PROJECT_BINARY_DIR}"
        "${PROJECT_SOURCE_DIR}/utils"
)

add_test(NAME hello_vcpkg_tests COMMAND hello_vcpkg_tests)
```

그 후, 다음 명령어를 입력한다.

```bash
# 라이브러리 추가 후 빌드 재구성
cmake --preset=vcpkg       

# 빌드
cmake --build build
```

이후 다음 명령어를 입력하면 테스트 파일을 실행할 수 있다.

```bash
cd build && ctest && cd ../
# 다음이 출력됨
Test project /home/gurumee/Workspaces/studies/00_project/cli-cpp/01/hello_vcpkg/build
    Start 1: hello_vcpkg_tests
1/1 Test #1: hello_vcpkg_tests ................   Passed    0.00 sec

100% tests passed, 0 tests failed out of 1

Total Test time (real) =   0.01 sec
```