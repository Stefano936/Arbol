using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person enrique = new Person("Enrique", 87);
            Person juan = new Person("Juan", 45);
            Person pablo = new Person("Pablo", 52);
            Person daniela = new Person("Daniela", 48);
            Person martina = new Person("Martina", 5);
            Person valeria = new Person("Valeria", 16);
            Person olivia = new Person("Olivia", 15);
            Person maria = new Person("María", 17);
            Person diego = new Person("Diego", 12);
            Node nEnrique = new Node(enrique);
            Node nMartina = new Node(martina);
            Node nJuan = new Node(juan);
            Node nMaria = new Node(maria);
            Node nPablo = new Node(pablo);
            Node nDaniela = new Node(daniela);
            Node nOlivia = new Node(olivia);
            Node nValeria = new Node(valeria);
            Node nDiego = new Node(diego);

            nEnrique.AddChildren(nJuan);
            nEnrique.AddChildren(nDaniela);
            nEnrique.AddChildren(nPablo);

            nJuan.AddChildren(nMartina);
            nDaniela.AddChildren(nValeria);

            nPablo.AddChildren(nDiego);
            nPablo.AddChildren(nMaria);
            nPablo.AddChildren(nOlivia);

            // visitar el árbol aquí
        }
    }
}
