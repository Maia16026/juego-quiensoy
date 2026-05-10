using System;
using System.Collections.Generic;

namespace WiW{
	public class Cola<T>
	{

		
		private Queue<T> datos;

		public Cola()
        {
            datos = new Queue<T>();
        }
		public void Encolar(T elemento)
        {
            datos.Enqueue(elemento);
        }
		public T Desencolar()
        {
            if (EsVacia())
            {
                throw new InvalidOperationException("La cola está vacía");
            }

            return datos.Dequeue();
        }
		public T Primero()
        {
            if (EsVacia())
            {
                throw new InvalidOperationException("La cola está vacía");
            }

            return datos.Peek();
        }
		public bool EsVacia()
        {
            return datos.Count == 0;
        }
		public int Cantidad()
        {
            return datos.Count;
        }
		public void encolar(T elemento) => Encolar(elemento);

        public T desencolar() => Desencolar();

        public T tope() => Primero();

        public bool esVacia() => EsVacia();
		
	}
}
