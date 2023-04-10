function checkPalindrome(string){
    const len = string.length;

    for (let i = 0; i < len/2; i++){
        if (string[i] != string[len - 1 - i]){
            return "This string is not a palindrome";
        }
    }
    return "This string is a palindrome";
}

const string = prompt("Enter a string:");

const value = checkPalindrome(string);

console.log(value);