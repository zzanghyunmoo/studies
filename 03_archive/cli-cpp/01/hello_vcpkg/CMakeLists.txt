cmake_minimum_required(VERSION 3.10)
project(hello_vcpkg)

set(CMAKE_CXX_STANDARD 17)

add_subdirectory(src/utils)

# dependencies
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

# dev-dependencies
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