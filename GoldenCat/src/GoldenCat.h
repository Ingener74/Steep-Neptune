#pragma once

#ifndef SWIG
    #include <QtCore/QString>
#endif

namespace golden_cat {

class GoldenCat {
public:
    GoldenCat();
    virtual ~GoldenCat();

    void test(const QString& string);
};

}
