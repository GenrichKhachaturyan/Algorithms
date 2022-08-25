using System;
namespace Geek
{

    public class GeekList<T>
    {
        public class Node
        {
            public T Value { get; set; }

            public Node? Next { get; internal set; }

            public Node? Prev { get; internal set; }

            internal GeekList<T> List { get; set; }

            public int CountNode { get; internal set; }

            internal Node(GeekList<T> List, T value)
            {
                CountNode++;
                Value = value;
                this.List = List;
            }
        }


        public Node? First { get; set; }

        public Node? Last { get; set; }

        public int CountNodeList { get; private set; }

        /// <summary>
        /// добавляет новый элемент списка
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node AddFirts(T value)
        {
            var node = new Node(this, value);

            CountNodeList++;

            if (First is null)
            {
                First = node;
                Last = node;

                return node;
            }

            node.Next = First;
            First.Prev = node;
            First = node;

            return node;
        }
        /// <summary>
        /// Добавляет новый элемент списка после определённого элемента
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node AddAfter(Node Position, T value)
        {
            var node = new Node(this, value);

            node.Next = Position.Next;
            node.Prev = Position;

            CountNodeList++;

            Position.Next = node;
            node.Next!.Prev = node;

            return node;
        }
        /// <summary>
        /// Удаление через порядковый номер
        /// </summary>
        /// <param name="index">Порядковый номер</param>
        /// <param name="list"></param>
        /// <returns></returns>

        public Node RemoveIndx(int index)
        {
            var node = First;

            while (node != null)
            {
                if (node.CountNode == index)
                {
                    node.Prev.Next = node.Next;
                    node.Next.Prev = node.Prev;

                    node.Next = null;
                    node.Prev = null;


                    CountNodeList--;
                    return node.Value;
                }

                node = node.Next;
            }
            return null;



        }
        /// <summary>
        /// Удаление через указанный элемент
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public T RemoveNode(Node node)
        {
            if (ReferenceEquals(First, Last)) // в списке последний узел
            {
                First = null;
                Last = null;
                CountNodeList--;
                return node.Value;
            }

            if (ReferenceEquals(node, First))
            {
                First = node.Next;
                First.Prev = null;
                CountNodeList--;
                return node.Value;
            }

            if (ReferenceEquals(node, Last))
            {
                Last = node.Prev;
                Last.Next = null;
                CountNodeList--;
                return node.Value;
            }

            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;

            node.Next = null;
            node.Prev = null;

            CountNodeList--;

            return node.Value;
        }


        /// <summary>
        /// поиск элемента с определённым значением
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node FindNodeByValue(T value) 
        {
            var node = First;

            while (node != null)
            {
                if (node.Value == value)
                    return node;

                node = node.Next;
            }
            return null;

        }
    }
}

