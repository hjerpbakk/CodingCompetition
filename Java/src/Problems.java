import org.junit.*;

import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

public class Problems {
    //region
    private Solution solution;

    @Before
    public void setUp() throws Exception {
        solution = new Solution();
    }
    //endregion

    @Test
    public void DIPS_Fact_1() throws Exception {
        String dips_fact = "DIPS AS har 6 kontorer: Trondheim, Bodø, Tromsø, Oslo, Bergen og Stockholm.";
        int number = solution.extractNumber(dips_fact);

        Assert.assertEquals(6, number);
        Succeeded(1);
    }

    @Test
    public void DIPS_Fact_2() throws Exception {
        String dips_fact = "DIPS AS har hatt bursdag og i år fylte vi 30 :)";
        int number = solution.extractNumber(dips_fact);

        Assert.assertEquals(30, number);
        Succeeded(2);
    }

    @Test
    public void DIPS_Fact_3() throws Exception {
        String dips_fact = "DIPS AS lager pasientdatasystemer for 85 % av det norske markedet.";
        int number = solution.extractNumber(dips_fact);

        Assert.assertEquals(85, number);
        Succeeded(3);
    }

    @Test
    public void DIPS_Fact_4() throws Exception {
        String dips_fact = "DIPS blir brukt av over 80000 brukere hver dag.";
        int number = solution.extractNumber(dips_fact);

        Assert.assertEquals(80000, number);
        Succeeded(4);
    }

    @Test
    public void DIPS_Fact_5() throws Exception {
        String dips_fact = "DIPS AS har 280 fantastiske medarbeidere som venter spent på å treffe akkurat deg.";
        int number = solution.extractNumber(dips_fact);

        Assert.assertEquals(280, number);
        Succeeded(5);
    }

    //region
    private static int[] results;

    @BeforeClass
    public static void setUpClass() throws Exception {
        results = new int[5];
    }

    @AfterClass
    public static void teardownClass() throws Exception {
        String resultString = "";
        for (int res :
                results) {
            resultString += res + ",";
        }
        resultString = resultString.substring(0, resultString.length() - 1);
        Path path = Paths.get("C:\\Users\\roh\\AppData\\Roaming\\DIPS Coding Competition\\results.txt");
        Files.write(path, resultString.getBytes());
    }

    private static void Succeeded(int n) {
        results[n - 1] = 1;
    }
    //endregion
}