using System;
using System.ComponentModel;

namespace BetterDotMath
{
    public class Maths
    {
        // Addition
        public int Add(int a, int b) { return a + b; }
        public int Add(int a, int b, int c) { return a + b + c; }
        public float Add(float a, float b) { return a + b; }
        public float Add(float a, float b, float c) { return a + b + c; }
        public double Add(double a, double b) { return a + b; }
        public double Add(double a, double b, double c) { return a + b + c; }

        // Subtraction
        public int Sub(int a, int b) { return a - b; }
        public int Sub(int a, int b, int c) { return a - b - c; }
        public float Sub(float a, float b) { return a - b; }
        public float Sub(float a, float b, float c) { return a - b - c; }
        public double Sub(double a, double b) { return a - b; }
        public double Sub(double a, double b, double c) { return a - b - c; }

        // Multiplication
        public int Mul(int a, int b) { return a * b; }
        public int Mul(int a, int b, int c) { return a * b * c; }
        public float Mul(float a, float b) { return a * b; }
        public float Mul(float a, float b, float c) { return a * b * c; }
        public double Mul(double a, double b) { return a * b; }
        public double Mul(double a, double b, double c) { return a * b * c; }

        // Division
        public int Div(int a, int b) { return a / b; }
        public int Div(int a, int b, int c) { return a / b / c; }
        public float Div(float a, float b) { return a / b; }
        public float Div(float a, float b, float c) { return a / b / c; }
        public double Div(double a, double b) { return a / b; }
        public double Div(double a, double b, double c) { return a / b / c; }

        // Strings
        public string Str(string a, string b) { return a + b; }
    }
}
