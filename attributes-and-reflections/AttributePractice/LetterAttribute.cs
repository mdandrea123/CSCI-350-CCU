using System;

namespace AttributePractice{
    public class LetterAttribute : Attribute{
        public char let {get; set;}

        public LetterAttribute(char l){
            let = l;
        }
    }
}