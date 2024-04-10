
URL GitHub Repository: https://github.com/osLeonardo/LinguagensFormais


Exemples to copy/paste in the API (same as the 'examples' endpoint response):

example 01:
{
  "n": [ "S", "A" ],
  "t": [ "0", "1", "2" ],
  "p": {
    "S": [ "0A", "1S", "2S" ],
    "A": [ "0A", "1S", "2S", "" ]
  },
  "s": "S"
}

example 02:
{
  "n": [ "S", "A", "B", "C" ],
  "t": [ "a", "b", "c" ],
  "p": {
    "S": [ "ABC" ],
    "A": [ "aA", "a" ],
    "B": [ "bB", "" ],
    "C": [ "cA" ]
  },
  "s": "S"
}

example 03:
{

  "n": [ "S", "A", "B" ],
  "t": [ "0", "1" ],
  "p": {
    "S": [ "0B", "1A" ],
    "A": [ "0", "0S", "1AA" ],
    "B": [ "1", "1S", "0BB" ]
  },
  "s": "S"
}

example 04:
{
  "n": [ "S", "A", "B", "C" ],
  "t": [ "a", "b", "c" ],
  "p": {
    "S": [ "aA" ],
    "A": [ "", "aB", "bC", "cC" ],
    "B": [ "aA" ],
    "C": [ "bC", "cC", "" ]
  },
  "s": "S"
}

example 05:
{
  "n": [ "S", "A", "B", "C" ],
  "t": [ "", "a", "b" ],
  "p": {
    "S": [ "AB", "CA" ],
    "A": [ "a", "b" ],
    "B": [ "BC", "b" ],
    "C": [ "AB", "" ]
  },
  "s": "S"
}
