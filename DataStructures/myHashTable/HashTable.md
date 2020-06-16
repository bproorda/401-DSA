# HashTable

## Summary
The hash table is a interesting and somewhat complicated data structure. It takes in a key value pair, where the value
can be anything from an integer to an object. Using a hash function the key is transformed into an index. This index 
gives the entry, or bucket, in the an array where the pair is to be entered. If two pairs have the same indices a colision may occur.
To prevent this, each bucket in the array is a list of nodes. The nodes have the key, the value, and a reference to the 
next node in the list. 

## Efficiency
One of the may goals of creating a hash table to have a Big O(O1). Having the key to find the index allows this, but only 
if the key value pair is the only entry in that bucket. If there is more than one pair/node in the bucket than the efficiency
becomes O(k), where k is number of nodes in the bucket. The more buckets you have, and the better hashing algorithm you have,
the small this will be.

## Methods 
- Add(string key, T Value): Adds a key/value pair to the hash table;
- Get(string key): Retrieves a value by the associated key. If the no such key is found, it will throw an error.
- Contains(string key): Returns a boolean regarding whether or not such a key/value pair exists. Will not throw an error,
if no such key exists.
- GetHashCode(string key, int bucketCount): Determines the index of pair based off of the key and the number of buckets 
in the table.
- FindRepeatedWord(string input): Takes in a string up and returns the first word that is repeated. If no word is repeated, 
it will return null; 