using System;

namespace AttributePractice{
    public class NumberAttribute : Attribute {
        public int num {get; set;}

        public NumberAttribute(int n){
            num = n;
        }
    }
}