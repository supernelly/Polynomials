﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Jimy_Nelson
{
    public class Term : IComparable
    {
        private double Coefficient;
        private byte Exponent;
        // Creates a term with the given coefficient and exponent
        public Term(double coefficient, byte exponent)
        {
            Coefficient = coefficient;
            Exponent = exponent;

        }
        public double coeff
        {
            set
            { Coefficient = value; }
            get
            { return Coefficient; }
        }
        public Byte expo
        {
            set
            { Exponent = value; }
            get
            { return Exponent; }
        }
        // Evaluates the current term for a given x
        public double Evaluate(double x)
        {
            double coeff,answer;
            byte expo;
            coeff = Coefficient;
            expo = Exponent;
            answer = coeff * Math.Pow(x, coeff);

            return answer;
        }
        // Returns -1, 0, or 1 if the exponent of the current term
        // is less than, equal to, or greater than the exponent of obj.
        public int CompareTo(Object obj)
        {
            return 0;
        }
        // Read and write properties for each data member
    }

    public class Node<T>
    {
        private T item;
        private Node<T> next;
        public Node(T item, Node<T> next)
        { }
        // Read and write properties for each data member
    }

    interface IDegree
    {
        bool Order(Object obj);
    }
    public class Polynomial : IDegree
    {
        // A reference to the first node of a singly-linked list
        private Node<Term> front;
        // Creates the polynomial 0
        public Polynomial()
        { }
        // Inserts the given term t into the current polynomial in its proper order
        public Polynomial AddTerm(Term t)
        { … }
        // Adds the given polynomials p and q to yield a new polynomial
        public static Polynomial operator +(Polynomial p, Polynomial q)
        { … }
        // Multiplies the given polynomials p and q to yield a new polynomial
        public static Polynomial operator *(Polynomial p, Polynomial q)
        { … }
        // Evaluates the current polynomial for a given x
        public double Evaluate(double x)
        { … }
        // Prints the current polynomial
        public void Print()
        { … }
        public bool Order(Object obj)
        { … }
    }

    public class Polynomials
    {
        private List<Polynomial> P;
        // Creates an empty list of polynomials
        public Polynomials()
        { … }
        // Retrieves the polynomial stored at position i-1 in the list
        public Polynomial Retrieve(int i)
        { … }
        // Inserts polynomial p into the list of polynomials
        public void Insert(Polynomial p)
        { … }
        // Deletes the polynomial at index i-1
        public void Delete(int i)
        { … }
        // Prints out the list of polynomials (beginning with polynomial 1)
        public void Print()
        { … }
    }
}
