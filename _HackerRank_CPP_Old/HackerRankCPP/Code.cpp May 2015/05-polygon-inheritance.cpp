#include <iostream>
#include <iomanip>
using namespace std;

class Polygon {
protected:
    double width;
    double height;
public:
    Polygon(double _width, double _height) {
        width  = _width;
        height = _height;
    }
    virtual double area() = 0;
};

// -------------------------------------------------------------------

class Rectangle: public Polygon {
public:
    Rectangle(double width, double height) : Polygon(width, height) {}
    
    double area() override {
        return width * height;
    }
};

class Triangle: public Polygon {
public:
    Triangle(double width, double height) : Polygon(width, height) {}
    
    double area() override {
        return (width * height) / 2;
    }
};

// -------------------------------------------------------------------

int main() {
    double width, height;
    cin >> width >> height;

    Polygon *rectangle = new Rectangle(width, height);
    Polygon *triangle  = new Triangle(width, height);

    cout << setprecision(1) << fixed << rectangle->area() << "\n"  << triangle->area() << endl;

    return 0;
}