# utils 라이브러리 생성
add_library(utils hello.cpp)

target_include_directories(utils PUBLIC
    ${CMAKE_CURRENT_SOURCE_DIR}
)

