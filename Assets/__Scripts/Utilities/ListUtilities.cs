using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Utilities
{
    public class ListUtilities
    {
        // Static method
        // return stack of anything 
        public static Stack<T> CreateShuffledStack<T>(IList<T> values) where T : Object
        {
            // creating a new stack that will be returned
            var stack = new Stack<T>();
            // create a list which is based on the values that get passed in
            var list = new List<T>(values);

            // take elements at random order
            while(list.Count > 0)
            {
                // get the next item at random index
                var randomIndex = Random.Range(0, list.Count - 1);
                // when item is picked
                var randomItem = list[randomIndex];
                // remove from the list at random index
                list.RemoveAt(randomIndex);
                // push the random index to a stack
                stack.Push(randomItem);
            }

            // return the stack
            return stack;
        }
    }
}