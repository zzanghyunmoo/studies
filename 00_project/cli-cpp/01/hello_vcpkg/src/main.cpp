#include <fmt/core.h>
#include "hello.h"

int main() {
    auto message = getHelloMessage();
    fmt::print(message);
    return 0;
}