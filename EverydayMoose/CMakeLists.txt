cmake_minimum_required(VERSION 3.0)

find_package(SWIG REQUIRED)
include(UseSWIG)

set_source_files_properties(EverydayMoose.i PROPERTIES CPLUSPLUS ON)
set_source_files_properties(EverydayMoose.i PROPERTIES SWIG_FLAGS "-nodefaultctor")

set(PACKAGE_FIERCESHOWER "everyday_moose")

set(CMAKE_SWIG_FLAGS "-c++")

SWIG_ADD_MODULE(EverydayMoose csharp EverydayMoose.i)

set(SHARED_LIBS GoldenCat Qt5::Widgets Qt5::Core)
SWIG_LINK_LIBRARIES(EverydayMoose ${SHARED_LIBS})
