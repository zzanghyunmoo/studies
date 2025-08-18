#include <gtest/gtest.h>
#include "hello.h"

TEST(MainTest, ReturnsHelloWorld) {
    EXPECT_EQ(getHelloMessage(), "Hello World!\n");
}


int main(int argc, char **argv) {
    ::testing::InitGoogleTest(&argc, argv);
    return RUN_ALL_TESTS();
}