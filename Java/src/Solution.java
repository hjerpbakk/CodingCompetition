public class Solution {
    /**
     * This method takes a string containing a
     * single number and should return this number.
     *
     * Example:
     * Given: "DIPS blir brukt av over 80000 brukere hver dag."
     * Return: 80000
     *
     * @param dipsFact A string containg a fact about DIPS and a single number.
     * @return The number in the string.
     */
    public int extractNumber(String dipsFact) {
        String[] splitString = dipsFact.split(" ");
        for (String word :
                splitString) {
            if (word.matches("^-?\\d+$")) {
                return Integer.parseInt(word);
            }
        }

        return 0;
    }
}
