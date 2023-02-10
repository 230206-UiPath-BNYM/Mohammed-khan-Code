imports system
module program
sub main (args as strings())
console.writeline("Hello World")
dim greeting as string = greeter("casual")
console.writeline(greeting)
end sub
function greeter(greeting_type as string) as string
select case greeting_type
case "casual"
return "sup"
case "business casual"
return "salutations"
case "full business"
return "to whom it may concern"
case else
return "hello"
end select
end function
sub  guessinggame(guess as integer)
dim rnd as random = new random()
dim mysterynumber as integer = rnd.next(1,2)
if guess<>mysterynumber then 
console.writeline("wrong guess")
else console.writeline("good guess")
end if 
end sub
end module