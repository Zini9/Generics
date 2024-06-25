﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintService<T>
    {
        //Variavel interna que poderá armazenar 10 numeros inteiros
        private T[] _values = new T[10];
        //Variavel pra contar quantos inteiros
        private int _count = 0;


        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrinService is full");
            }

            _values[_count] = value;
            _count++;
        }


        public T Firt()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrinService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for(int i = 0; i < _count -1; i++) 
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count -1]);
            }

            Console.WriteLine("]");
        }


    }
}
