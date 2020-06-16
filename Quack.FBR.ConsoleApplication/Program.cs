using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Quack.FBR.Contracts;
using Quack.FluentBusinessRules;
using Rule = Quack.FluentBusinessRules.Rule;

namespace Quack.FBR.ConsoleApplication
{
    /// <summary>
    /// program for easily spining up the application to run some tests.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var rule = new Rule(nameof(Person.Age), new Operator(System.Linq.Expressions.ExpressionType.Multiply), 5);

            var person = new Person();
            person.FirstName = "Hello";
            person.LastName = "bla";
            person.Age = 5;

            var func = new PredicateCompiler().Create<Person, int>(rule);

            var persons = new List<Person>();
            persons.Add(person);

            var result = persons.Select(func).ToList();
        }
    }
    public class Person : IPersonRuleContract
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }

}
