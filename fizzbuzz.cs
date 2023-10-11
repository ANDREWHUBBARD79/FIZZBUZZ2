//Write a public method that accepts a number
//1. Access Modifier
//2. return type
//3. Method Name
//4. Parameters
//5. Scope


public string fizzbuzz(int number)
{
var answer = "";
// when number is divisible by 3 return the word fizz

if(number % 3 == 0)
{
answer = "fizz";
}

if(number % 5 == 0)

{
    answer += "buzz"; //answer = answer + "buzz"
}

return answer;

// when number is divisible by 5 return the word buzz
// when number is divisble by both return the word fizzbuzz


}
