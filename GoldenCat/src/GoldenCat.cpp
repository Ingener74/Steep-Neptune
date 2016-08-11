#include <iostream>

#include "GoldenCat.h"

namespace golden_cat {

using namespace std;

GoldenCat::GoldenCat() {
}

GoldenCat::~GoldenCat() {
}

void GoldenCat::test(const QString& string) {
    cout << string.toStdString() << endl;
}

}
