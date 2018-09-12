import re

# <summary>
# Your task is to calculate the Hamming difference between 
# two DNA strands. It is found by comparing two DNA strands 
# and counting how many of the nucleotides are different 
# from their equivalent in the other string.
# 
# Example:
# GAGCCTACTAACGGGAT
# CATCGTAATGACGGCCT
# ^ ^ ^  ^ ^    ^^
# 
# Return:
# 7
# 
# </summary>
# <param name="firstStrand">The first DNA strand.</param>
# <param name="secondStrand">The second DNA strand.</param>
# <returns>The Hamming distance between two DNA strands.</returns>
def distance(firstStrand, secondStrand):
    return 0