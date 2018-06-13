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
        String dips_fact = "DIPS AS is a great place to work";
        String distinctConcat  = solution.distinctConcat(dips_fact);

        Assert.assertEquals("DIPS AS is a great place to work", distinctConcat );
        Succeeded(1);
    }

    @Test
    public void DIPS_Fact_2() throws Exception {
        String dips_fact = "DIPS AS is a great place to work.\n" +
                "We have open positions";

        String distinctConcat  = solution.distinctConcat(dips_fact);

        Assert.assertEquals("DIPS AS is a great place to work. We have open positions", distinctConcat );
        Succeeded(2);
    }

    @Test
    public void DIPS_Fact_3() throws Exception {
        String dips_fact = "DIPS AS is a great place to work.\n" +
                "We have open positions\n" +
                "in Trondheim, Bodø, Oslo and Tromsø";
        String distinctConcat  = solution.distinctConcat(dips_fact);

        Assert.assertEquals("DIPS AS is a great place to work. We have open positions in Trondheim, Bodø, Oslo and Tromsø", distinctConcat );
        Succeeded(3);
    }

    @Test
    public void DIPS_Fact_4() throws Exception {
        String dips_fact = "DIPS AS is a great place to work.\n" +
                "We have open positions\n" +
                "in Trondheim, Bodø, Oslo and Tromsø\n" +
                "in Trondheim, Bodø, Oslo and Tromsø";
        String distinctConcat  = solution.distinctConcat(dips_fact);

        Assert.assertEquals("DIPS AS is a great place to work. We have open positions in Trondheim, Bodø, Oslo and Tromsø", distinctConcat );
        Succeeded(4);
    }

    @Test
    public void DIPS_Fact_5() throws Exception {
        String dips_fact = "DIPS AS is a great place to work.\n" +
                "DIPS AS is a great place to work.\n" +
                "We have open positions\n" +
                "in Trondheim, Bodø, Oslo and Tromsø.\n" +
                "in Trondheim, Bodø, Oslo and Tromsø.\n" +
                "Come join us!";
        String distinctConcat  = solution.distinctConcat(dips_fact);

        Assert.assertEquals("DIPS AS is a great place to work. We have open positions in Trondheim, Bodø, Oslo and Tromsø. Come join us!", distinctConcat );
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