# https://www.codewars.com/kata/514a024011ea4fb54200004b

# Write a function that when given a URL as a string, parses out just the domain name and returns it as a string. For example:

# domainName("http://github.com/carbonfive/raygun") == "github" 
# domainName("http://www.zombie-bites.com") == "zombie-bites"
# domainName("https://www.cnet.com") == "cnet"

# good chance to practice some regex!

def domain_name(url)
    url = url.gsub(/.+\/\/|www.|\..+/, '')
    return url
end

testA = "http://google.com"
testB = "http://google.co.jp"
testC = "www.xakep.ru"
testD = "https://youtube.com"

puts domain_name(testA)
puts domain_name(testB)
puts domain_name(testC)
puts domain_name(testD)