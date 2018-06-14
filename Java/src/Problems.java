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
        int median  = solution.median("1, 2, 3, 4, 5");

        Assert.assertEquals(3, median);
        Succeeded(1);
    }

    @Test
    public void DIPS_Fact_2() throws Exception {
        int median  = solution.median("45, 90, 1, 1235, 17, 3, 9");

        Assert.assertEquals(17, median);
        Succeeded(2);
    }

    @Test
    public void DIPS_Fact_3() throws Exception {
        int median  = solution.median("32, 54, 12, 64, 42");

        Assert.assertEquals(42, median);
        Succeeded(3);
    }

    @Test
    public void DIPS_Fact_4() throws Exception {
        int median  = solution.median("5, 4, 3, 2, 1");

        Assert.assertEquals(3, median);
        Succeeded(4);
    }

    @Test
    public void DIPS_Fact_5() throws Exception {
        int median  = solution.median("90, 72, 17, 15, 19");

        Assert.assertEquals(19, median);
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