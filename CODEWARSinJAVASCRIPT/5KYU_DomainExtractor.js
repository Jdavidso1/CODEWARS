// https://www.codewars.com/kata/514a024011ea4fb54200004b

// Write a function that when given a URL as a string, parses out just the domain name and returns it as a string. For example:

// domainName("http://github.com/carbonfive/raygun") == "github" 
// domainName("http://www.zombie-bites.com") == "zombie-bites"
// domainName("https://www.cnet.com") == "cnet"

// good chance to practice some regex!

function domainName(url) {
    url = url.replace(/.+\/\/|www.|\..+/g, '');
    return url;
}

let testA = "http://google.com"
let testB = "http://google.co.jp"
let testC = "www.xakep.ru"
let testD = "https://youtube.com"

console.log(domainName(testA));
console.log(domainName(testB));
console.log(domainName(testC));
console.log(domainName(testD));