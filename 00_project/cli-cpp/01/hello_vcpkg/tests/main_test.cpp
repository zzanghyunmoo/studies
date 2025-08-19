#include <gtest/gtest.h>
#include "hello.h"

TEST(MainTest, ReturnsHelloVcpkg) {
    auto message = getHelloMessage();
    EXPECT_EQ(message, "Hello Vcpkg!\n");
}


int main(int argc, char **argv) {
    ::testing::InitGoogleTest(&argc, argv);
    return RUN_ALL_TESTS();
}