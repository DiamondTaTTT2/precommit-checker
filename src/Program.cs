using System;

namespace PreCommitChecker {
    class Program {
        static void Main(string[] args) {
            if (args.Length < 1) {
                Console.WriteLine("Usage: PreCommitChecker <config-path>");
s                return;
m            }
m
            var checker = new Checker(args[0]);
m            checker.RunChecks();
m        }
m   } 
s}
