cmake_minimum_required(VERSION 3.0)

add_definitions(-fPIC)

set(GoldenCat_SOURCES
    src/GoldenCat.h
    src/GoldenCat.cpp
)

add_library(GoldenCat ${GoldenCat_SOURCES})
