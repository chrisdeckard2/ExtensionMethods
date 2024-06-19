﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods;

public static class MyFirstExtensionMethods {

    public static void Debug(this string str, string label) {
        Console.WriteLine($"{label} : [{str}]");
    }

    public static void Debug(this int i, string label) {
        Console.WriteLine($"{label} : [{i}]");
    }

    public static int Cubed(this int i) {
        return i * i * i;
    }

    public static int Func(this int x) {
        return (x * x) + (x * 3) + 5;


    }
}
