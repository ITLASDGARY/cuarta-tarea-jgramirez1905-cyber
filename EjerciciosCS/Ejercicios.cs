using System;
using System.Collections.Generic;

namespace EjerciciosCS
{
    /// <summary>
    /// Ejercicios de C# para practicar Arrays y Listas
    /// </summary>
    public class Ejercicios
    {
        private int[] _arrayGenerado = Array.Empty<int>();
        /// <summary>
        /// 1. EL PROFESOR PEREZOSO (Arrays)
        /// 
        /// PISTAS:
        /// - Crea un array de 'double' llamado 'temperaturas' con 5 elementos
        /// - Asigna valores inventados directamente en el código (ej: 23.5, 24.0, etc.)
        /// - Usa un bucle 'for' para sumar todas las temperaturas
        /// - Divide la suma entre 5 para obtener el promedio
        /// - Retorna el promedio calculado
        /// </summary>
        /// <returns>El promedio de las 5 temperaturas</returns>
        public double CalcularPromedioTemperatura()
        {
            // TODO: Implementar el cálculo del promedio de temperaturas
            double promedio = 0.0; 
            

        {
            // Crear el array con 5 temperaturas inventadas
            double[] temperaturas = { 23.5, 24.0, 22.8, 25.1, 23.9 };

            // Variable para acumular la suma
            double suma = 0.0;

            // Recorrer el array con un bucle for
            for (int i = 0; i < 5; i++)
            {
                suma += temperaturas[i];
            }

            // Calcular el promedio
            double promedio = suma / 5;

            // Retornar el resultado
            return promedio;
        }

            
            return promedio;
        }

        /// <summary>
        /// 2. LISTA DE SUPERMERCADO (Listas)
        /// 
        /// PISTAS:
        /// - Crea una 'List<string>' para almacenar los productos
        /// - Usa Console.WriteLine() para pedir al usuario que ingrese productos
        /// - Usa un bucle 'while (true)' para pedir productos continuamente
        /// - Usa Console.ReadLine() para leer lo que escribe el usuario
        /// - Si el usuario escribe "salir", termina el bucle con 'break'
        /// - Usa 'foreach' para imprimir todos los productos de la lista
        /// </summary>
        /// <returns>Una List<string> con los productos ingresados por el usuario</returns>
        public List<string> CrearListaCompras()
        {
            // TODO: Implementar la lista de compras interactiva
            List<string> listaCompras = new List<string>();

        public void ListaSupermercado()
        {
            // ==========================================
            // 📌 PASO 1: Crear la lista de productos
            // ==========================================
    
            List<string> productos = new List<string>();

            Console.WriteLine("==================================");
            Console.WriteLine(" 🛒 LISTA DE SUPERMERCADO ");
            Console.WriteLine("==================================");
            Console.WriteLine("Escribe los productos que deseas agregar.");
            Console.WriteLine("Cuando termines, escribe 'salir'.");
            Console.WriteLine();

            // ==========================================
            // 📌 PASO 2: Bucle para ingresar productos
            // ==========================================
    
            while (true)
        {
            Console.Write("Agregar producto: ");
            string producto = Console.ReadLine();

            // Verificar si el usuario quiere salir
            if (producto.ToLower() == "salir")
            {
                break; // Termina el bucle
            }

            // Agregar producto a la lista
            productos.Add(producto);

            Console.WriteLine("Producto agregado ✔");
            Console.WriteLine();
        }

        // ==========================================
        // 📌 PASO 3: Mostrar lista final
        // ==========================================
    
        Console.WriteLine();
        Console.WriteLine("==================================");
        Console.WriteLine(" 📝 TU LISTA DE SUPERMERCADO ");
        Console.WriteLine("==================================");

        foreach (string item in productos)
        {
            Console.WriteLine("- " + item);
        }

        Console.WriteLine();
        Console.WriteLine("✅ ¡Gracias por usar la lista!");
        }

            

            return listaCompras;
        }

        /// <summary>
        /// 3. EL BUSCADOR (Reto)
        /// 
        /// PISTAS:
        /// - Crea un 'Random' para generar números aleatorios
        /// - Crea un array de 'int' con 10 elementos
        /// - Usa un bucle 'for' para llenar el array con números aleatorios (0-100)
        ///   Puedes usar: random.Next(0, 101)
        /// - Recorre el array con otro bucle 'for' buscando el número de la variable 'numeroBuscado'
        /// - Si encuentras el número, retorna 'true'
        /// - Si terminas el bucle sin encontrarlo, retorna 'false'
        /// 
        /// BONUS: Muestra los números generados en el array
        /// </summary>
        /// <param name="numeroBuscado">El número que el usuario quiere buscar</param>
        /// <returns>true si el número está en el array, false si no</returns>
        public bool BuscarNumeroDinamico(int numeroBuscado)
        {
            // TODO: Implementar la búsqueda de número en array aleatorio
            bool encontrado = false;
            Random random = new Random();
            

        public bool BuscarNumero(int numeroBuscado)
        {
            // ==========================================
            // 📌 PASO 1: Crear objeto Random
            // ==========================================
            Random random = new Random();

            // ==========================================
            // 📌 PASO 2: Crear array de 10 números
            // ==========================================
            int[] numeros = new int[10];

            // ==========================================
            // 📌 PASO 3: Llenar el array con números aleatorios
            // ==========================================
            Console.WriteLine("Números generados:");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(0, 101); // Números entre 0 y 100
                Console.Write(numeros[i] + " ");
            }

            Console.WriteLine(); // Salto de línea
            Console.WriteLine();

            // ==========================================
            // 📌 PASO 4: Buscar el número
            // ==========================================
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    Console.WriteLine("✅ Número encontrado en la posición: " + i);
                    return true;
                }
            }
 
                // ==========================================
                // 📌 PASO 5: Si no se encontró
                // ==========================================
                Console.WriteLine("❌ Número no encontrado.");
                return false;
            }


            return encontrado;
        }

        
    }
}
