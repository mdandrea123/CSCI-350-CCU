object Main {
  def main(args: Array[String]): Unit = {
    println("Factorial of 9:")
    println(f(9))
    println("Factorial of 5:")
    println(f(5))
    println("Factorial of 7:")
    println(f(7))
  }

  def f(i: Int): Int =
  if (i > 1){
    i * f(i-1) 
  } else{
    1
  }
}